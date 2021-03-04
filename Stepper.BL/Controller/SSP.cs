using Stepper.BL.Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace Stepper.BL.Controller
{

    public class SSP : SlipBase
    {
        public SerialPort PortSSP { get; set; }
        public event EventHandler DataReceived;

        private List<byte> dataReceived = new List<byte>(32);
        private List<byte> slipMessage = new List<byte>(32);
        public void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceiveMessage(dataReceived, PortSSP);
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
            PortSSP = new SerialPort();
            PortSSP.PortName = portName;
            PortSSP.BaudRate = 115200;
            PortSSP.DataBits = 8;
            PortSSP.Parity = Parity.None;
            PortSSP.StopBits = StopBits.Two;

            try
            {
                PortSSP.Open();
                PortSSP.DataReceived += _serialPort_DataReceived;
            }
            catch (Exception)
            {
                throw new Exception($"Невозможно подключиться к {PortSSP.PortName}, возможно порт занят другой программой.");
            }
        }





    }
}
