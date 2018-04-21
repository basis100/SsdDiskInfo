using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace diskinfo
{



    


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        public bool StartProcess(string filename, string[] args)
        {
            try
            {
                string s = "";
                foreach (string arg in args)
                {
                    s = s + arg + " ";
                }
                s = s.Trim();
                Process myprocess = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo(filename, s);
                myprocess.StartInfo = startInfo;
             



                myprocess.StartInfo.UseShellExecute = false;
                myprocess.StartInfo.RedirectStandardInput = true;
                myprocess.StartInfo.RedirectStandardOutput = true;
                myprocess.StartInfo.RedirectStandardError = true;
                myprocess.StartInfo.CreateNoWindow = true;
                myprocess.OutputDataReceived += da_OutputDataReceived;

                myprocess.Start();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动应用程序时出错！原因：" + ex.Message);
            }
            return false;
        }

        void da_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.BeginInvoke(new Action(() => { textBox1.Text += "\r\n" + e.Data; }));


        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Process da = new Process();
            da.StartInfo.FileName = "cmd.exe";
            da.StartInfo.UseShellExecute = false;
            da.StartInfo.RedirectStandardInput = true;
            da.StartInfo.RedirectStandardOutput = true;
            da.StartInfo.RedirectStandardError = true;
            da.StartInfo.CreateNoWindow = true;
            da.OutputDataReceived += da_OutputDataReceived;
            da.Start();
            da.BeginOutputReadLine();
            da.StandardInput.WriteLine("smartctl.exe -x c:");
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Process da = new Process();
            da.StartInfo.FileName = "cmd.exe";
            da.StartInfo.UseShellExecute = false;
            da.StartInfo.RedirectStandardInput = true;
            da.StartInfo.RedirectStandardOutput = true;
            da.StartInfo.RedirectStandardError = true;
            da.StartInfo.CreateNoWindow = true;
            da.OutputDataReceived += da_OutputDataReceived;
            da.Start();
            da.BeginOutputReadLine();
            da.StandardInput.WriteLine("smartctl.exe -x d:");
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Process da = new Process();
            da.StartInfo.FileName = "cmd.exe";
            da.StartInfo.UseShellExecute = false;
            da.StartInfo.RedirectStandardInput = true;
            da.StartInfo.RedirectStandardOutput = true;
            da.StartInfo.RedirectStandardError = true;
            da.StartInfo.CreateNoWindow = true;
            da.OutputDataReceived += da_OutputDataReceived;
            da.Start();
            da.BeginOutputReadLine();
            da.StandardInput.WriteLine("smartctl.exe -x e:");
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Process da = new Process();
            da.StartInfo.FileName = "cmd.exe";
            da.StartInfo.UseShellExecute = false;
            da.StartInfo.RedirectStandardInput = true;
            da.StartInfo.RedirectStandardOutput = true;
            da.StartInfo.RedirectStandardError = true;
            da.StartInfo.CreateNoWindow = true;
            da.OutputDataReceived += da_OutputDataReceived;
            da.Start();
            da.BeginOutputReadLine();
            da.StandardInput.WriteLine("smartctl.exe -x f:");
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Process da = new Process();
            da.StartInfo.FileName = "cmd.exe";
            da.StartInfo.UseShellExecute = false;
            da.StartInfo.RedirectStandardInput = true;
            da.StartInfo.RedirectStandardOutput = true;
            da.StartInfo.RedirectStandardError = true;
            da.StartInfo.CreateNoWindow = true;
            da.OutputDataReceived += da_OutputDataReceived;
            da.Start();
            da.BeginOutputReadLine();
            da.StandardInput.WriteLine("smartctl.exe -x g:");
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.csdn.net/ot512csdn/article/details/80031712");

        }
    }
}
