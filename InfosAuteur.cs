using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Diagnostics;

namespace Redows
{
    public partial class InfosAuteur : Form
    {
        public InfosAuteur()
        {
            InitializeComponent();
        }

        private void InfosAuteur_Load(object sender, EventArgs e)
        {
            string r = "";
            string f = "";

            VERSION version = new VERSION();
            
            lblVersionWin.Text = version.VersionActuelle();

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                ManagementObjectCollection information = searcher.Get();
                if (information != null)
                {
                    foreach (ManagementObject obj in information)
                    {
                        r = obj["Caption"].ToString().ToString();
                        f = obj["OSArchitecture"].ToString();
                    }
                }
                r = r.Replace("NT 5.1.2600", "XP");
                r = r.Replace("NT 5.2.3790", "Server 2003");

                string ProductName = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();

                lblVersion.Text = "Version : " + r + "\n\nNuméro de version : " + ProductName + "\n\nArchitecture : " + f;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "https://brunopaiva.ch";
            process.Start();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
