using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace Stepper.BL.Controller
{
    public abstract class SlipBase
    {
        protected const byte END = 0xC0;
        protected const byte ESC = 0xDB;
        protected const byte ESC_END = 0xDC;
        protected const byte ESC_ESC = 0xDD;
        protected const UInt16 mask = 0x1021;

        protected void Desconnect(SerialPort _serialPort)
        {
            _serialPort.Close();
        }
        /// <summary>
        /// Создаёт пакет байт с разбиением на кадры по RFC1055(SLIP)
        /// </summary>
        /// <param name="msg">пакет байт для разбиения</param>
        /// <returns></returns>
        protected byte[] CreateSlipMessage(byte[] msg)
        {
            List<byte> slipMessage = new List<byte>();
            slipMessage.Add(END);
            UInt16 crc = 0xFFFF;
            for(int i = 0; i < msg.Length; i++)
            {
                switch(msg[i])
                {
                    case END:
                        slipMessage.Add(ESC);
                        crc = UpdateCRC(crc, ESC);
                        slipMessage.Add(ESC_END);
                        crc = UpdateCRC(crc, ESC_END);
                        break;

                    case ESC:
                        slipMessage.Add(ESC);
                        crc = UpdateCRC(crc, ESC);
                        slipMessage.Add(ESC_ESC);
                        crc = UpdateCRC(crc, ESC_ESC);
                        break;

                    default:
                        slipMessage.Add(msg[i]);
                        crc = UpdateCRC(crc, msg[i]);
                        break;
                }
            }
            slipMessage.Add((byte)((crc << 8) >> 8)); // Младший байт контрольной суммы CRC0
            slipMessage.Add((byte)((crc << 8) >> 8)); // Старший байь=т контрольной суммы CRC1
            slipMessage.Add(END);
            return slipMessage.ToArray();
        }
        /// <summary>
        /// Изменяет тукещую контрольную сумму пакета при добавлении байта
        /// </summary>
        /// <param name="crc"> текущая контрольная сумма</param>
        /// <param name="c">новый байт</param>
        /// <returns></returns>
        protected UInt16 UpdateCRC(UInt16 crc, UInt16 c)
        {
            c <<= 8;
            for (int i = 0; i < 8; i++)
            {
                if (Convert.ToBoolean((crc ^ c) & 0x8000))
                {
                    crc = (ushort)((crc << 1) ^ mask);
                }
                else
                {
                    crc <<= 1;
                }
                c <<= 1;
            }
            return crc;
        }

        /// <summary>
        /// Разделяет полученный пакет байт 
        /// </summary>
        /// <param name="arr">полученный пакет байт</param>
        /// <returns></returns>
        protected void SlipReceivedMessage(List<byte> receivedMessage, List<byte> slipMessage)
        {
            
            for(int i = 0; i < receivedMessage.Count; i++)
            {
                switch (receivedMessage[i])
                {
                    case ESC:
                        switch (receivedMessage[++i])
                        {
                            case ESC_END:
                                slipMessage.Add(ESC_END);
                                break;
                            case ESC_ESC:
                                slipMessage.Add(ESC_ESC);
                                break;
                        } goto default;
                    default:
                        slipMessage.Add(receivedMessage[i]);
                        break;
                }
            }
        }
        /// <summary>
        /// Заполняет список полученным пакетом
        /// </summary>
        /// <param name="receivedMessage"></param>
        /// <returns></returns>
        protected bool ReceiveMessage(List<byte> receivedMessage, SerialPort _serialPort)
        {
            byte c;
            bool received = false;

            while (true)
            {
                c = (byte)_serialPort.ReadByte();
                switch (c)
                {
                    case END:
                        if (received)
                        {
                            _serialPort.DiscardInBuffer();
                            return received;
                        }
                        break;
                    case ESC:
                        c = (byte)_serialPort.ReadByte();
                        switch (c)
                        {
                            case ESC_END:
                                receivedMessage.Add(ESC_END);
                                c = END;
                                break;
                            case ESC_ESC:
                                receivedMessage.Add(ESC_ESC);
                                c = ESC;
                                break;
                        }
                        break;
                    default:
                        received = true;
                        receivedMessage.Add(c);
                        break;
                }
            }
        }

        protected bool CheckCRC(List<byte> arr)
        {
            UInt16 crc = 0xFFFF;
            for(int i = 0; i <= arr.Count-3; i++)
            {
                crc= UpdateCRC(crc, arr[i]);
            }
            byte crc0 = (byte)((crc << 8) >> 8); // Младший байт контрольной суммы CRC0
            byte crc1 = (byte)(crc >> 8); // Старший байь=т контрольной суммы CRC1
            if (arr.Count >= 4)
            {
                if ((crc0 == arr[arr.Count - 2]) && (crc1 == arr[arr.Count - 1]))
                {
                    arr.RemoveRange(arr.Count - 2, 2);
                    return true;
                }
            }
            
                return false;
        }

        protected DeviceAddress CheckDevice(List<byte> msg)
        {
            DeviceAddress addr = (DeviceAddress)msg[0];
            msg.RemoveAt(0);
            return addr;
        }   
            

        protected OperationCodes CheckOperationCode(List<byte> msg)
        {
            OperationCodes opCode = (OperationCodes)msg[0];
            msg.RemoveAt(0);
            return opCode;
        }

        /// <summary>
        /// Получение доступных портов.
        /// </summary>
        /// <returns>string[]</returns>
        public string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        public void SendSlipCommand(byte[] msg, SerialPort serialPort)
        {
            var slip = CreateSlipMessage(msg);
            serialPort.Write(slip, 0, slip.Length);
        }

        public enum DeviceAddress
        {
            Gyro = 0x64,
            Xaxis = 0x10,
            Yaxis = 0x20,
            Zaxis = 0x30,
            Error = 0xFF
        }

        public enum OperationCodes
        {
            AngleCode = 0x01,
            MoveParam = 0x02,
            Error = 0xFF
        }
    }


}
