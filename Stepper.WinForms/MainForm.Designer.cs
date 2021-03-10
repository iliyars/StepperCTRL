
using System;

namespace Stepper.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.cb_boudRate = new System.Windows.Forms.ComboBox();
            this.cb_writeFile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.gb_Yaxis = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_errSecY = new System.Windows.Forms.TextBox();
            this.tb_errMinY = new System.Windows.Forms.TextBox();
            this.tb_errGradY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.l_recevedCodeY = new System.Windows.Forms.Label();
            this.tb_currSecY = new System.Windows.Forms.TextBox();
            this.tb_currMinY = new System.Windows.Forms.TextBox();
            this.tb_currGradY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_newPositionY = new System.Windows.Forms.GroupBox();
            this.l_newCodeY = new System.Windows.Forms.Label();
            this.btn_MinAngY = new System.Windows.Forms.Button();
            this.btn_ZeroAngY = new System.Windows.Forms.Button();
            this.btn_MaxAngY = new System.Windows.Forms.Button();
            this.btn_dirY = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_stepsY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_secY = new System.Windows.Forms.NumericUpDown();
            this.nud_minY = new System.Windows.Forms.NumericUpDown();
            this.nud_gradY = new System.Windows.Forms.NumericUpDown();
            this.gb_Zaxis = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_errSecZ = new System.Windows.Forms.TextBox();
            this.tb_errMinZ = new System.Windows.Forms.TextBox();
            this.tb_errGradZ = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.l_recevedCodeZ = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_currSecZ = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_currMinZ = new System.Windows.Forms.TextBox();
            this.tb_currGradZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gb_newPosZ = new System.Windows.Forms.GroupBox();
            this.l_newCodeZ = new System.Windows.Forms.Label();
            this.btn_minAngZ = new System.Windows.Forms.Button();
            this.btn_zeroAngZ = new System.Windows.Forms.Button();
            this.btn_maxAngZ = new System.Windows.Forms.Button();
            this.btn_dirZ = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.l_stepsZ = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nud_secZ = new System.Windows.Forms.NumericUpDown();
            this.nud_minZ = new System.Windows.Forms.NumericUpDown();
            this.nud_gradZ = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_config = new System.Windows.Forms.GroupBox();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.cb_axisSelect = new System.Windows.Forms.ComboBox();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.cb_microSteps = new System.Windows.Forms.ComboBox();
            this.num_acc = new System.Windows.Forms.NumericUpDown();
            this.num_koefReduct = new System.Windows.Forms.NumericUpDown();
            this.num_zeroCode = new System.Windows.Forms.NumericUpDown();
            this.num_dec = new System.Windows.Forms.NumericUpDown();
            this.num_spd = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_openCofigFile = new System.Windows.Forms.Button();
            this.btn_startY = new System.Windows.Forms.Button();
            this.l_stopWatch = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.l_recevedCodeX = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label23 = new System.Windows.Forms.Label();
            this.l_timeYstart = new System.Windows.Forms.Label();
            this.l_timeYEnd = new System.Windows.Forms.Label();
            this.chartX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.gb_Yaxis.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_newPositionY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_secY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gradY)).BeginInit();
            this.gb_Zaxis.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gb_newPosZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_secZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gradZ)).BeginInit();
            this.gb_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_koefReduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_zeroCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_spd)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(7, 20);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(112, 28);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Подключиться";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // cb_ports
            // 
            this.cb_ports.FormattingEnabled = true;
            this.cb_ports.Location = new System.Drawing.Point(143, 22);
            this.cb_ports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ports.Name = "cb_ports";
            this.cb_ports.Size = new System.Drawing.Size(121, 24);
            this.cb_ports.TabIndex = 1;
            // 
            // cb_boudRate
            // 
            this.cb_boudRate.FormattingEnabled = true;
            this.cb_boudRate.Items.AddRange(new object[] {
            "9600",
            "1000000",
            "2000000",
            "115200"});
            this.cb_boudRate.Location = new System.Drawing.Point(143, 53);
            this.cb_boudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_boudRate.Name = "cb_boudRate";
            this.cb_boudRate.Size = new System.Drawing.Size(121, 24);
            this.cb_boudRate.TabIndex = 2;
            // 
            // cb_writeFile
            // 
            this.cb_writeFile.AutoSize = true;
            this.cb_writeFile.Location = new System.Drawing.Point(143, 84);
            this.cb_writeFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_writeFile.Name = "cb_writeFile";
            this.cb_writeFile.Size = new System.Drawing.Size(142, 21);
            this.cb_writeFile.TabIndex = 4;
            this.cb_writeFile.Text = "Записать в файл";
            this.cb_writeFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_disconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.cb_writeFile);
            this.groupBox1.Controls.Add(this.cb_ports);
            this.groupBox1.Controls.Add(this.cb_boudRate);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(304, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(7, 54);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(112, 28);
            this.btn_disconnect.TabIndex = 6;
            this.btn_disconnect.Text = "Отключиться";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            // 
            // gb_Yaxis
            // 
            this.gb_Yaxis.Controls.Add(this.groupBox4);
            this.gb_Yaxis.Controls.Add(this.groupBox3);
            this.gb_Yaxis.Controls.Add(this.gb_newPositionY);
            this.gb_Yaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Yaxis.Location = new System.Drawing.Point(749, 15);
            this.gb_Yaxis.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Yaxis.Name = "gb_Yaxis";
            this.gb_Yaxis.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Yaxis.Size = new System.Drawing.Size(396, 431);
            this.gb_Yaxis.TabIndex = 6;
            this.gb_Yaxis.TabStop = false;
            this.gb_Yaxis.Text = "Ось Y";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_errSecY);
            this.groupBox4.Controls.Add(this.tb_errMinY);
            this.groupBox4.Controls.Add(this.tb_errGradY);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(8, 332);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(372, 89);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ошибка позиционирования";
            // 
            // tb_errSecY
            // 
            this.tb_errSecY.Location = new System.Drawing.Point(235, 44);
            this.tb_errSecY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errSecY.Name = "tb_errSecY";
            this.tb_errSecY.Size = new System.Drawing.Size(100, 22);
            this.tb_errSecY.TabIndex = 3;
            // 
            // tb_errMinY
            // 
            this.tb_errMinY.Location = new System.Drawing.Point(125, 44);
            this.tb_errMinY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errMinY.Name = "tb_errMinY";
            this.tb_errMinY.Size = new System.Drawing.Size(100, 22);
            this.tb_errMinY.TabIndex = 3;
            // 
            // tb_errGradY
            // 
            this.tb_errGradY.Location = new System.Drawing.Point(21, 44);
            this.tb_errGradY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errGradY.Name = "tb_errGradY";
            this.tb_errGradY.Size = new System.Drawing.Size(100, 22);
            this.tb_errGradY.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Секунды";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Минуты";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Градусы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_recevedCodeY);
            this.groupBox3.Controls.Add(this.tb_currSecY);
            this.groupBox3.Controls.Add(this.tb_currMinY);
            this.groupBox3.Controls.Add(this.tb_currGradY);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(8, 176);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(372, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Текущее положение";
            // 
            // l_recevedCodeY
            // 
            this.l_recevedCodeY.AutoSize = true;
            this.l_recevedCodeY.Location = new System.Drawing.Point(93, 98);
            this.l_recevedCodeY.Name = "l_recevedCodeY";
            this.l_recevedCodeY.Size = new System.Drawing.Size(54, 17);
            this.l_recevedCodeY.TabIndex = 4;
            this.l_recevedCodeY.Text = "label23";
            // 
            // tb_currSecY
            // 
            this.tb_currSecY.Location = new System.Drawing.Point(235, 47);
            this.tb_currSecY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currSecY.Name = "tb_currSecY";
            this.tb_currSecY.Size = new System.Drawing.Size(100, 22);
            this.tb_currSecY.TabIndex = 3;
            // 
            // tb_currMinY
            // 
            this.tb_currMinY.Location = new System.Drawing.Point(127, 47);
            this.tb_currMinY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currMinY.Name = "tb_currMinY";
            this.tb_currMinY.Size = new System.Drawing.Size(100, 22);
            this.tb_currMinY.TabIndex = 3;
            // 
            // tb_currGradY
            // 
            this.tb_currGradY.Location = new System.Drawing.Point(21, 47);
            this.tb_currGradY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currGradY.Name = "tb_currGradY";
            this.tb_currGradY.Size = new System.Drawing.Size(100, 22);
            this.tb_currGradY.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Секунды";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Минуты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Код угла:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Градусы";
            // 
            // gb_newPositionY
            // 
            this.gb_newPositionY.Controls.Add(this.l_newCodeY);
            this.gb_newPositionY.Controls.Add(this.btn_MinAngY);
            this.gb_newPositionY.Controls.Add(this.btn_ZeroAngY);
            this.gb_newPositionY.Controls.Add(this.btn_MaxAngY);
            this.gb_newPositionY.Controls.Add(this.btn_dirY);
            this.gb_newPositionY.Controls.Add(this.label3);
            this.gb_newPositionY.Controls.Add(this.label2);
            this.gb_newPositionY.Controls.Add(this.l_stepsY);
            this.gb_newPositionY.Controls.Add(this.label5);
            this.gb_newPositionY.Controls.Add(this.label4);
            this.gb_newPositionY.Controls.Add(this.label1);
            this.gb_newPositionY.Controls.Add(this.nud_secY);
            this.gb_newPositionY.Controls.Add(this.nud_minY);
            this.gb_newPositionY.Controls.Add(this.nud_gradY);
            this.gb_newPositionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_newPositionY.Location = new System.Drawing.Point(8, 20);
            this.gb_newPositionY.Margin = new System.Windows.Forms.Padding(4);
            this.gb_newPositionY.Name = "gb_newPositionY";
            this.gb_newPositionY.Padding = new System.Windows.Forms.Padding(4);
            this.gb_newPositionY.Size = new System.Drawing.Size(372, 148);
            this.gb_newPositionY.TabIndex = 1;
            this.gb_newPositionY.TabStop = false;
            this.gb_newPositionY.Text = "Новое положение";
            // 
            // l_newCodeY
            // 
            this.l_newCodeY.AutoSize = true;
            this.l_newCodeY.Location = new System.Drawing.Point(445, 81);
            this.l_newCodeY.Name = "l_newCodeY";
            this.l_newCodeY.Size = new System.Drawing.Size(0, 17);
            this.l_newCodeY.TabIndex = 3;
            // 
            // btn_MinAngY
            // 
            this.btn_MinAngY.Location = new System.Drawing.Point(228, 75);
            this.btn_MinAngY.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MinAngY.Name = "btn_MinAngY";
            this.btn_MinAngY.Size = new System.Drawing.Size(100, 28);
            this.btn_MinAngY.TabIndex = 2;
            this.btn_MinAngY.Text = "-8,30";
            this.btn_MinAngY.UseVisualStyleBackColor = true;
            this.btn_MinAngY.Click += new System.EventHandler(this.btn_MinAngY_Click);
            // 
            // btn_ZeroAngY
            // 
            this.btn_ZeroAngY.Location = new System.Drawing.Point(116, 75);
            this.btn_ZeroAngY.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ZeroAngY.Name = "btn_ZeroAngY";
            this.btn_ZeroAngY.Size = new System.Drawing.Size(100, 28);
            this.btn_ZeroAngY.TabIndex = 2;
            this.btn_ZeroAngY.Text = "0";
            this.btn_ZeroAngY.UseVisualStyleBackColor = true;
            this.btn_ZeroAngY.Click += new System.EventHandler(this.btn_ZeroAngY_Click);
            // 
            // btn_MaxAngY
            // 
            this.btn_MaxAngY.Location = new System.Drawing.Point(8, 75);
            this.btn_MaxAngY.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MaxAngY.Name = "btn_MaxAngY";
            this.btn_MaxAngY.Size = new System.Drawing.Size(100, 28);
            this.btn_MaxAngY.TabIndex = 2;
            this.btn_MaxAngY.Text = "+8.30";
            this.btn_MaxAngY.UseVisualStyleBackColor = true;
            this.btn_MaxAngY.Click += new System.EventHandler(this.btn_MaxAngY_Click);
            // 
            // btn_dirY
            // 
            this.btn_dirY.Location = new System.Drawing.Point(8, 42);
            this.btn_dirY.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dirY.Name = "btn_dirY";
            this.btn_dirY.Size = new System.Drawing.Size(29, 28);
            this.btn_dirY.TabIndex = 2;
            this.btn_dirY.Text = "+";
            this.btn_dirY.UseVisualStyleBackColor = true;
            this.btn_dirY.Click += new System.EventHandler(this.btn_dir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Секунды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минуты";
            // 
            // l_stepsY
            // 
            this.l_stepsY.AutoSize = true;
            this.l_stepsY.Location = new System.Drawing.Point(69, 121);
            this.l_stepsY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_stepsY.Name = "l_stepsY";
            this.l_stepsY.Size = new System.Drawing.Size(96, 17);
            this.l_stepsY.TabIndex = 1;
            this.l_stepsY.Text = "Кол-во шагов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Шаги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Код угла:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Градусы";
            // 
            // nud_secY
            // 
            this.nud_secY.Location = new System.Drawing.Point(269, 43);
            this.nud_secY.Margin = new System.Windows.Forms.Padding(4);
            this.nud_secY.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_secY.Name = "nud_secY";
            this.nud_secY.Size = new System.Drawing.Size(87, 22);
            this.nud_secY.TabIndex = 0;
            // 
            // nud_minY
            // 
            this.nud_minY.Location = new System.Drawing.Point(152, 43);
            this.nud_minY.Margin = new System.Windows.Forms.Padding(4);
            this.nud_minY.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_minY.Name = "nud_minY";
            this.nud_minY.Size = new System.Drawing.Size(109, 22);
            this.nud_minY.TabIndex = 0;
            // 
            // nud_gradY
            // 
            this.nud_gradY.Location = new System.Drawing.Point(44, 43);
            this.nud_gradY.Margin = new System.Windows.Forms.Padding(4);
            this.nud_gradY.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_gradY.Name = "nud_gradY";
            this.nud_gradY.Size = new System.Drawing.Size(100, 22);
            this.nud_gradY.TabIndex = 0;
            // 
            // gb_Zaxis
            // 
            this.gb_Zaxis.Controls.Add(this.groupBox6);
            this.gb_Zaxis.Controls.Add(this.groupBox5);
            this.gb_Zaxis.Controls.Add(this.gb_newPosZ);
            this.gb_Zaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Zaxis.Location = new System.Drawing.Point(1153, 15);
            this.gb_Zaxis.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Zaxis.Name = "gb_Zaxis";
            this.gb_Zaxis.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Zaxis.Size = new System.Drawing.Size(396, 431);
            this.gb_Zaxis.TabIndex = 7;
            this.gb_Zaxis.TabStop = false;
            this.gb_Zaxis.Text = "Ось Z";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_errSecZ);
            this.groupBox6.Controls.Add(this.tb_errMinZ);
            this.groupBox6.Controls.Add(this.tb_errGradZ);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(8, 335);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(372, 89);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ошибка позиционирования";
            // 
            // tb_errSecZ
            // 
            this.tb_errSecZ.Location = new System.Drawing.Point(227, 44);
            this.tb_errSecZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errSecZ.Name = "tb_errSecZ";
            this.tb_errSecZ.Size = new System.Drawing.Size(100, 22);
            this.tb_errSecZ.TabIndex = 3;
            // 
            // tb_errMinZ
            // 
            this.tb_errMinZ.Location = new System.Drawing.Point(116, 44);
            this.tb_errMinZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errMinZ.Name = "tb_errMinZ";
            this.tb_errMinZ.Size = new System.Drawing.Size(100, 22);
            this.tb_errMinZ.TabIndex = 3;
            // 
            // tb_errGradZ
            // 
            this.tb_errGradZ.Location = new System.Drawing.Point(8, 44);
            this.tb_errGradZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errGradZ.Name = "tb_errGradZ";
            this.tb_errGradZ.Size = new System.Drawing.Size(100, 22);
            this.tb_errGradZ.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(224, 23);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "Секунды";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(113, 22);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "Минуты";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 23);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "Градусы";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.l_recevedCodeZ);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.tb_currSecZ);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.tb_currMinZ);
            this.groupBox5.Controls.Add(this.tb_currGradZ);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(8, 176);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(372, 148);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текущее положение";
            // 
            // l_recevedCodeZ
            // 
            this.l_recevedCodeZ.AutoSize = true;
            this.l_recevedCodeZ.Location = new System.Drawing.Point(93, 107);
            this.l_recevedCodeZ.Name = "l_recevedCodeZ";
            this.l_recevedCodeZ.Size = new System.Drawing.Size(54, 17);
            this.l_recevedCodeZ.TabIndex = 5;
            this.l_recevedCodeZ.Text = "label23";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(492, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 199);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 3;
            // 
            // tb_currSecZ
            // 
            this.tb_currSecZ.Location = new System.Drawing.Point(237, 47);
            this.tb_currSecZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currSecZ.Name = "tb_currSecZ";
            this.tb_currSecZ.Size = new System.Drawing.Size(100, 22);
            this.tb_currSecZ.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 199);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 3;
            // 
            // tb_currMinZ
            // 
            this.tb_currMinZ.Location = new System.Drawing.Point(129, 47);
            this.tb_currMinZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currMinZ.Name = "tb_currMinZ";
            this.tb_currMinZ.Size = new System.Drawing.Size(100, 22);
            this.tb_currMinZ.TabIndex = 3;
            // 
            // tb_currGradZ
            // 
            this.tb_currGradZ.Location = new System.Drawing.Point(21, 47);
            this.tb_currGradZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currGradZ.Name = "tb_currGradZ";
            this.tb_currGradZ.Size = new System.Drawing.Size(100, 22);
            this.tb_currGradZ.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Секунды";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Минуты";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 107);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Код угла:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Градусы";
            // 
            // gb_newPosZ
            // 
            this.gb_newPosZ.Controls.Add(this.l_newCodeZ);
            this.gb_newPosZ.Controls.Add(this.btn_minAngZ);
            this.gb_newPosZ.Controls.Add(this.btn_zeroAngZ);
            this.gb_newPosZ.Controls.Add(this.btn_maxAngZ);
            this.gb_newPosZ.Controls.Add(this.btn_dirZ);
            this.gb_newPosZ.Controls.Add(this.label14);
            this.gb_newPosZ.Controls.Add(this.label15);
            this.gb_newPosZ.Controls.Add(this.l_stepsZ);
            this.gb_newPosZ.Controls.Add(this.label18);
            this.gb_newPosZ.Controls.Add(this.label19);
            this.gb_newPosZ.Controls.Add(this.label20);
            this.gb_newPosZ.Controls.Add(this.nud_secZ);
            this.gb_newPosZ.Controls.Add(this.nud_minZ);
            this.gb_newPosZ.Controls.Add(this.nud_gradZ);
            this.gb_newPosZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_newPosZ.Location = new System.Drawing.Point(8, 23);
            this.gb_newPosZ.Margin = new System.Windows.Forms.Padding(4);
            this.gb_newPosZ.Name = "gb_newPosZ";
            this.gb_newPosZ.Padding = new System.Windows.Forms.Padding(4);
            this.gb_newPosZ.Size = new System.Drawing.Size(372, 148);
            this.gb_newPosZ.TabIndex = 2;
            this.gb_newPosZ.TabStop = false;
            this.gb_newPosZ.Text = "Новое положение";
            // 
            // l_newCodeZ
            // 
            this.l_newCodeZ.AutoSize = true;
            this.l_newCodeZ.Location = new System.Drawing.Point(445, 81);
            this.l_newCodeZ.Name = "l_newCodeZ";
            this.l_newCodeZ.Size = new System.Drawing.Size(0, 17);
            this.l_newCodeZ.TabIndex = 3;
            // 
            // btn_minAngZ
            // 
            this.btn_minAngZ.Location = new System.Drawing.Point(237, 75);
            this.btn_minAngZ.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minAngZ.Name = "btn_minAngZ";
            this.btn_minAngZ.Size = new System.Drawing.Size(100, 28);
            this.btn_minAngZ.TabIndex = 2;
            this.btn_minAngZ.Text = "-8,30";
            this.btn_minAngZ.UseVisualStyleBackColor = true;
            this.btn_minAngZ.Click += new System.EventHandler(this.btn_minAngZ_Click);
            // 
            // btn_zeroAngZ
            // 
            this.btn_zeroAngZ.Location = new System.Drawing.Point(129, 75);
            this.btn_zeroAngZ.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zeroAngZ.Name = "btn_zeroAngZ";
            this.btn_zeroAngZ.Size = new System.Drawing.Size(100, 28);
            this.btn_zeroAngZ.TabIndex = 2;
            this.btn_zeroAngZ.Text = "0";
            this.btn_zeroAngZ.UseVisualStyleBackColor = true;
            this.btn_zeroAngZ.Click += new System.EventHandler(this.btn_zeroAngZ_Click);
            // 
            // btn_maxAngZ
            // 
            this.btn_maxAngZ.Location = new System.Drawing.Point(21, 75);
            this.btn_maxAngZ.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maxAngZ.Name = "btn_maxAngZ";
            this.btn_maxAngZ.Size = new System.Drawing.Size(100, 28);
            this.btn_maxAngZ.TabIndex = 2;
            this.btn_maxAngZ.Text = "+8.30";
            this.btn_maxAngZ.UseVisualStyleBackColor = true;
            this.btn_maxAngZ.Click += new System.EventHandler(this.btn_maxAngZ_Click);
            // 
            // btn_dirZ
            // 
            this.btn_dirZ.Location = new System.Drawing.Point(8, 41);
            this.btn_dirZ.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dirZ.Name = "btn_dirZ";
            this.btn_dirZ.Size = new System.Drawing.Size(29, 28);
            this.btn_dirZ.TabIndex = 2;
            this.btn_dirZ.Text = "+";
            this.btn_dirZ.UseVisualStyleBackColor = true;
            this.btn_dirZ.Click += new System.EventHandler(this.btn_dirZ_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Секунды";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(139, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Минуты";
            // 
            // l_stepsZ
            // 
            this.l_stepsZ.AutoSize = true;
            this.l_stepsZ.Location = new System.Drawing.Point(80, 121);
            this.l_stepsZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_stepsZ.Name = "l_stepsZ";
            this.l_stepsZ.Size = new System.Drawing.Size(96, 17);
            this.l_stepsZ.TabIndex = 1;
            this.l_stepsZ.Text = "Кол-во шагов";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 121);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Шаги:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(229, 121);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Код угла:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(44, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Градусы";
            // 
            // nud_secZ
            // 
            this.nud_secZ.Location = new System.Drawing.Point(240, 43);
            this.nud_secZ.Margin = new System.Windows.Forms.Padding(4);
            this.nud_secZ.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_secZ.Name = "nud_secZ";
            this.nud_secZ.Size = new System.Drawing.Size(87, 22);
            this.nud_secZ.TabIndex = 0;
            // 
            // nud_minZ
            // 
            this.nud_minZ.Location = new System.Drawing.Point(141, 43);
            this.nud_minZ.Margin = new System.Windows.Forms.Padding(4);
            this.nud_minZ.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_minZ.Name = "nud_minZ";
            this.nud_minZ.Size = new System.Drawing.Size(87, 22);
            this.nud_minZ.TabIndex = 0;
            // 
            // nud_gradZ
            // 
            this.nud_gradZ.Location = new System.Drawing.Point(44, 43);
            this.nud_gradZ.Margin = new System.Windows.Forms.Padding(4);
            this.nud_gradZ.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_gradZ.Name = "nud_gradZ";
            this.nud_gradZ.Size = new System.Drawing.Size(87, 22);
            this.nud_gradZ.TabIndex = 0;
            // 
            // gb_config
            // 
            this.gb_config.Controls.Add(this.tb_fileName);
            this.gb_config.Controls.Add(this.cb_axisSelect);
            this.gb_config.Controls.Add(this.btn_chooseFile);
            this.gb_config.Controls.Add(this.cb_microSteps);
            this.gb_config.Controls.Add(this.num_acc);
            this.gb_config.Controls.Add(this.num_koefReduct);
            this.gb_config.Controls.Add(this.num_zeroCode);
            this.gb_config.Controls.Add(this.num_dec);
            this.gb_config.Controls.Add(this.num_spd);
            this.gb_config.Controls.Add(this.label27);
            this.gb_config.Controls.Add(this.label31);
            this.gb_config.Controls.Add(this.label30);
            this.gb_config.Controls.Add(this.label29);
            this.gb_config.Controls.Add(this.label28);
            this.gb_config.Controls.Add(this.label22);
            this.gb_config.Controls.Add(this.btn_openCofigFile);
            this.gb_config.Location = new System.Drawing.Point(12, 130);
            this.gb_config.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_config.Name = "gb_config";
            this.gb_config.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_config.Size = new System.Drawing.Size(308, 469);
            this.gb_config.TabIndex = 8;
            this.gb_config.TabStop = false;
            this.gb_config.Text = "Параметры ускорния";
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(47, 226);
            this.tb_fileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.ReadOnly = true;
            this.tb_fileName.Size = new System.Drawing.Size(169, 22);
            this.tb_fileName.TabIndex = 14;
            // 
            // cb_axisSelect
            // 
            this.cb_axisSelect.FormattingEnabled = true;
            this.cb_axisSelect.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cb_axisSelect.Location = new System.Drawing.Point(251, 20);
            this.cb_axisSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_axisSelect.Name = "cb_axisSelect";
            this.cb_axisSelect.Size = new System.Drawing.Size(52, 24);
            this.cb_axisSelect.TabIndex = 13;
            this.cb_axisSelect.SelectedIndexChanged += new System.EventHandler(this.cb_axisSelect_SelectedIndexChanged);
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(0, 292);
            this.btn_chooseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(216, 23);
            this.btn_chooseFile.TabIndex = 12;
            this.btn_chooseFile.Text = "Выбрать файл настроек";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // cb_microSteps
            // 
            this.cb_microSteps.FormattingEnabled = true;
            this.cb_microSteps.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.cb_microSteps.Location = new System.Drawing.Point(168, 170);
            this.cb_microSteps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_microSteps.Name = "cb_microSteps";
            this.cb_microSteps.Size = new System.Drawing.Size(65, 24);
            this.cb_microSteps.TabIndex = 7;
            // 
            // num_acc
            // 
            this.num_acc.Location = new System.Drawing.Point(168, 22);
            this.num_acc.Margin = new System.Windows.Forms.Padding(4);
            this.num_acc.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_acc.Name = "num_acc";
            this.num_acc.Size = new System.Drawing.Size(65, 22);
            this.num_acc.TabIndex = 6;
            // 
            // num_koefReduct
            // 
            this.num_koefReduct.Location = new System.Drawing.Point(168, 138);
            this.num_koefReduct.Margin = new System.Windows.Forms.Padding(4);
            this.num_koefReduct.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_koefReduct.Name = "num_koefReduct";
            this.num_koefReduct.Size = new System.Drawing.Size(65, 22);
            this.num_koefReduct.TabIndex = 6;
            // 
            // num_zeroCode
            // 
            this.num_zeroCode.Location = new System.Drawing.Point(168, 108);
            this.num_zeroCode.Margin = new System.Windows.Forms.Padding(4);
            this.num_zeroCode.Maximum = new decimal(new int[] {
            66000,
            0,
            0,
            0});
            this.num_zeroCode.Name = "num_zeroCode";
            this.num_zeroCode.Size = new System.Drawing.Size(65, 22);
            this.num_zeroCode.TabIndex = 6;
            // 
            // num_dec
            // 
            this.num_dec.Location = new System.Drawing.Point(168, 78);
            this.num_dec.Margin = new System.Windows.Forms.Padding(4);
            this.num_dec.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_dec.Name = "num_dec";
            this.num_dec.Size = new System.Drawing.Size(65, 22);
            this.num_dec.TabIndex = 6;
            // 
            // num_spd
            // 
            this.num_spd.Location = new System.Drawing.Point(168, 49);
            this.num_spd.Margin = new System.Windows.Forms.Padding(4);
            this.num_spd.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_spd.Name = "num_spd";
            this.num_spd.Size = new System.Drawing.Size(65, 22);
            this.num_spd.TabIndex = 6;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 27);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 17);
            this.label27.TabIndex = 5;
            this.label27.Text = "Ускорение шаг/c^2";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(8, 178);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 17);
            this.label31.TabIndex = 5;
            this.label31.Text = "Микрошаг";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 143);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(124, 17);
            this.label30.TabIndex = 5;
            this.label30.Text = "Коэфф. редукции";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 17);
            this.label29.TabIndex = 5;
            this.label29.Text = "Код нуля";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 86);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(145, 17);
            this.label28.TabIndex = 5;
            this.label28.Text = "Торможение шаг/c^2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 17);
            this.label22.TabIndex = 5;
            this.label22.Text = "Скорость шаг/c";
            // 
            // btn_openCofigFile
            // 
            this.btn_openCofigFile.Location = new System.Drawing.Point(0, 258);
            this.btn_openCofigFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_openCofigFile.Name = "btn_openCofigFile";
            this.btn_openCofigFile.Size = new System.Drawing.Size(216, 23);
            this.btn_openCofigFile.TabIndex = 4;
            this.btn_openCofigFile.Text = "Открыть файл настроек";
            this.btn_openCofigFile.UseVisualStyleBackColor = true;
            this.btn_openCofigFile.Click += new System.EventHandler(this.btn_openCofigFile_Click);
            // 
            // btn_startY
            // 
            this.btn_startY.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_startY.Location = new System.Drawing.Point(1580, 169);
            this.btn_startY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_startY.Name = "btn_startY";
            this.btn_startY.Size = new System.Drawing.Size(191, 68);
            this.btn_startY.TabIndex = 5;
            this.btn_startY.Text = "Старт";
            this.btn_startY.UseVisualStyleBackColor = true;
            this.btn_startY.Click += new System.EventHandler(this.btn_startY_Click);
            // 
            // l_stopWatch
            // 
            this.l_stopWatch.AutoSize = true;
            this.l_stopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stopWatch.Location = new System.Drawing.Point(1577, 274);
            this.l_stopWatch.Name = "l_stopWatch";
            this.l_stopWatch.Size = new System.Drawing.Size(87, 32);
            this.l_stopWatch.TabIndex = 7;
            this.l_stopWatch.Text = "00:00";
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(1563, 15);
            this.tb_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(193, 90);
            this.tb_text.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.groupBox13);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox10.Location = new System.Drawing.Point(345, 15);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(396, 431);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ось X";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox7);
            this.groupBox11.Controls.Add(this.textBox8);
            this.groupBox11.Controls.Add(this.textBox9);
            this.groupBox11.Controls.Add(this.label45);
            this.groupBox11.Controls.Add(this.label46);
            this.groupBox11.Controls.Add(this.label47);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox11.Location = new System.Drawing.Point(8, 332);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(372, 89);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Ошибка позиционирования";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(235, 44);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(125, 44);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(21, 44);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 3;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(243, 26);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 17);
            this.label45.TabIndex = 1;
            this.label45.Text = "Секунды";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(129, 26);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(59, 17);
            this.label46.TabIndex = 1;
            this.label46.Text = "Минуты";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(19, 23);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(64, 17);
            this.label47.TabIndex = 1;
            this.label47.Text = "Градусы";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.l_recevedCodeX);
            this.groupBox12.Controls.Add(this.textBox10);
            this.groupBox12.Controls.Add(this.textBox11);
            this.groupBox12.Controls.Add(this.textBox12);
            this.groupBox12.Controls.Add(this.label49);
            this.groupBox12.Controls.Add(this.label50);
            this.groupBox12.Controls.Add(this.label51);
            this.groupBox12.Controls.Add(this.label52);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox12.Location = new System.Drawing.Point(8, 176);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(372, 148);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Текущее положение";
            // 
            // l_recevedCodeX
            // 
            this.l_recevedCodeX.AutoSize = true;
            this.l_recevedCodeX.Location = new System.Drawing.Point(93, 98);
            this.l_recevedCodeX.Name = "l_recevedCodeX";
            this.l_recevedCodeX.Size = new System.Drawing.Size(54, 17);
            this.l_recevedCodeX.TabIndex = 4;
            this.l_recevedCodeX.Text = "label23";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(235, 47);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(127, 47);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(21, 47);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 3;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(232, 26);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(65, 17);
            this.label49.TabIndex = 1;
            this.label49.Text = "Секунды";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(125, 26);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 17);
            this.label50.TabIndex = 1;
            this.label50.Text = "Минуты";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(19, 98);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(69, 17);
            this.label51.TabIndex = 1;
            this.label51.Text = "Код угла:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(19, 23);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(64, 17);
            this.label52.TabIndex = 1;
            this.label52.Text = "Градусы";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label53);
            this.groupBox13.Controls.Add(this.button5);
            this.groupBox13.Controls.Add(this.button6);
            this.groupBox13.Controls.Add(this.button7);
            this.groupBox13.Controls.Add(this.button8);
            this.groupBox13.Controls.Add(this.label54);
            this.groupBox13.Controls.Add(this.label55);
            this.groupBox13.Controls.Add(this.label56);
            this.groupBox13.Controls.Add(this.label57);
            this.groupBox13.Controls.Add(this.label58);
            this.groupBox13.Controls.Add(this.label59);
            this.groupBox13.Controls.Add(this.numericUpDown4);
            this.groupBox13.Controls.Add(this.numericUpDown5);
            this.groupBox13.Controls.Add(this.numericUpDown6);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox13.Location = new System.Drawing.Point(8, 20);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(372, 148);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Новое положение";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(445, 81);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(0, 17);
            this.label53.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 75);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "-8,30";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_MinAngY_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(116, 75);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 2;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_ZeroAngY_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 75);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 2;
            this.button7.Text = "+8.30";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_MaxAngY_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 42);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 28);
            this.button8.TabIndex = 2;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_dir_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(283, 21);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 17);
            this.label54.TabIndex = 1;
            this.label54.Text = "Секунды";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(157, 23);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(59, 17);
            this.label55.TabIndex = 1;
            this.label55.Text = "Минуты";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(69, 121);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(96, 17);
            this.label56.TabIndex = 1;
            this.label56.Text = "Кол-во шагов";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(19, 118);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(44, 17);
            this.label57.TabIndex = 1;
            this.label57.Text = "Шаги:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(192, 121);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(69, 17);
            this.label58.TabIndex = 1;
            this.label58.Text = "Код угла:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(55, 23);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(64, 17);
            this.label59.TabIndex = 1;
            this.label59.Text = "Градусы";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(271, 43);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(87, 22);
            this.numericUpDown4.TabIndex = 0;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(153, 43);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(109, 22);
            this.numericUpDown5.TabIndex = 0;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(45, 43);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown6.TabIndex = 0;
            // 
            // chartY
            // 
            chartArea1.Name = "ChartArea1";
            this.chartY.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartY.Legends.Add(legend1);
            this.chartY.Location = new System.Drawing.Point(736, 446);
            this.chartY.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.chartY.Name = "chartY";
            this.chartY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValuesPerPoint = 2;
            this.chartY.Series.Add(series1);
            this.chartY.Size = new System.Drawing.Size(433, 299);
            this.chartY.TabIndex = 13;
            this.chartY.Text = "chart2";
            this.chartY.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 17);
            this.label23.TabIndex = 14;
            this.label23.Text = "label23";
            // 
            // l_timeYstart
            // 
            this.l_timeYstart.AutoSize = true;
            this.l_timeYstart.Location = new System.Drawing.Point(769, 718);
            this.l_timeYstart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_timeYstart.Name = "l_timeYstart";
            this.l_timeYstart.Size = new System.Drawing.Size(54, 17);
            this.l_timeYstart.TabIndex = 15;
            this.l_timeYstart.Text = "label32";
            // 
            // l_timeYEnd
            // 
            this.l_timeYEnd.AutoSize = true;
            this.l_timeYEnd.Location = new System.Drawing.Point(1099, 718);
            this.l_timeYEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_timeYEnd.Name = "l_timeYEnd";
            this.l_timeYEnd.Size = new System.Drawing.Size(70, 17);
            this.l_timeYEnd.TabIndex = 16;
            this.l_timeYEnd.Text = "l_timeEnd";
            // 
            // chartX
            // 
            chartArea2.Name = "ChartArea1";
            this.chartX.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartX.Legends.Add(legend2);
            this.chartX.Location = new System.Drawing.Point(325, 446);
            this.chartX.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.chartX.Name = "chartX";
            this.chartX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.YValuesPerPoint = 2;
            this.chartX.Series.Add(series2);
            this.chartX.Size = new System.Drawing.Size(433, 299);
            this.chartX.TabIndex = 17;
            this.chartX.Text = "chart2";
            this.chartX.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // chartZ
            // 
            chartArea3.Name = "ChartArea1";
            this.chartZ.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartZ.Legends.Add(legend3);
            this.chartZ.Location = new System.Drawing.Point(1161, 446);
            this.chartZ.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.chartZ.Name = "chartZ";
            this.chartZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series3.YValuesPerPoint = 2;
            this.chartZ.Series.Add(series3);
            this.chartZ.Size = new System.Drawing.Size(433, 299);
            this.chartZ.TabIndex = 18;
            this.chartZ.Text = "chart2";
            this.chartZ.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 779);
            this.Controls.Add(this.chartZ);
            this.Controls.Add(this.chartX);
            this.Controls.Add(this.l_timeYEnd);
            this.Controls.Add(this.l_timeYstart);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.chartY);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.l_stopWatch);
            this.Controls.Add(this.gb_config);
            this.Controls.Add(this.btn_startY);
            this.Controls.Add(this.gb_Zaxis);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.gb_Yaxis);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Yaxis.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_newPositionY.ResumeLayout(false);
            this.gb_newPositionY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_secY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gradY)).EndInit();
            this.gb_Zaxis.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gb_newPosZ.ResumeLayout(false);
            this.gb_newPosZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_secZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gradZ)).EndInit();
            this.gb_config.ResumeLayout(false);
            this.gb_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_koefReduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_zeroCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_spd)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       


        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cb_ports;
        private System.Windows.Forms.ComboBox cb_boudRate;
        private System.Windows.Forms.CheckBox cb_writeFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.GroupBox gb_Yaxis;
        private System.Windows.Forms.GroupBox gb_Zaxis;
        private System.Windows.Forms.GroupBox gb_newPositionY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_secY;
        private System.Windows.Forms.NumericUpDown nud_minY;
        private System.Windows.Forms.NumericUpDown nud_gradY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_currSecY;
        private System.Windows.Forms.TextBox tb_currMinY;
        private System.Windows.Forms.TextBox tb_currGradY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_MinAngY;
        private System.Windows.Forms.Button btn_ZeroAngY;
        private System.Windows.Forms.Button btn_MaxAngY;
        private System.Windows.Forms.Button btn_dirY;
        private System.Windows.Forms.Label l_stepsY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_errSecY;
        private System.Windows.Forms.TextBox tb_errMinY;
        private System.Windows.Forms.TextBox tb_errGradY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_config;
        private System.Windows.Forms.GroupBox gb_newPosZ;
        private System.Windows.Forms.Button btn_minAngZ;
        private System.Windows.Forms.Button btn_zeroAngZ;
        private System.Windows.Forms.Button btn_maxAngZ;
        private System.Windows.Forms.Button btn_dirZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label l_stepsZ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nud_secZ;
        private System.Windows.Forms.NumericUpDown nud_minZ;
        private System.Windows.Forms.NumericUpDown nud_gradZ;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_currSecZ;
        private System.Windows.Forms.TextBox tb_currMinZ;
        private System.Windows.Forms.TextBox tb_currGradZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label l_stopWatch;
        private System.Windows.Forms.Button btn_startY;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_errSecZ;
        private System.Windows.Forms.TextBox tb_errMinZ;
        private System.Windows.Forms.TextBox tb_errGradZ;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label l_newCodeY;
        private System.Windows.Forms.Label l_newCodeZ;
        private System.Windows.Forms.Button btn_openCofigFile;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.NumericUpDown num_acc;
        private System.Windows.Forms.NumericUpDown num_koefReduct;
        private System.Windows.Forms.NumericUpDown num_zeroCode;
        private System.Windows.Forms.NumericUpDown num_dec;
        private System.Windows.Forms.NumericUpDown num_spd;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.ComboBox cb_axisSelect;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label l_recevedCodeY;
        public System.Windows.Forms.ComboBox cb_microSteps;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label l_recevedCodeX;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label l_recevedCodeZ;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label l_timeYstart;
        private System.Windows.Forms.Label l_timeYEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZ;
    }
}

