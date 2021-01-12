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
        public event EventHandler DataReceived;


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
                        CheckReceivedCode(dataReceived);
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
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }


        private void CheckReceivedCode(byte[] dataReceived)
        {

        }


    }
}
