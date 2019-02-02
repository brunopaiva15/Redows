/*
 *  Copyright (C) 2019 Bruno Paiva
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with this program; if not, write to the Free Software Foundation, Inc.,
 * 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 * 
 */

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
                            MessageBox.Show("Redows is not available at the moment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        MessageBox.Show("Redows was unable to contact the central server. We strongly recommend that you do not carry out any repairs.", "Network error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                btnStart.Text = "Repair in progress (Step 1/3)...";

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

                btnStart.Text = "Repair in progress (Step 1/3)...";

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

                btnStart.Text = "Repair in progress (Step 2/3)....";

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

                btnStart.Text = "Repair in progress (Step 3/3)...";

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
                Cursor.Current = Cursors.WaitCursor;
                proc2.WaitForExit();

                btnStart.Text = "Repair completed";

                Cursor.Current = Cursors.Default;

                this.BackColor = Color.White;
                lblTitre.Visible = true;
                lblEnReparation.Visible = false;

                MessageBox.Show("Repair successfully completed.", "Success", MessageBoxButtons.OK);

                End end = new End();

                this.Hide();

                end.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh. An unknown error occurred.\n\nError : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Scan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult form1 = MessageBox.Show("Are you sure you want to leave the utility ?", "Exit", MessageBoxButtons.YesNo);

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
                MessageBox.Show("Error when closing the utility.\n\n(" + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
