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
                if (MessageBox.Show("Etes-vous sûr(e) de vouloir désactiver Cortana sur ce PC ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                    MessageBox.Show("Cortana désactivée avec succès. Veuillez redémarrer votre ordinateur.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesNDU_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes-vous sûr(e) de vouloir désactiver NDU sur ce PC ?\n\n(Remarque : NDU est un composant Windows lié au réseau, qui consomme énormément de RAM. Sa désactivation n'affecte pas l'utilisation du système d'exploitation.)", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    // CODE

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Ndu");
                    key.SetValue("Start", 00000004);
                    key.Close();

                    MessageBox.Show("NDU désactivé avec succès. Veuillez redémarrer votre ordinateur.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactiverPrefetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes-vous sûr(e) de vouloir désactiver Prefetch sur ce PC ?\n\n(Remarque : Prefetch est un composant Windows générant des fichiers aidant à démarrer plus rapidement les logiciels. Le problème est que celui-ci écrit très souvent sur le disque. Si vous avez un HDD, aucun problème. Ne désactivez pas Prefetch. Mais si vous avez un SSD, sachant que ceux-ci sont limités en écriture, il vaudrait mieux le désactiver.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    // CODE

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory");
                    key.SetValue("EnablePrefetcher", 00000000);
                    key.Close();

                    MessageBox.Show("Prefetch désactivé avec succès. Veuillez redémarrer votre ordinateur.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactiverSuperfetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes-vous sûr(e) de vouloir désactiver Superfetch sur ce PC ?\n\n(Remarque : Superfetch est un service Windows chargeant des fichiers et des données dans la RAM aidant à démarrer plus rapidement les logiciels. Le problème est que celui-ci écrit très souvent sur le disque. Si vous avez un HDD, aucun problème. Ne désactivez pas Superfetch. Mais si vous avez un SSD, sachant que ceux-ci sont limités en écriture, il vaudrait mieux le désactiver.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                    MessageBox.Show("Superfetch désactivé avec succès. Veuillez redémarrer votre ordinateur.");

                    // CODE

                    Cursor.Current = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
