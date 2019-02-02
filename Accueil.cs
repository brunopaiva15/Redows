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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redows
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        string VERSION = "Redows 2.4";
        string VERSION_MINILABEL = "v2.4";
        bool VERIFICATION_ACTIFOUPAS = true;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan();

            this.Hide();

            scan.ShowDialog();
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Accueil_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Redows n'a pas réussi à contacter le serveur central.", "Erreur de réseau", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor.Current = Cursors.Default;
                    VERIFICATION_ACTIFOUPAS = false;
                }
            }

            lblVersion.Text = VERSION_MINILABEL;

            VERSION version = new VERSION();

            this.Text = version.VersionActuelle();

            lblTitre.Text = version.VersionActuelle();
        }

        private void btnInfos_Click(object sender, EventArgs e)
        {
            InfosAuteur infosAuteur = new InfosAuteur();

            infosAuteur.ShowDialog();
        }

        public void CheckUpdates()
        {
            try
            {
                Cursor.Current = Cursors.AppStarting;
                WebClient MAJ = new WebClient();
                string DERNIERE_VERSION = MAJ.DownloadString("https://brunopaiva.ch/Version.txt");

                WebClient MAJ3 = new WebClient();
                string CHANGELOG = MAJ3.DownloadString("https://brunopaiva.ch/Changelog.txt");

                if (VERSION == DERNIERE_VERSION)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Le logiciel Redows est à jour. Aucune action n'est requise.", "Vérification de mise à jour");
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Ce logiciel n'est pas à jour.\n\nLa dernière version est la version : " + DERNIERE_VERSION + "\nUne page dans le navigateur par défaut va s'ouvrir afin que vous puissiez la télécharger.\n\nModifications : \n\n" + CHANGELOG, "Vérification de mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WebClient MAJ2 = new WebClient();
                    string DownloadLink = MAJ2.DownloadString("https://brunopaiva.ch/Download.txt");

                    Process.Start(DownloadLink);
                }

                //string cn_string = Properties.Settings.Default.dbClientsConnectionString;

                //SqlConnection cn_connection = new SqlConnection(cn_string);

                //cn_connection.Close();

                //System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("sqlservr");
                //foreach (System.Diagnostics.Process p in process)
                //{
                //    if (!string.IsNullOrEmpty(p.ProcessName))
                //    {
                //        p.Kill();
                //    }
                //}

                //string fileToCopy = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\dbClients.mdf";
                //string destinationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                //File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));
            }
            catch
            {
                MessageBox.Show("Oh non... Redows n'a malheureusement pas réussi à se connecter au serveur. Veuillez vérifier votre connexion et réessayez.", "Erreur de réseau", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            CheckUpdates();
        }

        private void btnAvance_Click(object sender, EventArgs e)
        {
            Avance avance = new Avance();

            this.Hide();

            avance.ShowDialog();
        }
    }
}
