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

namespace Redows
{
    partial class Old
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Old));
            this.lblTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSFC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnalyser = new System.Windows.Forms.Button();
            this.btnVerifier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnaitre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbxPathNumIndex = new System.Windows.Forms.TextBox();
            this.btnOpenNumIndex = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReparer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReparerAvecWindowsUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxFermerCMD = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.winVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tbxLettreLecteur = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVerifierDisque = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInfos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(106, 29);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(198, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "WinRepair 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "© 2018 Bruno Paiva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "1. Vérifier l\'intégrité des fichiers système :";
            // 
            // btnSFC
            // 
            this.btnSFC.Location = new System.Drawing.Point(294, 19);
            this.btnSFC.Name = "btnSFC";
            this.btnSFC.Size = new System.Drawing.Size(263, 23);
            this.btnSFC.TabIndex = 3;
            this.btnSFC.Text = "Vérifier";
            this.btnSFC.UseVisualStyleBackColor = true;
            this.btnSFC.Click += new System.EventHandler(this.btnSFC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "2. Analyser l’image système de Windows 10 :";
            // 
            // btnAnalyser
            // 
            this.btnAnalyser.Location = new System.Drawing.Point(294, 54);
            this.btnAnalyser.Name = "btnAnalyser";
            this.btnAnalyser.Size = new System.Drawing.Size(263, 23);
            this.btnAnalyser.TabIndex = 5;
            this.btnAnalyser.Text = "Analyser";
            this.btnAnalyser.UseVisualStyleBackColor = true;
            this.btnAnalyser.Click += new System.EventHandler(this.btnAnalyser_Click);
            // 
            // btnVerifier
            // 
            this.btnVerifier.Location = new System.Drawing.Point(294, 89);
            this.btnVerifier.Name = "btnVerifier";
            this.btnVerifier.Size = new System.Drawing.Size(263, 23);
            this.btnVerifier.TabIndex = 7;
            this.btnVerifier.Text = "Vérifier";
            this.btnVerifier.UseVisualStyleBackColor = true;
            this.btnVerifier.Click += new System.EventHandler(this.btnVerifier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "3. Vérifier l\'image système de Windows 10 :";
            // 
            // btnConnaitre
            // 
            this.btnConnaitre.Location = new System.Drawing.Point(294, 124);
            this.btnConnaitre.Name = "btnConnaitre";
            this.btnConnaitre.Size = new System.Drawing.Size(263, 23);
            this.btnConnaitre.TabIndex = 9;
            this.btnConnaitre.Text = "Connaître";
            this.btnConnaitre.UseVisualStyleBackColor = true;
            this.btnConnaitre.Click += new System.EventHandler(this.btnConnaitre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "4. Connaître le numéro d\'index :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbxPathNumIndex
            // 
            this.tbxPathNumIndex.Location = new System.Drawing.Point(306, 126);
            this.tbxPathNumIndex.Name = "tbxPathNumIndex";
            this.tbxPathNumIndex.Size = new System.Drawing.Size(195, 20);
            this.tbxPathNumIndex.TabIndex = 10;
            // 
            // btnOpenNumIndex
            // 
            this.btnOpenNumIndex.Location = new System.Drawing.Point(507, 124);
            this.btnOpenNumIndex.Name = "btnOpenNumIndex";
            this.btnOpenNumIndex.Size = new System.Drawing.Size(62, 23);
            this.btnOpenNumIndex.TabIndex = 11;
            this.btnOpenNumIndex.Text = "...";
            this.btnOpenNumIndex.UseVisualStyleBackColor = true;
            this.btnOpenNumIndex.Click += new System.EventHandler(this.btnOpenNumIndex_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fichier WIM à utiliser :";
            // 
            // btnReparer
            // 
            this.btnReparer.Location = new System.Drawing.Point(284, 190);
            this.btnReparer.Name = "btnReparer";
            this.btnReparer.Size = new System.Drawing.Size(273, 23);
            this.btnReparer.TabIndex = 14;
            this.btnReparer.Text = "Réparer avec fichier WIM";
            this.btnReparer.UseVisualStyleBackColor = true;
            this.btnReparer.Click += new System.EventHandler(this.btnReparer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "5. Réparer l’image système de Windows 10 :";
            // 
            // btnReparerAvecWindowsUpdate
            // 
            this.btnReparerAvecWindowsUpdate.Location = new System.Drawing.Point(6, 190);
            this.btnReparerAvecWindowsUpdate.Name = "btnReparerAvecWindowsUpdate";
            this.btnReparerAvecWindowsUpdate.Size = new System.Drawing.Size(272, 23);
            this.btnReparerAvecWindowsUpdate.TabIndex = 15;
            this.btnReparerAvecWindowsUpdate.Text = "Réparer avec Windows Update";
            this.btnReparerAvecWindowsUpdate.UseVisualStyleBackColor = true;
            this.btnReparerAvecWindowsUpdate.Click += new System.EventHandler(this.btnReparerAvecWindowsUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "N° d\'index :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Outrepasser les étapes            :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(224, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxFermerCMD);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(328, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 81);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // cbxFermerCMD
            // 
            this.cbxFermerCMD.AutoSize = true;
            this.cbxFermerCMD.Location = new System.Drawing.Point(224, 50);
            this.cbxFermerCMD.Name = "cbxFermerCMD";
            this.cbxFermerCMD.Size = new System.Drawing.Size(15, 14);
            this.cbxFermerCMD.TabIndex = 21;
            this.cbxFermerCMD.UseVisualStyleBackColor = true;
            this.cbxFermerCMD.CheckedChanged += new System.EventHandler(this.cbxFermerCMD_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fermer CMD après commande :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxIndex);
            this.groupBox2.Controls.Add(this.btnSFC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAnalyser);
            this.groupBox2.Controls.Add(this.btnReparer);
            this.groupBox2.Controls.Add(this.btnReparerAvecWindowsUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnVerifier);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnConnaitre);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 259);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Système";
            // 
            // tbxIndex
            // 
            this.tbxIndex.Location = new System.Drawing.Point(518, 222);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(39, 20);
            this.tbxIndex.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 55);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ouvrir";
            // 
            // winVersion
            // 
            this.winVersion.AutoSize = true;
            this.winVersion.ForeColor = System.Drawing.Color.ForestGreen;
            this.winVersion.Location = new System.Drawing.Point(126, 531);
            this.winVersion.Name = "winVersion";
            this.winVersion.Size = new System.Drawing.Size(153, 13);
            this.winVersion.TabIndex = 23;
            this.winVersion.Text = "Windows 10 Professionel 1809";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Système d\'exploitation :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRestart);
            this.groupBox4.Controls.Add(this.tbxLettreLecteur);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnVerifierDisque);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 83);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disque dur";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(284, 49);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(122, 23);
            this.btnRestart.TabIndex = 27;
            this.btnRestart.Text = "Redémarrer";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tbxLettreLecteur
            // 
            this.tbxLettreLecteur.FormattingEnabled = true;
            this.tbxLettreLecteur.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.tbxLettreLecteur.Location = new System.Drawing.Point(518, 51);
            this.tbxLettreLecteur.Name = "tbxLettreLecteur";
            this.tbxLettreLecteur.Size = new System.Drawing.Size(39, 21);
            this.tbxLettreLecteur.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(412, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Lettre lecteur :";
            // 
            // btnVerifierDisque
            // 
            this.btnVerifierDisque.Location = new System.Drawing.Point(284, 20);
            this.btnVerifierDisque.Name = "btnVerifierDisque";
            this.btnVerifierDisque.Size = new System.Drawing.Size(273, 23);
            this.btnVerifierDisque.TabIndex = 18;
            this.btnVerifierDisque.Text = "Vérifier";
            this.btnVerifierDisque.UseVisualStyleBackColor = true;
            this.btnVerifierDisque.Click += new System.EventHandler(this.btnVerifierDisque_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Vérifier l\'état d\'un volume :";
            // 
            // btnInfos
            // 
            this.btnInfos.Location = new System.Drawing.Point(555, 526);
            this.btnInfos.Name = "btnInfos";
            this.btnInfos.Size = new System.Drawing.Size(25, 23);
            this.btnInfos.TabIndex = 27;
            this.btnInfos.Text = "?";
            this.btnInfos.UseVisualStyleBackColor = true;
            this.btnInfos.Click += new System.EventHandler(this.btnInfos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Redows.Properties.Resources.winrep;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 557);
            this.Controls.Add(this.btnInfos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenNumIndex);
            this.Controls.Add(this.tbxPathNumIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinRepair 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnalyser;
        private System.Windows.Forms.Button btnVerifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnaitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxPathNumIndex;
        private System.Windows.Forms.Button btnOpenNumIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReparer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReparerAvecWindowsUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbxFermerCMD;
        private System.Windows.Forms.Label winVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVerifierDisque;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInfos;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ComboBox tbxLettreLecteur;
        private System.Windows.Forms.TextBox tbxIndex;
    }
}

