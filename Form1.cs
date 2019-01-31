using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using Microsoft.VisualBasic;
using System.IO;
using System.Runtime.InteropServices;

namespace Redows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strCacheOuPas = "/k ";

        const string VERSION = "0.1";

        private void btnSFC_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Attention. Cette fonctionnalité est en test. Elle pourrait ne pas fonctionner comme prévu.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.WorkingDirectory = @"C:\WINDOWS\system32";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.Arguments = "/c sc config trustedinstaller start=auto";
                proc.StartInfo.Verb = "runas";
                proc.Start();

                Process proc1 = new Process();
                proc1.StartInfo.FileName = "cmd.exe";
                proc1.StartInfo.UseShellExecute = true;
                proc1.StartInfo.WorkingDirectory = @"C:\WINDOWS\system32";
                proc1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc1.StartInfo.Arguments = "/c net start trustedinstaller";
                proc1.StartInfo.Verb = "runas";
                proc1.Start();

                ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe", "sfc /scannow", false);
                btnAnalyser.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExecuteAsAdmin(string fileName, string command, bool cacher)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.WorkingDirectory = @"C:\WINDOWS\system32";
                proc.StartInfo.Arguments = strCacheOuPas + command;
                proc.StartInfo.Verb = "runas";

                if (cacher == true)
                {
                    proc.StartInfo.UseShellExecute = false;
                }

                proc.Start();
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnalyser_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe", "Dism /Online /Cleanup-Image /ScanHealth", false);
                btnVerifier.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                VERSION version = new VERSION();

                btnAnalyser.Enabled = false;
                btnVerifier.Enabled = false;
                btnConnaitre.Enabled = false;
                btnReparerAvecWindowsUpdate.Enabled = false;
                btnReparer.Enabled = false;
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Fichiers d'installation Windows|*.wim";
                this.Text = version.VersionActuelle();
                lblTitre.Text = version.VersionActuelle();

                #region VERSION_WINDOWS
                string r = "";
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection information = searcher.Get();
                    if (information != null)
                    {
                        foreach (ManagementObject obj in information)
                        {
                            r = obj["Caption"].ToString().ToString();
                        }
                    }
                    r = r.Replace("NT 5.1.2600", "XP");
                    r = r.Replace("NT 5.2.3790", "Server 2003");

                    string ProductName = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();

                    winVersion.Text = r + " " + ProductName;

                    #endregion
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe", "Dism /Online /Cleanup-Image /CheckHealth", false);
                btnConnaitre.Enabled = true;
                btnReparer.Enabled = true;
                btnReparerAvecWindowsUpdate.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnaitre_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxPathNumIndex.Text != "")
                {
                    ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe", "DISM /Get-WimInfo /WimFile:" + tbxPathNumIndex.Text, false);
                }
                else
                {
                    MessageBox.Show("Veuillez ouvrir un fichier WIM avant d'effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenNumIndex_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tbxPathNumIndex.Text = openFileDialog1.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReparer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxPathNumIndex.Text != "")
                {
                    if (tbxLettreLecteur.Text != "")
                    {
                        ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe", "Dism /Online /Cleanup-Image /RestoreHealth /Source:wim:" + tbxPathNumIndex.Text + ":" + tbxLettreLecteur.Text + " /limitaccess", false);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer un numéro d'index avant d'effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez ouvrir un fichier WIM avant d'effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReparerAvecWindowsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe", "Dism /Online /Cleanup-Image /RestoreHealth", false);
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    btnAnalyser.Enabled = true;
                    btnVerifier.Enabled = true;
                    btnConnaitre.Enabled = true;
                    btnReparerAvecWindowsUpdate.Enabled = true;
                    btnReparer.Enabled = true;
                }
                else
                {
                    btnAnalyser.Enabled = false;
                    btnVerifier.Enabled = false;
                    btnConnaitre.Enabled = false;
                    btnReparerAvecWindowsUpdate.Enabled = false;
                    btnReparer.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxFermerCMD_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxFermerCMD.Checked)
                {
                    strCacheOuPas = "/c ";
                }
                else
                {
                    strCacheOuPas = "/k ";
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int OStype()
        {
            int os = 0;
            IEnumerable<string> list64 = Directory.GetDirectories(Environment.GetEnvironmentVariable("SystemRoot")).Where(s => s.Equals(@"C:\Windows\SysWOW64"));
            IEnumerable<string> list32 = Directory.GetDirectories(Environment.GetEnvironmentVariable("SystemRoot")).Where(s => s.Equals(@"C:\Windows\System32"));
            if (list32.Count() > 0)
            {
                os = 32;
                if (list64.Count() > 0)
                    os = 64;
            }
            return os;
        }

        private void btnVerifierDisque_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxLettreLecteur.Text != "")
                {
                    ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe", "chkdsk /F /R /I " + tbxLettreLecteur.Text + ":", false);
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une lettre de lecteur avant d'effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfos_Click(object sender, EventArgs e)
        {
            InfosAuteur infosAuteur = new InfosAuteur();

            infosAuteur.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment redémarrer votre PC ?", "Redémarrer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                strCacheOuPas = "/c";
                ExecuteAsAdmin("cmd.exe", "shutdown -r", true);
            }
        }
    }
}
