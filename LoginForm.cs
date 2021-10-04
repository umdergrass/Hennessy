using Microsoft.Win32;
using System;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace FreeandPremium
{
    public partial class LoginForm : Form
    {
        string hwid = WindowsIdentity.GetCurrent().User.Value;
        WebClient wc = new WebClient();


        public LoginForm()
        {
            InitializeComponent();
            HttpWebRequest.DefaultWebProxy = new WebProxy(); // disable default proxy
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            hwidtextbox.Text = hwid;
            hwid = hwid;
        }

        private void PremiumLoginBtn_Click(object sender, EventArgs e)
        {
            string pastebinhwid = wc.DownloadString("https://pastebin.com/raw/5XVM2Rmm"); // Edit and change to your pastebin
            if (pastebinhwid.Contains(hwid))
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login!", "https://github.com/confusity");
            }
        }
    }
}
