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
        int i = 0;
        public MainForm()
        {
            InitializeComponent();
            SetPors();
            serialController.DataReceived += SerialController_DataReceived;

            btn_connect.Click += Btn_connect_Click;
        }



        private void Btn_connect_Click(object sender, EventArgs e)
        {
            serialController.ConnectionSerial(cb_ports.Text, int.Parse(cb_boudRate.Text));
        }

        private void SerialController_DataReceived(object sender, EventArgs e)
        {
            i++;
            this.BeginInvoke((Action)(() =>
            {
                tb_code.Text = serialController.OperationCode.ToString();
                tb_test.Text = i.ToString();
                tb_playLoad.Text = serialController.PlayLoad.ToString();
            }));

        }

        public void SetPors()
        {
            cb_ports.Items.AddRange(serialController.GetPorts());
        }
    }
}
