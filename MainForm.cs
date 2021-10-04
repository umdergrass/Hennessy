using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace FreeandPremium
{
    public partial class MainForm : Form
    {
        string hwid = WindowsIdentity.GetCurrent().User.Value;
        WebClient wc = new WebClient();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string pastebinhwid = wc.DownloadString("https://pastebin.com/raw/5XVM2Rmm"); // Edit and change to your pastebin
            HttpWebRequest.DefaultWebProxy = new WebProxy(); // disable default proxy to hide from http debuggers
            if (pastebinhwid.Contains(hwid))  // checks login again before loading form
            {

            }
            else
            {
                Process.GetCurrentProcess().Kill(); // terminate process if login fail
            }
        }

        private void ggb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/");   
        }

        private void fbb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");            
        }

        private void wab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.whatsapp.com/");            
        }

        private void twb_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/");
        }

        private void ytb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/");
        }

        private void igb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/");
        }
    }
}
