using Stepper.BL.Controller;
using Stepper.BL.Model;
using System;
using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;
using static Stepper.BL.Controller.SlipBase;

namespace Stepper.WinForms
{
    public partial class MainForm : Form
    {
        readonly SerialController serialController = new SerialController();
        readonly FileManager fileManager = new FileManager();
        readonly AngleConverter angleConverter = new AngleConverter();
        readonly SSP ssp = new SSP();
        Dictionary<string, double> config;
        private bool dirY = true; // Направление вращения по Y
        private bool dirZ = true; // Направление вращения по Z
        private int newAng = 0;
        ChartController chartController = new ChartController(7, 200);
        TimerControl timerControl = new TimerControl();

        public MainForm()
        {
            InitializeComponent();
            SetPorts();
            fileManager.ReadBinFile();
            var tmp = fileManager.ShowCurrentConfig();
            tb_fileName.Text = fileManager.GetFilePath();
            fileManager.FileClosed += FileManager_FileClosed;
            serialController.DataReceived += SerialController_DataReceived;
            timerControl.Tick += TimerControl_Tick;
            btn_connect.Click += Btn_connect_Click;
            cb_writeFile.Click += Cb_writeFile_Click;
            btn_disconnect.Click += Btn_disconnect_Click;
            gb_newPositionY.Click += Gb_newPositionY_Click;
            gb_newPosZ.Click += Gb_newPosZ_Click;
            cb_microSteps.SelectedIndex = 0;
            fileManager.ReadCurrentConfigFile();
            chartX.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chartY.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chartZ.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            
            foreach (Control ctrl in gb_newPositionY.Controls)
            {
                ctrl.Click += Ctrl_Click;
            }
            foreach (Control ctrl in gb_newPosZ.Controls)
            {
                ctrl.Click += CtrlNewZ_Click;
            }
            cb_axisSelect.SelectedIndex = 0;
        }

        private void TimerControl_Tick(object sender, EventArgs e)
        {
            l_stopWatch.Text = timerControl.CurrentElapsedTimeStr;
        }

        private void FileManager_FileClosed(object sender, EventArgs e)
        {
            fileManager.ReadCurrentConfigFile();
            Dictionary<string, double> currConfig = fileManager.ShowCurrentConfig();
            tb_text.Clear();
            foreach (var pair in currConfig)
            {
                tb_text.AppendText($"{pair.Key}-{pair.Value}\n\n");
            }
            setNumsFromConfigFile(cb_axisSelect.SelectedIndex);
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            serialController.ConnectionSerial(cb_ports.Text, int.Parse(cb_boudRate.Text));
          // ssp.ConnectSSP("COM6");
        }
        private void Btn_disconnect_Click(object sender, EventArgs e)
        {
            serialController.DisconnectSerial();
        }

        private void Cb_writeFile_Click(object sender, EventArgs e)
        {
            fileManager.CreateDataFile(cb_writeFile.Checked);
        }

