using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stepper.BL.Controller;

namespace Stepper.WinForms
{
    public partial class MainForm : Form
    {
        SerialController serialController = new SerialController();
        FileSaver fileSaver = new FileSaver();

        int i = 0;
        public MainForm()
        {
            InitializeComponent();
            SetPors();
            serialController.DataReceived += SerialController_DataReceived;
            btn_connect.Click += Btn_connect_Click;
            cb_writeFile.Click += Cb_writeFile_Click;
         }

        private void Cb_writeFile_Click(object sender, EventArgs e)
        {
            fileSaver.CreateDataFile(cb_writeFile.Checked);
            tb_crc.Text = cb_writeFile.Checked.ToString();
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            serialController.ConnectionSerial(cb_ports.Text, int.Parse(cb_boudRate.Text));
        }
        /// <summary>
        /// Отображение полученного кода в UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialController_DataReceived(object sender, EventArgs e)
        {
            i++;
            this.BeginInvoke((Action)(() =>
            {
                tb_code.Text = serialController.OperationCode.ToString();
                tb_test.Text = i.ToString();
                tb_playLoad.Text = serialController.PlayLoad.ToString();
            }));
            fileSaver.WriteDataFile(cb_writeFile.Checked, serialController.OperationCode, serialController.PlayLoad, serialController.CRC);
        }
        /// <summary>
        /// Получение доступных com-портов в UI
        /// </summary>
        public void SetPors()
        {
            cb_ports.Items.AddRange(serialController.GetPorts());
        }

        private void cb_writeFile_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
