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
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
        }

        int iLol = 1;

        private void btnInfos_Click(object sender, EventArgs e)
        {
            InfosAuteur infosAuteur = new InfosAuteur();

            infosAuteur.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment redémarrer votre PC ?", "Redémarrer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = "/k shutdown -r & exit";
                proc.StartInfo.ErrorDialog = true;
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }
        }

        private void End_Load(object sender, EventArgs e)
        {
            VERSION version = new VERSION();

            this.Text = version.VersionActuelle();

            lblTitre.Text = version.VersionActuelle();
        }

        private void End_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnRestartLater_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