        /// <summary>
        /// Отображение полученного кода в UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialController_DataReceived(object sender, EventArgs e)
        {
            
            chartController.UpdateTime();
            this.BeginInvoke((Action)(() =>
            {
                l_recevedCodeX.Text = serialController.AngleCode[DeviceAddress.Xaxis].ToString();
                l_recevedCodeY.Text = serialController.AngleCode[DeviceAddress.Yaxis].ToString();
                l_recevedCodeZ.Text = serialController.AngleCode[DeviceAddress.Zaxis].ToString();
                chartController.ShowCharts(chartX, serialController.AngleCode[DeviceAddress.Xaxis],
                                           chartY, serialController.AngleCode[DeviceAddress.Yaxis],
                                           chartZ, serialController.AngleCode[DeviceAddress.Zaxis]);
                chartController.ShowTime(l_timeYstart, l_timeYEnd);
            }));
            fileManager.WriteDataFile(cb_writeFile.Checked, serialController.AngleCode[DeviceAddress.Yaxis]);
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
            newAng = angleConverter.AngleToCode(angle, dirY);
            cb_axisSelect.SelectedIndex = 1;
            l_stepsY.Text =  angleConverter.CodeToSteps(newAng, int.Parse(cb_microSteps.Text), 0, (int)num_koefReduct.Value).ToString();

        }
        private void Ctrl_Click(object sender, EventArgs e)
        {
            Angle angle = new Angle(nud_gradY.Value, nud_minY.Value, nud_secY.Value);
            l_newCodeY.Text = angleConverter.AngleToCode(angle, dirY).ToString();
            newAng = angleConverter.AngleToCode(angle, dirY);
            cb_axisSelect.SelectedIndex = 1;
            l_stepsY.Text =  angleConverter.CodeToSteps(newAng, int.Parse(cb_microSteps.Text), 0, (int)num_koefReduct.Value).ToString();

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
        {
            Angle angle = new Angle(nud_gradZ.Value, nud_minZ.Value, nud_secZ.Value);
            l_newCodeZ.Text = angleConverter.AngleToCode(angle, dirZ).ToString();
            newAng = angleConverter.AngleToCode(angle, dirZ);
            cb_axisSelect.SelectedIndex = 2;
            l_stepsZ.Text = angleConverter.CodeToSteps(newAng, int.Parse(cb_microSteps.Text), 0, (int)num_koefReduct.Value).ToString();
        }
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
            newAng = angleConverter.AngleToCode(angle, dirZ);
            cb_axisSelect.SelectedIndex = 2;
            l_stepsZ.Text =  angleConverter.CodeToSteps(newAng, int.Parse(cb_microSteps.Text), 0, (int)num_koefReduct.Value).ToString();
        }
        #endregion

        private void btn_openCofigFile_Click(object sender, EventArgs e)
        {
            fileManager.OpenCurrentCofigFile();
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {   
                    var filePath = openFileDialog1.FileName;
                    fileManager.SetConfigFilePath(filePath);
                    fileManager.OpenCurrentCofigFile();
                    tb_fileName.Text = fileManager.GetFilePath();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        /// <summary>
        /// Устанавливет numControl'ы из файла настроек.
        /// </summary>
        /// <param name="index">ось Y/ось Z</param>
        private void setNumsFromConfigFile(int index)
        {
            Dictionary<string, double> currConfig = fileManager.ShowCurrentConfig();
            switch (index)
            {
                case 0:
                    num_spd.Value = (decimal)currConfig["spdX"];
                    num_dec.Value = (decimal)currConfig["decX"];
                    num_koefReduct.Value = (decimal)currConfig["koefRedductionX"];
                    num_acc.Value = (decimal)currConfig["accX"];
                    num_zeroCode.Value = (decimal)currConfig["ZeroCodeX"];
                    break;
                case 1:
                    num_spd.Value = (decimal)currConfig["spdY"];
                    num_dec.Value = (decimal)currConfig["decY"];
                    num_koefReduct.Value = (decimal)currConfig["koefRedductionY"];
                    num_acc.Value = (decimal)currConfig["accY"];
                    num_zeroCode.Value = (decimal)currConfig["ZeroCodeY"];
                    break;
                case 2:
                    num_spd.Value = (decimal)currConfig["spdZ"];
                    num_dec.Value = (decimal)currConfig["decZ"];
                    num_koefReduct.Value = (decimal)currConfig["koefRedductionZ"];
                    num_acc.Value = (decimal)currConfig["accZ"];
                    num_zeroCode.Value = (decimal)currConfig["ZeroCodeZ"];
                    break;
        }// Ось Y
            

            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileManager.BinSerialize();
        }

        private void cb_axisSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            setNumsFromConfigFile(cb_axisSelect.SelectedIndex);
        }

        private void btn_startY_Click(object sender, EventArgs e)
        {
            timerControl.StartTimer();
            byte opCode;

            switch (cb_axisSelect.SelectedIndex)
            {
                case 0:
                    opCode = 0;
                    break;
                case 1:
                    opCode = 1;
                    break;
            }

            /*
            
            serialController.SendCommand(
                0x00,
                (ushort)newAng,
                (ushort)num_acc.Value,
                (ushort)num_dec.Value,
                (ushort)num_spd.Value,
                (byte)num_koefReduct.Value,
                0,
                Byte.Parse(cb_microSteps.Text));
            */
            //ssp.SendGet(new byte[] { 0x03, 0x00, 0x18, 0x00});
           
            //serialController.SendSlipCommand(new byte[] {100,2,0,0}, serialController._serialPort);
        }


    }
}
