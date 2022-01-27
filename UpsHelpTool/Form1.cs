using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Diagnostics;

namespace UpsHelpTool {
    
    public partial class Form1 : Form {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public bool bDCDStatus = false;

        public Stopwatch stopwatch = new Stopwatch();   

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1() {
            InitializeComponent();
            try {
                notifyIcon1.Visible = false;
                serialPort1.RtsEnable = true;
                string[] ports = SerialPort.GetPortNames();
                foreach (string p in ports) {
                    comboBox_Comport.Items.Add(p);
                }

                label_Status.Text = "選擇 Com Port 後，按下 Start。";
                label_AlarmMsg.Text = "沒有異常";

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_Close_Click(object sender, EventArgs e) {
            this.Close();   
        }

        private void label1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_Start_Click(object sender, EventArgs e) {
            try {
                if (comboBox_Comport.Text == "") {
                    return;
                }
                else if (!serialPort1.IsOpen) {
                    serialPort1.PortName = comboBox_Comport.Text;
                    serialPort1.Open();     
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                    stopwatch.Restart();

                    button_Start.Enabled = false;
                    button_Cancel.Enabled = true;
                    comboBox_Comport.Enabled = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }      

        private void button_Cancel_Click(object sender, EventArgs e) {        
            timer1.Enabled = false;
            try {
                if (serialPort1.IsOpen) {                  
                    serialPort1.Close();
                }
                button_Start.Enabled = true;
                button_Cancel.Enabled = false;
                comboBox_Comport.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (!serialPort1.IsOpen) return;

            bDCDStatus = serialPort1.CDHolding;

            if (bDCDStatus == true) {
                label_Status.Text = "DCD (Pin1) Status = HIGH (市電正常)";
                label_AlarmMsg.Text = "市電正常";
                stopwatch.Restart();
                this.TopMost = false;
            }
            else {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;

                int iTimeToHibernate = 30 - (int)stopwatch.Elapsed.TotalSeconds;
                if (iTimeToHibernate <= 0) {
                    //MessageBox.Show("休眠");
                    timer1.Enabled = false;
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                    this.Close();   
                }

                label_Status.Text = "DCD (Pin1) Status = LOW (市電異常)";
                label_AlarmMsg.Text = "市電異常，系統將在 "+ iTimeToHibernate + " 秒後自動休眠。";
            }

        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                notifyIcon1.Visible = true;           
                this.Hide();
            }
            else {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void button_Min_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
