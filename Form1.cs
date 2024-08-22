using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private Process process;
        private decimal downTime;
        private string fileName = "";
        private string name = "";
        private StatusBar bar = new StatusBar();
        public Form1()
        {
            InitializeComponent();

            bar.Panels.Add(fileNameLable);
            bar.Panels.Add(downTimePanel);
            fileNameLable.Width = 300;
            downTimePanel.Text = "";
            
        }

        StatusBarPanel downTimePanel = new StatusBarPanel();
        StatusBarPanel fileNameLable = new StatusBarPanel();

        void LoadDownTime()
        {
            downTime = nmSecond.Value + nmMinute.Value * 60 + nmHour.Value * 60 * 60;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("Chọn chương trình để chạy!", "Thông báo");
                return;
            }

            if (nmSecond.Value == 0 && nmMinute.Value == 0 && nmHour.Value == 0)
            {
                MessageBox.Show("Chọn thời gian tắt chương trình!", "Thông báo");
                return;
            }

            LoadDownTime();
            try
            {
                process = Process.Start(fileName);
            }
            catch
            {
                MessageBox.Show("Không thể mở file!", "Thông báo");
                return;
            }
            
            timer1.Start();
        }

        void LoadStatusBar()
        {
            bar.ShowPanels = true;                     
            fileNameLable.Text = name;        
            this.Controls.Add(bar);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (nmSecond.Value >= 60)
            {
                nmSecond.Value = 0;
                nmMinute.Value++;
            } 
        }

        private void nmMinute_ValueChanged(object sender, EventArgs e)
        {
            if (nmMinute.Value >= 60)
            {
                nmMinute.Value = 0;
                nmHour.Value++;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn chương trình để hẹn giờ tắt!";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileName = open.FileName;
            }
            name = fileName;

            string[] arr = name.Split('\\');
            name = arr[arr.Length - 1];
            fileNameLable.Text = name;
            LoadStatusBar();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string url = @"https://www.youtube.com/@ToanNguyen-ew6nf";

            if (MessageBox.Show("Bạn có muốn di chuyển đến kênh Youtube của Admin?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            downTime--;
            downTimePanel.Text = downTime.ToString();
            if (downTime <= 0)
            {
                timer1.Stop();

                if (process == null)
                {
                    MessageBox.Show("Không thể tắt chương trình này!", "Thông báo");
                    return;
                }
                process.Kill();                            
                return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            downTimePanel.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            nmSecond.Value = 0;
            nmMinute.Value = 0;
            nmHour.Value = 0;
            fileNameLable.Text = "";
            downTimePanel.Text = "";
            name = "";
            fileName = "";
        }
    }
}
