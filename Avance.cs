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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redows
{
    public partial class Avance : Form
    {
        public Avance()
        {
            InitializeComponent();
        }

        private void btnDesCortana_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to disable Cortana on this PC ?", "Disable Cortana", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    // CODE

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Windows Search");
                    key.SetValue("AllowCortana", 00000000);
                    key.Close();

                    RegistryKey key1 = Registry.CurrentUser.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\TapiSrv");
                    key1.SetValue("Start", 00000004);
                    key1.Close();

                    RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\WbioSrvc");
                    key2.SetValue("Start", 00000004);
                    key2.Close();

                    MessageBox.Show("Cortana successfully disabled. Please restart your computer.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesNDU_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to disable NDU on this PC ?\n\n(Note: NDU is a Windows component linked to the network, which consumes a lot of RAM. Disabling it does not affect the use of the operating system.)", "Disable NDU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    // CODE

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Ndu");
                    key.SetValue("Start", 00000004);
                    key.Close();

                    MessageBox.Show("NDU successfully disabled. Please restart your computer.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactiverPrefetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to disable Prefetch on this PC ?\n\n(Note: Prefetch is a Windows component that generates files that help to start software faster. The problem is that it often writes to the disk. If you have an HDD, no problem. Do not disable Prefetch. But if you have an SSD, knowing that these are limited in writing, it would be better to disable it.)", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    // CODE

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory");
                    key.SetValue("EnablePrefetcher", 00000000);
                    key.Close();

                    MessageBox.Show("Prefetch successfully disabled. Please restart your computer.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactiverSuperfetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to disable Superfetch on this PC ?\n\n(Note: Superfetch is a Windows service that loads files and data into RAM, helping to start software faster. The problem is that it often writes to the disk. If you have an HDD, no problem. Do not disable Superfetch. But if you have an SSD, knowing that these are limited in writing, it would be better to disable it.)", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    // CODE

                    Process proc1 = new Process();
                    proc1.StartInfo.FileName = "cmd.exe";
                    proc1.StartInfo.Arguments = "/k sc config \"SysMain\" start= disabled & exit";
                    proc1.StartInfo.ErrorDialog = true;
                    proc1.StartInfo.Verb = "runas";
                    proc1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc1.Start();
                    proc1.WaitForExit();

                    Cursor.Current = Cursors.WaitCursor;

                    Process proc2 = new Process();
                    proc2.StartInfo.FileName = "cmd.exe";
                    proc2.StartInfo.Arguments = "/k sc stop \"SysMain\" & exit";
                    proc2.StartInfo.ErrorDialog = true;
                    proc2.StartInfo.Verb = "runas";
                    proc2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc2.Start();
                    proc2.WaitForExit();

                    MessageBox.Show("Superfetch successfully disabled. Please restart your computer.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetourAccueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();

            this.Hide();

            accueil.ShowDialog();
        }

        private void Avance_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult form1 = MessageBox.Show("Are you sure you want to leave the utility?", "Exit", MessageBoxButtons.YesNo);

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
                MessageBox.Show("Error when closing the program.\n\n(" + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisDefender_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to disable Windows Defender on this PC ?", "Disable Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    // CODE

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender");
                    key.SetValue("DisableAntiSpyware", 00000001);
                    key.Close();

                    MessageBox.Show("Windows Defender successfully disabled. Please restart your computer.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
