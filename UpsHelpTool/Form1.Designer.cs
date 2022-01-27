namespace UpsHelpTool {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Comport = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Min = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label_AlarmMsg = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(365, 139);
            this.button_Start.Margin = new System.Windows.Forms.Padding(8);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(180, 66);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "UPS Help Tool";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // comboBox_Comport
            // 
            this.comboBox_Comport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Comport.FormattingEnabled = true;
            this.comboBox_Comport.Location = new System.Drawing.Point(32, 139);
            this.comboBox_Comport.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox_Comport.Name = "comboBox_Comport";
            this.comboBox_Comport.Size = new System.Drawing.Size(317, 58);
            this.comboBox_Comport.TabIndex = 2;
            this.comboBox_Comport.Text = "COM1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UpsHelpTool.Properties.Resources.icon_gray;
            this.pictureBox1.Location = new System.Drawing.Point(32, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(866, 26);
            this.button_Close.Margin = new System.Windows.Forms.Padding(8);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 5;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Min
            // 
            this.button_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Min.FlatAppearance.BorderSize = 0;
            this.button_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Min.Location = new System.Drawing.Point(811, 26);
            this.button_Min.Margin = new System.Windows.Forms.Padding(8);
            this.button_Min.Name = "button_Min";
            this.button_Min.Size = new System.Drawing.Size(30, 30);
            this.button_Min.TabIndex = 6;
            this.button_Min.UseVisualStyleBackColor = false;
            this.button_Min.Click += new System.EventHandler(this.button_Min_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(561, 139);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(8);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(180, 66);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "UPS Help Tool";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // label_AlarmMsg
            // 
            this.label_AlarmMsg.AutoSize = true;
            this.label_AlarmMsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_AlarmMsg.ForeColor = System.Drawing.Color.Red;
            this.label_AlarmMsg.Location = new System.Drawing.Point(21, 314);
            this.label_AlarmMsg.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_AlarmMsg.Name = "label_AlarmMsg";
            this.label_AlarmMsg.Size = new System.Drawing.Size(875, 61);
            this.label_AlarmMsg.TabIndex = 8;
            this.label_AlarmMsg.Text = "市電異常，系統將在 30 秒後自動休眠。";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Status.ForeColor = System.Drawing.Color.White;
            this.label_Status.Location = new System.Drawing.Point(21, 236);
            this.label_Status.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(837, 61);
            this.label_Status.TabIndex = 9;
            this.label_Status.Text = "DCD (Pin1) Status = HIGH (市電正常)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(914, 403);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_AlarmMsg);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Min);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_Comport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Comport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Min;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label_AlarmMsg;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Timer timer1;
    }
}

