using System;
using System.Windows.Forms;
using System.Timers;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer gTimer = new System.Timers.Timer();
        public Form1()
        {
            InitializeComponent();
            //path.Text = "http://127.0.0.1:8080/test.html";
            path.Text = @"C:\Users\IEUser\Desktop\test.html";
            gTimer.Interval = 1000;
            gTimer.Elapsed += new ElapsedEventHandler(Run_Tester);
        }

        private void Run_Tester(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
               txt_b.Text = "";
            });
            wb.Refresh();
            wb.Navigate(path.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gTimer.Enabled == true)
            {
                gTimer.Enabled = false;
            }
            else
            {
                gTimer.Enabled = true;
            }
        }

    }
}