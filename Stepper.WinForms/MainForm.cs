using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stepper.BL.Controller;
using Stepper.BL.Model;

namespace Stepper.WinForms
{
    public partial class MainForm : Form
    {
        readonly SerialController serialController = new SerialController();
        readonly FileSaver fileSaver = new FileSaver();
        readonly AngleConverter angleConverter = new AngleConverter();

        private bool dirY = true; // Направление вращения по Y
        private bool dirZ = true; // Направление вращения по Я

        int i = 0;
        public MainForm()
        {
            InitializeComponent();
            SetPorts();


            serialController.DataReceived += SerialController_DataReceived;
            btn_connect.Click += Btn_connect_Click;
            cb_writeFile.Click += Cb_writeFile_Click;
            btn_disconnect.Click += Btn_disconnect_Click;
            gb_newPositionY.Click += Gb_newPositionY_Click;
            gb_newPosZ.Click += Gb_newPosZ_Click;
            foreach (Control ctrl in gb_newPositionY.Controls)
            {
                ctrl.Click += Ctrl_Click;
            }
            foreach (Control ctrl in gb_newPosZ.Controls)
            {
                ctrl.Click += CtrlNewZ_Click;
            }
           
        }


        private void Btn_connect_Click(object sender, EventArgs e)
        {
            serialController.ConnectionSerial(cb_ports.Text, int.Parse(cb_boudRate.Text));
        }
        private void Btn_disconnect_Click(object sender, EventArgs e)
        {
            serialController.DisconnectSerial();
        }

        private void Cb_writeFile_Click(object sender, EventArgs e)
        {
            fileSaver.CreateDataFile(cb_writeFile.Checked);
            tb_crc.Text = cb_writeFile.Checked.ToString();
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
        private void SetPorts()
        {
            cb_ports.Items.AddRange(serialController.GetPorts());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
                //this.TopMost = true;
                //this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

        }
        #region Обработка нажатий кнопок задания угла Y
        private void Gb_newPositionY_Click(object sender, EventArgs e)
        {
            Angle angle = new Angle(nud_gradY.Value, nud_minY.Value, nud_secY.Value);
            l_newCodeY.Text = angleConverter.AngleToCode(angle, dirY).ToString();

        }
        private void Ctrl_Click(object sender, EventArgs e)
        {
            Angle angle = new Angle(nud_gradY.Value, nud_minY.Value, nud_secY.Value);
            l_newCodeY.Text = angleConverter.AngleToCode(angle, dirY).ToString();
        }
        private void btn_MaxAngY_Click(object sender, EventArgs e)
        {
            nud_gradY.Value = 8;
            nud_minY.Value = 30;
            nud_secY.Value = 0;
            dirY = true;
            btn_dirY.Text = "+";
        }

        private void btn_ZeroAngY_Click(object sender, EventArgs e)
        {
            nud_gradY.Value = 0;
            nud_minY.Value = 0;
            nud_secY.Value = 0;
            dirY = true;
            btn_dirY.Text = "+";
        }

        private void btn_MinAngY_Click(object sender, EventArgs e)
        {
            nud_gradY.Value = 8;
            nud_minY.Value = 30;
            nud_secY.Value = 0;
            dirY = false;
            btn_dirY.Text = "-";
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            dirY = !dirY;
            if (dirY)
                btn_dirY.Text = "+";
            else
                btn_dirY.Text = "-";
        }
        #endregion

        #region Обработка нажатий кнопок задания угла Z
        private void CtrlNewZ_Click(object sender, EventArgs e)
        private void btn_maxAngZ_Click(object sender, EventArgs e)
        {
            nud_gradZ.Value = 8;
            nud_minZ.Value = 30;
            nud_secZ.Value = 0;
            dirZ = true;
            btn_dirZ.Text = "+";
        }
        private void btn_zeroAngZ_Click(object sender, EventArgs e)
        {
            nud_gradZ.Value = 0;
            nud_minZ.Value = 0;
            nud_secZ.Value = 0;
            dirZ = true;
            btn_dirZ.Text = "+";
        }
        private void btn_minAngZ_Click(object sender, EventArgs e)
        {
            nud_gradZ.Value = 8;
            nud_minZ.Value = 30;
            nud_secZ.Value = 0;
            dirZ = false;
            btn_dirZ.Text = "-";
        }
        private void btn_dirZ_Click(object sender, EventArgs e)
        {
            dirZ = !dirZ;
            if (dirZ)
                btn_dirZ.Text = "+";
            else
                btn_dirZ.Text = "-";
        }
        private void Gb_newPosZ_Click(object sender, EventArgs e)
        {
            Angle angle = new Angle(nud_gradZ.Value, nud_minZ.Value, nud_secZ.Value);
            l_newCodeZ.Text = angleConverter.AngleToCode(angle, dirZ).ToString();
        }
        #endregion

    }
}
