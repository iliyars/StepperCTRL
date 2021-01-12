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
        public MainForm()
        {
            InitializeComponent();
            SetPors();
        }


        public void SetPors()
        {
            cb_ports.Items.AddRange(serialController.GetPorts());
        }
    }
}
