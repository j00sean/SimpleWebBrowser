using System;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            path.Text = "http://127.0.0.1:8080/test.html";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wb.Navigate(new Uri(path.Text));
        }

    }
}