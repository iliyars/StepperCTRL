
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.cb_boudRate = new System.Windows.Forms.ComboBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_playLoad = new System.Windows.Forms.TextBox();
            this.tb_crc = new System.Windows.Forms.TextBox();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.cb_writeFile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(0, 0);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Подключиться";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // cb_ports
            // 
            this.cb_ports.FormattingEnabled = true;
            this.cb_ports.Location = new System.Drawing.Point(115, -1);
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
            this.cb_boudRate.Location = new System.Drawing.Point(115, 29);
            this.cb_boudRate.Name = "cb_boudRate";
            this.cb_boudRate.Size = new System.Drawing.Size(121, 24);
            this.cb_boudRate.TabIndex = 2;
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(416, 62);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(100, 22);
            this.tb_code.TabIndex = 3;
            // 
            // tb_playLoad
            // 
            this.tb_playLoad.Location = new System.Drawing.Point(416, 90);
            this.tb_playLoad.Name = "tb_playLoad";
            this.tb_playLoad.Size = new System.Drawing.Size(100, 22);
            this.tb_playLoad.TabIndex = 3;
            // 
            // tb_crc
            // 
            this.tb_crc.Location = new System.Drawing.Point(416, 118);
            this.tb_crc.Name = "tb_crc";
            this.tb_crc.Size = new System.Drawing.Size(100, 22);
            this.tb_crc.TabIndex = 3;
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(416, 146);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(100, 22);
            this.tb_test.TabIndex = 3;
            // 
            // cb_writeFile
            // 
            this.cb_writeFile.AutoSize = true;
            this.cb_writeFile.Location = new System.Drawing.Point(262, 32);
            this.cb_writeFile.Name = "cb_writeFile";
            this.cb_writeFile.Size = new System.Drawing.Size(142, 21);
            this.cb_writeFile.TabIndex = 4;
            this.cb_writeFile.Text = "Записать в файл";
            this.cb_writeFile.UseVisualStyleBackColor = true;
            this.cb_writeFile.CheckedChanged += new System.EventHandler(this.cb_writeFile_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_writeFile);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.tb_crc);
            this.Controls.Add(this.tb_playLoad);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.cb_boudRate);
            this.Controls.Add(this.cb_ports);
            this.Controls.Add(this.btn_connect);
            this.Name = "MainForm";
            this.Text = "Form1";
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
    }
}

