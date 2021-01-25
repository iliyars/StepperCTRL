using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;


namespace Stepper.BL.Controller
{
    public class SerialController
    {
        private SerialPort _serialPort = new SerialPort();

        private const int MESSAGE_LENGTH = 5; //Количество байт в одном сообщении
        public byte[] ReceivedCode { get; }
        /// <summary>
        /// Код операции.
        /// </summary>
        public byte OperationCode { get; set; }
        /// <summary>
        /// Код данных.
        /// </summary>
        public UInt16 PlayLoad { get; set; }
        /// <summary>
        /// Код контрольной суммы.
        /// </summary>
        public byte CRC { get; set; }


        public event EventHandler DataReceived;

        /// <summary>
        /// Пдключение к порту.
        /// </summary>
        /// <param name="portName">Имя порта.</param>
        /// <param name="baudRate">Бод рейт.</param>
        public void ConnectionSerial(string portName, int baudRate)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;

            try
            {
                _serialPort.Open();
                _serialPort.DataReceived += _serialPort_DataReceived;
            }
            catch (Exception )
            {
                throw new Exception($"Невозможно подключиться к {_serialPort.PortName}, возможно порт занят другой программой.");
            }
        }

        /// <summary>
        /// Событе получения данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    int dataLength = _serialPort.BytesToRead;
                    if (dataLength >= MESSAGE_LENGTH)
                    {
                        byte[] dataReceived = new byte[dataLength];
                        _serialPort.Read(dataReceived, 0, dataLength); // Заполняем буфер байтами
                        if (dataReceived[0] == 0x01)
                       {
                            
                            bool isDataGood = CheckReceivedCode(dataReceived);
                            SetCode(dataReceived, isDataGood);
                       }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Получение доступных портов.
        /// </summary>
        /// <returns>string[]</returns>
        public string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// Проверка коректности полученных данных.
        /// </summary>
        /// <param name="dataReceived">массив полученных байт.</param>
        /// <returns>bool</returns>
        private bool CheckReceivedCode(byte[] dataReceived)
        {
            //TODO: Проверка полученных  данных
            return true;
        }

        /// <summary>
        /// Если данные корректны - сохраняем их.
        /// </summary>
        /// <param name="dataReceived">полученные данные</param>
        /// <param name="isDataGood">флаг проверки</param>
        private void SetCode(byte[] dataReceived, bool isDataGood)
        {
            OperationCode = dataReceived[0];
            byte[] tmp = { dataReceived[1], dataReceived[2] };
            PlayLoad = BitConverter.ToUInt16(tmp, 0);
            CRC = dataReceived[3];
            if (DataReceived != null) DataReceived(this, EventArgs.Empty);
        }
        
        public void DisconnectSerial()
        {
            _serialPort.Close();
        }
        /// <summary>
        /// Формирует и отправляет пакет байт с коммандой
        /// </summary>
        /// <param name="opCode">код команды 1 байт</param>
        /// <param name="acceleration">ускорение 2 байта</param>
        /// <param name="decceleration">торможение 2 байта</param>
        /// <param name="speed">скорость 2 байта </param>
        /// <param name="redductionCoeff">коэффициент редукции 1 байт</param>
        /// <param name="zeroCode">код нуля 2 байта</param>
        /// <param name="microSteps">микро шаг 1 байт</param>
        /// <param name="angleCode">код нового положения</param>
        public void SendCommand(byte opCode, UInt16 angleCode, UInt16 acceleration, UInt16 decceleration, UInt16 speed, byte redductionCoeff, UInt16 zeroCode, byte microSteps )
        {
            List<byte> mesagge = new List<byte>();
            mesagge.Add(opCode);
            InsertIntToByteList(ref mesagge, angleCode);
            InsertIntToByteList(ref mesagge, acceleration);
            InsertIntToByteList(ref mesagge, decceleration);
            InsertIntToByteList(ref mesagge, speed);
            mesagge.Add(redductionCoeff);
            InsertIntToByteList(ref mesagge, zeroCode);
            mesagge.Add(microSteps);

            byte[] msg = mesagge.ToArray();

            _serialPort.Write(msg, 0, msg.Length);
        }
        /// <summary>
        /// Посылает только код команды и код угла. Используется если параметры разгона не были изменены.
        /// </summary>
        /// <param name="opCode">код команды.</param>
        /// <param name="angleCode">код угла.</param>
        public void SendCommand(byte opCode, UInt16 angleCode)
        {
            List<byte> mesagge = new List<byte>();
            mesagge.Add(opCode);
            InsertIntToByteList(ref mesagge, angleCode);
            byte[] msg = mesagge.ToArray();

            _serialPort.Write(msg, 0, msg.Length);
        }




        private void InsertIntToByteList(ref List<byte> msg, UInt16 num)
        {
            byte highByte = (byte)(num >> 8);
            byte lowByte = (byte)(num);
            msg.Add(highByte);
            msg.Add(lowByte);
            
        }
    }
}
