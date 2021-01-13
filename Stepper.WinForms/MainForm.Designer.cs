
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.cb_boudRate = new System.Windows.Forms.ComboBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_playLoad = new System.Windows.Forms.TextBox();
            this.tb_crc = new System.Windows.Forms.TextBox();
            this.tb_test = new System.Windows.Forms.TextBox();
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
            this.tb_currSecZ = new System.Windows.Forms.TextBox();
            this.tb_currMinZ = new System.Windows.Forms.TextBox();
            this.tb_currGradZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gb_newPosZ = new System.Windows.Forms.GroupBox();
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
            this.btn_startY = new System.Windows.Forms.Button();
            this.l_timeY = new System.Windows.Forms.Label();
            this.chart_Y = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Z = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.l_newCodeZ = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Z)).BeginInit();
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
            "1000000"});
            this.cb_boudRate.Location = new System.Drawing.Point(143, 53);
            this.cb_boudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_boudRate.Name = "cb_boudRate";
            this.cb_boudRate.Size = new System.Drawing.Size(121, 24);
            this.cb_boudRate.TabIndex = 2;
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(34, 113);
            this.tb_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(100, 22);
            this.tb_code.TabIndex = 3;
            // 
            // tb_playLoad
            // 
            this.tb_playLoad.Location = new System.Drawing.Point(34, 141);
            this.tb_playLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_playLoad.Name = "tb_playLoad";
            this.tb_playLoad.Size = new System.Drawing.Size(100, 22);
            this.tb_playLoad.TabIndex = 3;
            // 
            // tb_crc
            // 
            this.tb_crc.Location = new System.Drawing.Point(34, 170);
            this.tb_crc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_crc.Name = "tb_crc";
            this.tb_crc.Size = new System.Drawing.Size(100, 22);
            this.tb_crc.TabIndex = 3;
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(34, 198);
            this.tb_test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(100, 22);
            this.tb_test.TabIndex = 3;
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
            this.gb_Yaxis.Location = new System.Drawing.Point(345, 15);
            this.gb_Yaxis.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Yaxis.Name = "gb_Yaxis";
            this.gb_Yaxis.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Yaxis.Size = new System.Drawing.Size(617, 431);
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
            this.groupBox4.Size = new System.Drawing.Size(563, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ошибка позиционирования";
            // 
            // tb_errSecY
            // 
            this.tb_errSecY.Location = new System.Drawing.Point(395, 43);
            this.tb_errSecY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errSecY.Name = "tb_errSecY";
            this.tb_errSecY.Size = new System.Drawing.Size(159, 22);
            this.tb_errSecY.TabIndex = 3;
            // 
            // tb_errMinY
            // 
            this.tb_errMinY.Location = new System.Drawing.Point(227, 43);
            this.tb_errMinY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errMinY.Name = "tb_errMinY";
            this.tb_errMinY.Size = new System.Drawing.Size(159, 22);
            this.tb_errMinY.TabIndex = 3;
            // 
            // tb_errGradY
            // 
            this.tb_errGradY.Location = new System.Drawing.Point(59, 43);
            this.tb_errGradY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errGradY.Name = "tb_errGradY";
            this.tb_errGradY.Size = new System.Drawing.Size(159, 22);
            this.tb_errGradY.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Секунды";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Минуты";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Градусы";
            // 
            // groupBox3
            // 
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
            this.groupBox3.Size = new System.Drawing.Size(563, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Текущее положение";
            // 
            // tb_currSecY
            // 
            this.tb_currSecY.Location = new System.Drawing.Point(395, 43);
            this.tb_currSecY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currSecY.Name = "tb_currSecY";
            this.tb_currSecY.Size = new System.Drawing.Size(159, 22);
            this.tb_currSecY.TabIndex = 3;
            // 
            // tb_currMinY
            // 
            this.tb_currMinY.Location = new System.Drawing.Point(227, 43);
            this.tb_currMinY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currMinY.Name = "tb_currMinY";
            this.tb_currMinY.Size = new System.Drawing.Size(159, 22);
            this.tb_currMinY.TabIndex = 3;
            // 
            // tb_currGradY
            // 
            this.tb_currGradY.Location = new System.Drawing.Point(59, 43);
            this.tb_currGradY.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currGradY.Name = "tb_currGradY";
            this.tb_currGradY.Size = new System.Drawing.Size(159, 22);
            this.tb_currGradY.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Секунды";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Минуты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Код угла:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 23);
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
            this.gb_newPositionY.Size = new System.Drawing.Size(563, 148);
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
            this.btn_MinAngY.Location = new System.Drawing.Point(237, 75);
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
            this.btn_ZeroAngY.Location = new System.Drawing.Point(129, 75);
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
            this.btn_MaxAngY.Location = new System.Drawing.Point(21, 75);
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
            this.btn_dirY.Location = new System.Drawing.Point(21, 39);
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
            this.label3.Location = new System.Drawing.Point(391, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Секунды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минуты";
            // 
            // l_stepsY
            // 
            this.l_stepsY.AutoSize = true;
            this.l_stepsY.Location = new System.Drawing.Point(445, 110);
            this.l_stepsY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_stepsY.Name = "l_stepsY";
            this.l_stepsY.Size = new System.Drawing.Size(96, 17);
            this.l_stepsY.TabIndex = 1;
            this.l_stepsY.Text = "Кол-во шагов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Шаги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Код угла:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Градусы";
            // 
            // nud_secY
            // 
            this.nud_secY.Location = new System.Drawing.Point(395, 43);
            this.nud_secY.Margin = new System.Windows.Forms.Padding(4);
            this.nud_secY.Name = "nud_secY";
            this.nud_secY.Size = new System.Drawing.Size(160, 22);
            this.nud_secY.TabIndex = 0;
            // 
            // nud_minY
            // 
            this.nud_minY.Location = new System.Drawing.Point(227, 43);
            this.nud_minY.Margin = new System.Windows.Forms.Padding(4);
            this.nud_minY.Name = "nud_minY";
            this.nud_minY.Size = new System.Drawing.Size(160, 22);
            this.nud_minY.TabIndex = 0;
            // 
            // nud_gradY
            // 
            this.nud_gradY.Location = new System.Drawing.Point(59, 43);
            this.nud_gradY.Margin = new System.Windows.Forms.Padding(4);
            this.nud_gradY.Name = "nud_gradY";
            this.nud_gradY.Size = new System.Drawing.Size(160, 22);
            this.nud_gradY.TabIndex = 0;
            // 
            // gb_Zaxis
            // 
            this.gb_Zaxis.Controls.Add(this.groupBox6);
            this.gb_Zaxis.Controls.Add(this.groupBox5);
            this.gb_Zaxis.Controls.Add(this.gb_newPosZ);
            this.gb_Zaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Zaxis.Location = new System.Drawing.Point(1211, 15);
            this.gb_Zaxis.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Zaxis.Name = "gb_Zaxis";
            this.gb_Zaxis.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Zaxis.Size = new System.Drawing.Size(622, 431);
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
            this.groupBox6.Size = new System.Drawing.Size(563, 88);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ошибка позиционирования";
            // 
            // tb_errSecZ
            // 
            this.tb_errSecZ.Location = new System.Drawing.Point(395, 43);
            this.tb_errSecZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errSecZ.Name = "tb_errSecZ";
            this.tb_errSecZ.Size = new System.Drawing.Size(159, 22);
            this.tb_errSecZ.TabIndex = 3;
            // 
            // tb_errMinZ
            // 
            this.tb_errMinZ.Location = new System.Drawing.Point(227, 43);
            this.tb_errMinZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errMinZ.Name = "tb_errMinZ";
            this.tb_errMinZ.Size = new System.Drawing.Size(159, 22);
            this.tb_errMinZ.TabIndex = 3;
            // 
            // tb_errGradZ
            // 
            this.tb_errGradZ.Location = new System.Drawing.Point(59, 43);
            this.tb_errGradZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_errGradZ.Name = "tb_errGradZ";
            this.tb_errGradZ.Size = new System.Drawing.Size(159, 22);
            this.tb_errGradZ.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(391, 23);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "Секунды";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(223, 23);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "Минуты";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(55, 23);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "Градусы";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_currSecZ);
            this.groupBox5.Controls.Add(this.tb_currMinZ);
            this.groupBox5.Controls.Add(this.tb_currGradZ);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(8, 179);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(563, 148);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текущее положение";
            // 
            // tb_currSecZ
            // 
            this.tb_currSecZ.Location = new System.Drawing.Point(395, 43);
            this.tb_currSecZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currSecZ.Name = "tb_currSecZ";
            this.tb_currSecZ.Size = new System.Drawing.Size(159, 22);
            this.tb_currSecZ.TabIndex = 3;
            // 
            // tb_currMinZ
            // 
            this.tb_currMinZ.Location = new System.Drawing.Point(227, 43);
            this.tb_currMinZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currMinZ.Name = "tb_currMinZ";
            this.tb_currMinZ.Size = new System.Drawing.Size(159, 22);
            this.tb_currMinZ.TabIndex = 3;
            // 
            // tb_currGradZ
            // 
            this.tb_currGradZ.Location = new System.Drawing.Point(59, 43);
            this.tb_currGradZ.Margin = new System.Windows.Forms.Padding(4);
            this.tb_currGradZ.Name = "tb_currGradZ";
            this.tb_currGradZ.Size = new System.Drawing.Size(159, 22);
            this.tb_currGradZ.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Секунды";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Минуты";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(359, 81);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Код угла:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 23);
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
            this.gb_newPosZ.Size = new System.Drawing.Size(563, 148);
            this.gb_newPosZ.TabIndex = 2;
            this.gb_newPosZ.TabStop = false;
            this.gb_newPosZ.Text = "Новое положение";
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
            this.btn_dirZ.Location = new System.Drawing.Point(21, 39);
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
            this.label14.Location = new System.Drawing.Point(391, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Секунды";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(223, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Минуты";
            // 
            // l_stepsZ
            // 
            this.l_stepsZ.AutoSize = true;
            this.l_stepsZ.Location = new System.Drawing.Point(445, 110);
            this.l_stepsZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_stepsZ.Name = "l_stepsZ";
            this.l_stepsZ.Size = new System.Drawing.Size(96, 17);
            this.l_stepsZ.TabIndex = 1;
            this.l_stepsZ.Text = "Кол-во шагов";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(359, 110);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Шаги:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(359, 81);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Код угла:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Градусы";
            // 
            // nud_secZ
            // 
            this.nud_secZ.Location = new System.Drawing.Point(395, 43);
            this.nud_secZ.Margin = new System.Windows.Forms.Padding(4);
            this.nud_secZ.Name = "nud_secZ";
            this.nud_secZ.Size = new System.Drawing.Size(160, 22);
            this.nud_secZ.TabIndex = 0;
            // 
            // nud_minZ
            // 
            this.nud_minZ.Location = new System.Drawing.Point(227, 45);
            this.nud_minZ.Margin = new System.Windows.Forms.Padding(4);
            this.nud_minZ.Name = "nud_minZ";
            this.nud_minZ.Size = new System.Drawing.Size(160, 22);
            this.nud_minZ.TabIndex = 0;
            // 
            // nud_gradZ
            // 
            this.nud_gradZ.Location = new System.Drawing.Point(59, 43);
            this.nud_gradZ.Margin = new System.Windows.Forms.Padding(4);
            this.nud_gradZ.Name = "nud_gradZ";
            this.nud_gradZ.Size = new System.Drawing.Size(160, 22);
            this.nud_gradZ.TabIndex = 0;
            // 
            // gb_config
            // 
            this.gb_config.Controls.Add(this.tb_code);
            this.gb_config.Controls.Add(this.tb_playLoad);
            this.gb_config.Controls.Add(this.tb_test);
            this.gb_config.Controls.Add(this.tb_crc);
            this.gb_config.Location = new System.Drawing.Point(12, 131);
            this.gb_config.Name = "gb_config";
            this.gb_config.Size = new System.Drawing.Size(308, 469);
            this.gb_config.TabIndex = 8;
            this.gb_config.TabStop = false;
            this.gb_config.Text = "Параметры ускорния";
            // 
            // btn_startY
            // 
            this.btn_startY.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_startY.Location = new System.Drawing.Point(993, 367);
            this.btn_startY.Name = "btn_startY";
            this.btn_startY.Size = new System.Drawing.Size(191, 68);
            this.btn_startY.TabIndex = 5;
            this.btn_startY.Text = "Старт";
            this.btn_startY.UseVisualStyleBackColor = true;
            // 
            // l_timeY
            // 
            this.l_timeY.AutoSize = true;
            this.l_timeY.Location = new System.Drawing.Point(1075, 301);
            this.l_timeY.Name = "l_timeY";
            this.l_timeY.Size = new System.Drawing.Size(54, 17);
            this.l_timeY.TabIndex = 7;
            this.l_timeY.Text = "l_timeY";
            // 
            // chart_Y
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_Y.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_Y.Legends.Add(legend7);
            this.chart_Y.Location = new System.Drawing.Point(345, 468);
            this.chart_Y.Name = "chart_Y";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart_Y.Series.Add(series7);
            this.chart_Y.Size = new System.Drawing.Size(730, 500);
            this.chart_Y.TabIndex = 9;
            this.chart_Y.Text = "chart1";
            // 
            // chart_Z
            // 
            chartArea8.Name = "ChartArea1";
            this.chart_Z.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart_Z.Legends.Add(legend8);
            this.chart_Z.Location = new System.Drawing.Point(1103, 468);
            this.chart_Z.Name = "chart_Z";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart_Z.Series.Add(series8);
            this.chart_Z.Size = new System.Drawing.Size(730, 500);
            this.chart_Z.TabIndex = 10;
            this.chart_Z.Text = "chart_Y";
            // 
            // l_newCodeZ
            // 
            this.l_newCodeZ.AutoSize = true;
            this.l_newCodeZ.Location = new System.Drawing.Point(445, 81);
            this.l_newCodeZ.Name = "l_newCodeZ";
            this.l_newCodeZ.Size = new System.Drawing.Size(0, 17);
            this.l_newCodeZ.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 715);
            this.Controls.Add(this.chart_Z);
            this.Controls.Add(this.chart_Y);
            this.Controls.Add(this.l_timeY);
            this.Controls.Add(this.gb_config);
            this.Controls.Add(this.btn_startY);
            this.Controls.Add(this.gb_Zaxis);
            this.Controls.Add(this.gb_Yaxis);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.chart_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cb_ports;
        private System.Windows.Forms.ComboBox cb_boudRate;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TextBox tb_playLoad;
        private System.Windows.Forms.TextBox tb_crc;
        private System.Windows.Forms.TextBox tb_test;
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
        private System.Windows.Forms.Label l_timeY;
        private System.Windows.Forms.Button btn_startY;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_errSecZ;
        private System.Windows.Forms.TextBox tb_errMinZ;
        private System.Windows.Forms.TextBox tb_errGradZ;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Z;
        private System.Windows.Forms.Label l_newCodeY;
        private System.Windows.Forms.Label l_newCodeZ;
    }
}

