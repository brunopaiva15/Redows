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

                    Process proc1 = new Process();
                    proc1.StartInfo.FileName = "cmd";
                    proc1.StartInfo.Verb = "runas";
                    proc1.StartInfo.Arguments = "/k reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v \"AllowCortana\" /t REG_DWORD /d 0 & exit";
                    proc1.StartInfo.ErrorDialog = true;
                    proc1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    proc1.Start();
                    proc1.WaitForExit();

                    Process proc2 = new Process();
                    proc2.StartInfo.FileName = "cmd";
                    proc2.StartInfo.Verb = "runas";
                    proc2.StartInfo.Arguments = "/k PowerShell -Command \"Get - AppxPackage * Cortana * | Remove - AppxPackage\" & exit";
                    proc2.StartInfo.ErrorDialog = true;
                    proc2.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    proc2.Start();
                    proc2.WaitForExit();

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
                if (MessageBox.Show("Are you sure you want to disable Prefetch on this PC ?\n\n(Note: Prefetch is a Windows component that generates files that help to start software faster. The problem is that it often writes to the disk. If you have an HDD, no problem. Do not disable Prefetch. But if you have an SSD, knowing that these are limited in writing, it would be better to disable it.)", "Disable Prefetch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                if (MessageBox.Show("Are you sure you want to disable Superfetch on this PC ?\n\n(Note: Superfetch is a Windows service that loads files and data into RAM, helping to start software faster. The problem is that it often writes to the disk. If you have an HDD, no problem. Do not disable Superfetch. But if you have an SSD, knowing that these are limited in writing, it would be better to disable it.)", "Disable Superfetch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void BtnDeleteOneDrive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete OneDrive on this PC ?", "Delete OneDrive", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                Process proc1 = new Process();
                proc1.StartInfo.FileName = "cmd";
                proc1.StartInfo.Verb = "runas";
                proc1.StartInfo.Arguments = "/k start /wait \"\" \"%SYSTEMROOT%\\SYSWOW64\\ONEDRIVESETUP.EXE\" /UNINSTALL & exit";
                proc1.StartInfo.ErrorDialog = true;
                proc1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc1.Start();
                proc1.WaitForExit();

                Process proc2 = new Process();
                proc2.StartInfo.FileName = "cmd";
                proc2.StartInfo.Verb = "runas";
                proc2.StartInfo.Arguments = "/k rd C:\\OneDriveTemp /Q /S >NUL 2>&1 & exit";
                proc2.StartInfo.ErrorDialog = true;
                proc2.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc2.Start();
                proc2.WaitForExit();

                Process proc3 = new Process();
                proc3.StartInfo.FileName = "cmd";
                proc3.StartInfo.Verb = "runas";
                proc3.StartInfo.Arguments = "/k rd \"%USERPROFILE%\\OneDrive\" /Q /S >NUL 2>&1 & exit";
                proc3.StartInfo.ErrorDialog = true;
                proc3.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc3.Start();
                proc3.WaitForExit();

                Process proc4 = new Process();
                proc4.StartInfo.FileName = "cmd";
                proc4.StartInfo.Verb = "runas";
                proc4.StartInfo.Arguments = "/k rd \"%LOCALAPPDATA%\\Microsoft\\OneDrive\" /Q /S >NUL 2>&1 & exit";
                proc4.StartInfo.ErrorDialog = true;
                proc4.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc4.Start();
                proc4.WaitForExit();

                Process proc5 = new Process();
                proc5.StartInfo.FileName = "cmd";
                proc5.StartInfo.Verb = "runas";
                proc5.StartInfo.Arguments = "/k rd \"%PROGRAMDATA%\\Microsoft OneDrive\" /Q /S >NUL 2>&1 & exit";
                proc5.StartInfo.ErrorDialog = true;
                proc5.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc5.Start();
                proc5.WaitForExit();

                Process proc6 = new Process();
                proc6.StartInfo.FileName = "cmd";
                proc6.StartInfo.Verb = "runas";
                proc6.StartInfo.Arguments = "/k reg add \"HKEY_CLASSES_ROOT\\CLSID\\{ 018D5C66 - 4533 - 4307 - 9B53 - 224DE2ED1FE6}\\ShellFolder\" /f /v Attributes /t REG_DWORD /d 0 >NUL 2>&1 & exit";
                proc6.StartInfo.ErrorDialog = true;
                proc6.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc6.Start();
                proc6.WaitForExit();

                Process proc7 = new Process();
                proc7.StartInfo.FileName = "cmd";
                proc7.StartInfo.Verb = "runas";
                proc7.StartInfo.Arguments = "/k reg add \"HKEY_CLASSES_ROOT\\Wow6432Node\\CLSID\\{ 018D5C66 - 4533 - 4307 - 9B53 - 224DE2ED1FE6}\\ShellFolder\" /f /v Attributes /t REG_DWORD /d 0 >NUL 2>&1 & exit";
                proc7.StartInfo.ErrorDialog = true;
                proc7.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc7.Start();
                proc7.WaitForExit();

                Cursor.Current = Cursors.Default;

                MessageBox.Show("To apply the changes, restart your computer.");
            }
        }
    }
}
