using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;


namespace Stepper.BL.Controller
{
    public class SerialController : SlipBase
    {

        



        private const int MESSAGE_LENGTH = 5; //Количество байт в одном сообщении
        public byte[] ReceivedCode { get; }
        /// <summary>
        /// Код операции.
        /// </summary>
        //public byte OperationCode { get; set; }
        /// <summary>
        /// Код данных.
        /// </summary>
        public Dictionary<DeviceAddress, byte[]> PlayLoad = new Dictionary<DeviceAddress, byte[]>
        {
            [DeviceAddress.Xaxis] = new byte[0],
            [DeviceAddress.Yaxis] = new byte[0],
            [DeviceAddress.Zaxis] = new byte[0]
        };
        /// <summary>
        /// Код контрольной суммы.
        /// </summary>
        public byte CRC { get; set; }
        public Dictionary<DeviceAddress, byte> OperationCode = new Dictionary<DeviceAddress, byte>
        {
            [DeviceAddress.Xaxis] = 0,
            [DeviceAddress.Yaxis] = 0,
            [DeviceAddress.Zaxis] = 0
        };
        public Dictionary<DeviceAddress, UInt16> AngleCode = new Dictionary<DeviceAddress, UInt16>
        {
            {DeviceAddress.Xaxis, 0 },
            {DeviceAddress.Yaxis, 0 },
            {DeviceAddress.Zaxis, 0 }
        };

        public SerialPort _serialPort { get; set; }
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
        private List<byte> slipMessage = new List<byte>(32);
        private List<byte> dataReceived = new List<byte>(32);
        /// <summary>
        /// Событе получения данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceiveMessage(dataReceived, _serialPort);
            bool isDataGood = CheckCRC(dataReceived);
            if (isDataGood)
            {
                SlipReceivedMessage(dataReceived, slipMessage);
                var device = CheckDevice(slipMessage);
                var opCode = CheckOperationCode(slipMessage);
                ReadMessage(device, opCode, slipMessage);
            }
            else
            {

            }
            slipMessage.Clear();
            dataReceived.Clear();
        }




        /// <summary>
        /// Если данные корректны - сохраняем их.
        /// </summary>
        /// <param name="dataReceived">полученные данные</param>
        /// <param name="isDataGood">флаг проверки</param>
        private void SetCode(List<byte> slipMessage)
        {

               // OperationCode = dataReceived[1];
                byte[] tmp = { dataReceived[3], dataReceived[2] };
               
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
            var slip = CreateSlipMessage(msg);
            _serialPort.Write(slip, 0, slip.Length);
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

        private void ReadMessage(DeviceAddress address, OperationCodes opCode, List<byte> slipMessage)
        {
            OperationCode[address] = (byte)opCode;
            PlayLoad[address] = slipMessage.ToArray();
            if (opCode == OperationCodes.AngleCode)
            {
                byte[] tmp = { slipMessage[1], slipMessage[0] };
                AngleCode[address] = BitConverter.ToUInt16(tmp, 0);
            }
            if (DataReceived != null) DataReceived(this, EventArgs.Empty);
        }


                    
            
        
    }
}
