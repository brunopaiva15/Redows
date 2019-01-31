using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;

namespace Redows
{
    public partial class Scan : Form
    {
        public Scan()
        {
            InitializeComponent();
        }

        bool bCacherFenetre = true;
        bool VERIFICATION_ACTIFOUPAS = true;

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //try
                //{
                //}
                //catch
                //{
                //    MessageBox.Show("Oh. Vous n'avez pas de connexion à internet... Pas grave ! Continuons.", "Pas de réseau", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}

                try
                {
                    if (VERIFICATION_ACTIFOUPAS == true)
                    {
                        Cursor.Current = Cursors.AppStarting;
                        WebClient MAJ = new WebClient();
                        string ACTIF_OU_PAS = MAJ.DownloadString("https://brunopaiva.ch/Actif.txt");

                        if (ACTIF_OU_PAS != "1")
                        {
                            Cursor.Current = Cursors.Default;
                            MessageBox.Show("Redows n'est pas disponible pour le moment. Désolé.", "Danger", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            Quit quit = new Quit();

                            this.Hide();

                            quit.ShowDialog();
                        }
                    }
                }
                catch
                {
                    if (VERIFICATION_ACTIFOUPAS == true)
                    {
                        VERIFICATION_ACTIFOUPAS = true;
                    }
                    else
                    {
                        MessageBox.Show("Redows n'a pas réussi à contacter le serveur central. Nous vous recommendons très fortement de ne pas effectuer de réparation.", "Erreur de réseau", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor.Current = Cursors.Default;
                        VERIFICATION_ACTIFOUPAS = false;
                    }
                }

                lblTitre.Visible = false;
                lblEnReparation.Visible = true;

                lblEnReparation.ForeColor = Color.White;
                this.BackColor = Color.Red;

                btnModeExpert.Enabled = false;
                btnStart.Enabled = false;

                Cursor.Current = Cursors.AppStarting;

                btnStart.Text = "Réparation en cours (Étape 1/3)...";

                Process procSFC = new Process();
                procSFC.StartInfo.FileName = "cmd.exe";
                if (bCacherFenetre == true)
                {
                    procSFC.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /ScanHealth & exit";
                }
                else
                {
                    procSFC.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /ScanHealth";
                }
                procSFC.StartInfo.ErrorDialog = true;
                procSFC.StartInfo.Verb = "runas";
                if (bCacherFenetre == true)
                {
                    procSFC.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                }
                else
                {
                    procSFC.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                }
                procSFC.Start();
                btnStart.Text = "Réparation en cours (Étape 1/3)...";
                Cursor.Current = Cursors.WaitCursor;
                procSFC.WaitForExit();

                btnStart.Text = "Réparation en cours (Étape 1/3)...";

                Cursor.Current = Cursors.Default;
                Cursor.Current = Cursors.AppStarting;

                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                if (bCacherFenetre == true)
                {
                    proc.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /CheckHealth & exit";
                }
                else
                {
                    proc.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /CheckHealth";
                }
                proc.StartInfo.ErrorDialog = true;
                proc.StartInfo.Verb = "runas";
                if (bCacherFenetre == true)
                {
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                }
                else
                {
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                }
                proc.Start();
                btnStart.Text = "Réparation en cours (Étape 1/3)...";
                Cursor.Current = Cursors.WaitCursor;
                proc.WaitForExit();

                btnStart.Text = "Réparation en cours (Étape 2/3)...";

                Cursor.Current = Cursors.Default;
                Cursor.Current = Cursors.AppStarting;

                Process proc1 = new Process();
                proc1.StartInfo.FileName = "cmd.exe";
                if (bCacherFenetre == true)
                {
                    proc1.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /RestoreHealth & exit";
                }
                else
                {
                    proc1.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /RestoreHealth";
                }
                proc1.StartInfo.ErrorDialog = true;
                proc1.StartInfo.Verb = "runas";
                if (bCacherFenetre == true)
                {
                    proc1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                }
                else
                {
                    proc1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                }
                proc1.Start();
                btnStart.Text = "Réparation en cours (Étape 2/3)...";
                Cursor.Current = Cursors.WaitCursor;
                proc1.WaitForExit();

                btnStart.Text = "Réparation en cours (Étape 3/3)...";

                Cursor.Current = Cursors.Default;
                Cursor.Current = Cursors.AppStarting;

                Process proc2 = new Process();
                proc2.StartInfo.FileName = "cmd.exe";
                if (bCacherFenetre == true)
                {
                    proc2.StartInfo.Arguments = "/k chkdsk c: /scan /forceofflinefix & exit";
                }
                else
                {
                    proc2.StartInfo.Arguments = "/k chkdsk c: /scan /forceofflinefix";
                }
                proc2.StartInfo.ErrorDialog = true;
                proc2.StartInfo.Verb = "runas";
                if (bCacherFenetre == true)
                {
                    proc2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                }
                else
                {
                    proc2.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                }
                proc2.Start();
                btnStart.Text = "Réparation en cours (Étape 3/3)...";
                Cursor.Current = Cursors.WaitCursor;
                proc2.WaitForExit();

                btnStart.Text = "Réparation terminée";

                Cursor.Current = Cursors.Default;

                this.BackColor = Color.White;
                lblTitre.Visible = true;
                lblEnReparation.Visible = false;

                MessageBox.Show("Réparation terminée avec succès.", "Succès", MessageBoxButtons.OK);

                End end = new End();

                this.Hide();

                end.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.\n\nErreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Scan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult form1 = MessageBox.Show("Etes-vous sûr(e) de vouloir quitter l'application ?", "Quitter", MessageBoxButtons.YesNo);

                if (form1 == DialogResult.Yes)
                {
                    System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("cmd");
                    foreach (System.Diagnostics.Process p in process)
                    {
                        if (!string.IsNullOrEmpty(p.ProcessName))
                        {
                            p.Kill();
                        }
                    }

                    System.Diagnostics.Process[] process1 = System.Diagnostics.Process.GetProcessesByName("Dism");
                    foreach (System.Diagnostics.Process p in process1)
                    {
                        if (!string.IsNullOrEmpty(p.ProcessName))
                        {
                            p.Kill();
                        }
                    }

                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la fermeture du programme (0x000E_07).\n\n(" + ex.Message + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Scan_Load(object sender, EventArgs e)
        {
            bCacherFenetre = true;
            //cbxCacherCMD.Checked = true;

            VERSION version = new VERSION();

            this.Text = version.VersionActuelle();

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

        private void cbxCacherCMD_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbxCacherCMD.Checked == true)
            //{
            //    bCacherFenetre = true;
            //}
            //else
            //{
            //    bCacherFenetre = false;
            //}
        }

        private void btnModeExpert_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair();

            this.Hide();

            repair.ShowDialog();
        }

        private void btnRetourAccueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();

            this.Hide();

            accueil.ShowDialog();
        }
    }
}
