using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redows
{
    public partial class Repair : Form
    {
        public Repair()
        {
            InitializeComponent();
        }

        bool bCacherFenetre = true;
        bool VERIFICATION_ACTIFOUPAS = true;

        private void btnReparerWIM_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(tbxPathNumIndex.Text))
                {
                    if (tbxPathNumIndex.Text != "")
                    {
                        if (tbxIndex.Text != "" && Convert.ToDouble(tbxIndex.Text) >= 0 && Convert.ToDouble(tbxIndex.Text) <= 20)
                        {
                            //try
                            //{
                            //    //MAIL
                            //    Cursor.Current = Cursors.AppStarting;
                            //    string mailBodyhtml = "Une personne vient de commencer une réparation. OS de la personne : " + winVersion.Text + ".";
                            //    var msg = new MailMessage("ppaiva11144@gmail.com", "ppaiva11144@gmail.com", "Réparation commencée", mailBodyhtml);
                            //    msg.IsBodyHtml = true;
                            //    var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                            //    smtpClient.UseDefaultCredentials = true;
                            //    smtpClient.Credentials = new NetworkCredential("ppaiva11144@gmail.com", "nhcadwupxrcthgbb");
                            //    smtpClient.EnableSsl = true;
                            //    smtpClient.Send(msg);
                            //    Console.WriteLine("Email Sended Successfully");
                            //    Cursor.Current = Cursors.Default;
                            //    //MAIL
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

                            Cursor.Current = Cursors.WaitCursor;

                            btnModeBasique.Enabled = false;
                            btnReparerWIM.Enabled = false;
                            btnConnaitre.Enabled = false;
                            btnOpenNumIndex.Enabled = false;

                            Process proc = new Process();
                            proc.StartInfo.FileName = "cmd.exe";
                            if (bCacherFenetre == true)
                            {
                                proc.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /RestoreHealth /Source:wim:" + tbxPathNumIndex.Text + ":" + tbxIndex.Text + " /limitaccess & exit";
                            }
                            else
                            {
                                proc.StartInfo.Arguments = "/k Dism /Online /Cleanup-Image /RestoreHealth /Source:wim:" + tbxPathNumIndex.Text + ":" + tbxIndex.Text + " /limitaccess";
                            }
                            proc.StartInfo.ErrorDialog = true;
                            proc.StartInfo.Verb = "runas";
                            btnReparerWIM.Text = "Réparation en cours...";
                            if (bCacherFenetre == true)
                            {
                                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            }
                            else
                            {
                                proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            }
                            proc.Start();
                            Cursor.Current = Cursors.WaitCursor;
                            proc.WaitForExit();

                            //try
                            //{
                            //    // MAIL
                            //    Cursor.Current = Cursors.AppStarting;
                            //    string mailBodyhtml1 = "Une personne vient de finir une réparation. OS de la personne : " + winVersion.Text + ".";
                            //    var msg1 = new MailMessage("ppaiva11144@gmail.com", "ppaiva11144@gmail.com", "Réparation terminée", mailBodyhtml1);
                            //    msg1.IsBodyHtml = true;
                            //    var smtpClient1 = new SmtpClient("smtp.gmail.com", 587);
                            //    smtpClient1.UseDefaultCredentials = true;
                            //    smtpClient1.Credentials = new NetworkCredential("ppaiva11144@gmail.com", "nhcadwupxrcthgbb");
                            //    smtpClient1.EnableSsl = true;
                            //    smtpClient1.Send(msg1);
                            //    Console.WriteLine("Email Sended Successfully");
                            //    Cursor.Current = Cursors.Default;
                            //    // MAIL
                            //}
                            //catch
                            //{
                            //    MessageBox.Show("Oh. Vous n'avez pas de connexion à internet... Pas grave ! Continuons.", "Pas de réseau", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //}

                            Cursor.Current = Cursors.Default;

                            lblTitre.Visible = true;
                            lblEnReparation.Visible = false;

                            btnReparerWIM.Text = "Réparation terminée.";
                            End end = new End();

                            this.Hide();

                            end.ShowDialog();

                            // Lancer message final
                        }
                        else
                        {
                            MessageBox.Show("Veuillez entrer un numéro d'index valide avant d'effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            btnReparerWIM.Enabled = true;
                            btnConnaitre.Enabled = true;
                            btnOpenNumIndex.Enabled = true;
                            btnModeBasique.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez ouvrir un fichier WIM avant d'effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mais vous jouez à quoi ? Comment voulez-vous que la réparation fonctionne alors que le fichier n'existe pas ?\n\n(Je croyais que vous étiez un expert, moi.)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnReparerWIM.Enabled = true;
                btnConnaitre.Enabled = true;
                btnOpenNumIndex.Enabled = true;
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

                btnReparerWIM.Enabled = true;
                btnConnaitre.Enabled = true;
                btnOpenNumIndex.Enabled = true;
            }
        }

        private void btnConnaitre_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxPathNumIndex.Text != "")
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = "cmd.exe";
                    proc.StartInfo.Arguments = "/k DISM /Get-WimInfo /WimFile:" + tbxPathNumIndex.Text;
                    proc.StartInfo.Verb = "runas";
                    proc.Start();
                }
                else
                {
                    MessageBox.Show("Veuillez ouvrir un fichier WIM avant d'effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnReparerWIM.Enabled = true;
                btnConnaitre.Enabled = true;
                btnOpenNumIndex.Enabled = true;
            }
        }

        private void btnReparerWinUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //try
                //{
                //    // MAIL
                //    Cursor.Current = Cursors.AppStarting;
                //    string mailBodyhtml = "Une personne vient de commencer une réparation. OS de la personne : " + winVersion.Text + ".";
                //    var msg = new MailMessage("ppaiva11144@gmail.com", "ppaiva11144@gmail.com", "Réparation commencée", mailBodyhtml);
                //    msg.IsBodyHtml = true;
                //    var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                //    smtpClient.UseDefaultCredentials = true;
                //    smtpClient.Credentials = new NetworkCredential("ppaiva11144@gmail.com", "nhcadwupxrcthgbb");
                //    smtpClient.EnableSsl = true;
                //    smtpClient.Send(msg);
                //    Console.WriteLine("Email Sended Successfully");
                //    Cursor.Current = Cursors.Default;
                //    // MAIL
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

                btnModeBasique.Enabled = false;
                btnReparerWIM.Enabled = false;
                btnConnaitre.Enabled = false;
                btnOpenNumIndex.Enabled = false;

                Cursor.Current = Cursors.AppStarting;

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
                Cursor.Current = Cursors.WaitCursor;
                procSFC.WaitForExit();

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
                Cursor.Current = Cursors.WaitCursor;
                proc.WaitForExit();

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
                Cursor.Current = Cursors.WaitCursor;
                proc1.WaitForExit();

                //try
                //{
                //    // MAIL
                //    Cursor.Current = Cursors.AppStarting;
                //    string mailBodyhtml1 = "Une personne vient de finir une réparation. OS de la personne : " + winVersion.Text + ".";
                //    var msg1 = new MailMessage("ppaiva11144@gmail.com", "ppaiva11144@gmail.com", "Réparation terminée", mailBodyhtml1);
                //    msg1.IsBodyHtml = true;
                //    var smtpClient1 = new SmtpClient("smtp.gmail.com", 587);
                //    smtpClient1.UseDefaultCredentials = true;
                //    smtpClient1.Credentials = new NetworkCredential("ppaiva11144@gmail.com", "nhcadwupxrcthgbb");
                //    smtpClient1.EnableSsl = true;
                //    smtpClient1.Send(msg1);
                //    Console.WriteLine("Email Sended Successfully");
                //    Cursor.Current = Cursors.Default;
                //    // MAIL
                //}
                //catch
                //{
                //    MessageBox.Show("Oh. Vous n'avez pas de connexion à internet... Pas grave ! Continuons.", "Pas de réseau", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}

                btnModeBasique.Enabled = true;
                btnReparerWIM.Enabled = true;
                btnConnaitre.Enabled = true;
                btnOpenNumIndex.Enabled = true;


                End end = new End();

                this.Hide();

                end.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Oh. Une erreur inconnue s'est produite.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnReparerWIM.Enabled = true;
                btnConnaitre.Enabled = true;
                btnOpenNumIndex.Enabled = true;
                btnModeBasique.Enabled = true;
            }
        }

        private void Repair_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Repair_Load(object sender, EventArgs e)
        {
            VERSION version = new VERSION();

            this.Text = version.VersionActuelle();

            bCacherFenetre = true;
            cbxCacherCMD.Checked = true;

            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Ouvrir fichier WIM";
            openFileDialog1.Filter = "Fichiers WIM|*.wim";

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
            if (cbxCacherCMD.Checked == true)
            {
                bCacherFenetre = true;
            }
            else
            {
                bCacherFenetre = false;
            }
        }

        private void btnModeBasique_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan();

            this.Hide();

            scan.ShowDialog();
        }
    }
}
