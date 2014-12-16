using System;
using System.Windows.Forms;
using Microsoft.Owin.Hosting;
using System.Net;
using System.Linq;
using System.Net.Sockets;

namespace ControlR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            iCanHazIP();
            Listen();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        // async void Listen()
        void Listen()
        {
            StartOptions options = new StartOptions();
            options.Urls.Add("http://*:1337");
            WebApp.Start<Startup>(options);
        }

        void iCanHazIP()
        {
          lblIP.Text =  Dns.GetHostAddresses(Dns.GetHostName()).First(a => a.AddressFamily == AddressFamily.InterNetwork).ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
