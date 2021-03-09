using Stepper.BL.Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using static Stepper.BL.Model.LaserGyro;

namespace Stepper.BL.Controller
{

    public class SSP : SlipBase
    {


        public readonly byte[] ANGLE_SPEED = { 0x00, 0x00 };
        public readonly byte[] TEMEPERATURE = { 0x03, 0x00 };
        public readonly byte[] TIME = { 0x18, 0x00 };
        public readonly byte[] LINE = { 0x0C, 0x00 };

        public SerialPort portSSP { get; set; }
        public event EventHandler DataReceived;
        LaserGyro gyro = new LaserGyro(0x02, 0x64);
        private List<byte> dataReceived = new List<byte>(32);
        private List<byte> slipMessage = new List<byte>(32);
        public void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceiveMessage(dataReceived, portSSP);
            bool isDataGood = CheckCRC(dataReceived);
            if (isDataGood)
            {
                SlipReceivedMessage(dataReceived, slipMessage);
                var device = CheckDevice(slipMessage);

            }
            else
            {

            }
            slipMessage.Clear();
            dataReceived.Clear();
        }

        public void ConnectSSP(string portName)
        {
            portSSP = new SerialPort();
            portSSP.PortName = portName;
            portSSP.BaudRate = 115200;
            portSSP.DataBits = 8;
            portSSP.Parity = Parity.None;
            portSSP.StopBits = StopBits.Two;

            try
            {
                portSSP.Open();
                portSSP.DataReceived += _serialPort_DataReceived;
            }
            catch (Exception)
            {
                throw new Exception($"Невозможно подключиться к {portSSP.PortName}, возможно порт занят другой программой.");
            }
        }

        public Commands SendPING(byte slaveAddress = 0x64, byte MasterAddres = 0x02)
        {
            byte[] ping = { slaveAddress, MasterAddres, 0x00 };
            SendSlipCommand(ping, portSSP);
            gyro.currentCommand = Commands.PING;
            return gyro.currentCommand;
        }

        public Commands SendINIT(byte slaveAddress = 0x64, byte masterAddres = 0x02)
        {
            byte[] init = { slaveAddress, masterAddres, 0x01 };
            SendSlipCommand(init, portSSP);
            gyro.currentCommand = Commands.PING;
            return gyro.currentCommand;
        }

        public Commands SendID(byte slaveAddress = 0x64, byte masterAddres = 0x02)
        {
            byte[] id = { slaveAddress, masterAddres, 0x08 };
            SendSlipCommand(id, portSSP);
            gyro.currentCommand = Commands.ID;
            return gyro.currentCommand;
        }
        /// <summary>
        /// Записывает по заданному адресу новые данные.
        /// Данные и адрес передаются младшим байтом вперёд.
        /// </summary>
        /// <param name="slaveAddress">Адрес ведомого устройства.</param>
        /// <param name="masterAddres">Адрес ведущего устройства.</param>
        /// <param name="adr">Адрес в памяти устройства для записы новых данных.</param>
        /// <param name="dat">Данные для записи.</param>
        public Commands SendWrite(byte[] adr, byte[] dat,byte slaveAddress = 0x64, byte masterAddres = 0x02 )
        {
            List<byte> write = new List<byte>() { slaveAddress, masterAddres, 0x07 };
            write.AddRange(adr);
            write.AddRange(dat);
            SendSlipCommand(write.ToArray(), portSSP);
            gyro.currentCommand = Commands.WRITE;
            return gyro.currentCommand;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="adr"></param>
        /// <param name="slaveAddress"></param>
        /// <param name="masterAddres"></param>
        /// <returns></returns>
        public Commands SendGet(byte[] adr, byte slaveAddress = 0x64, byte masterAddres = 0x02)
        {
            List<byte> get = new List<byte>() { slaveAddress, masterAddres, 0x04 };
            get.AddRange(adr);
            SendSlipCommand(get.ToArray(), portSSP);
            gyro.currentCommand = Commands.GET;
            return gyro.currentCommand;
        }


    }
}
