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
    partial class Scan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan));
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModeExpert = new System.Windows.Forms.Button();
            this.lblEnReparation = new System.Windows.Forms.Label();
            this.winVersion = new System.Windows.Forms.Label();
            this.btnRetourAccueil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(69, 118);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(212, 51);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Pour réparer votre ordinateur, \r\ncliquez sur \"Réparer\".\r\n(Oui, c\'est aussi simple" +
    " que ça !)\r\n";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(92, 207);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(177, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Réparer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Redows.Properties.Resources.winrep;
            this.pictureBox1.Location = new System.Drawing.Point(134, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnModeExpert
            // 
            this.btnModeExpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeExpert.Location = new System.Drawing.Point(92, 258);
            this.btnModeExpert.Name = "btnModeExpert";
            this.btnModeExpert.Size = new System.Drawing.Size(177, 23);
            this.btnModeExpert.TabIndex = 3;
            this.btnModeExpert.Text = "Expert ->";
            this.btnModeExpert.UseVisualStyleBackColor = true;
            this.btnModeExpert.Click += new System.EventHandler(this.btnModeExpert_Click);
            // 
            // lblEnReparation
            // 
            this.lblEnReparation.AutoSize = true;
            this.lblEnReparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnReparation.Location = new System.Drawing.Point(25, 118);
            this.lblEnReparation.Name = "lblEnReparation";
            this.lblEnReparation.Size = new System.Drawing.Size(305, 68);
            this.lblEnReparation.TabIndex = 29;
            this.lblEnReparation.Text = "Redows effectue une réparation\r\ndes fichiers endommagés de votre système.\r\nVeuill" +
    "ez patienter et ne touchez à rien.\r\nLa réparation peut prendre jusqu\'à 15 minute" +
    "s.";
            this.lblEnReparation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnReparation.Visible = false;
            // 
            // winVersion
            // 
            this.winVersion.AutoSize = true;
            this.winVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winVersion.Location = new System.Drawing.Point(12, 12);
            this.winVersion.Name = "winVersion";
            this.winVersion.Size = new System.Drawing.Size(0, 13);
            this.winVersion.TabIndex = 36;
            this.winVersion.Visible = false;
            // 
            // btnRetourAccueil
            // 
            this.btnRetourAccueil.Location = new System.Drawing.Point(12, 300);
            this.btnRetourAccueil.Name = "btnRetourAccueil";
            this.btnRetourAccueil.Size = new System.Drawing.Size(84, 23);
            this.btnRetourAccueil.TabIndex = 39;
            this.btnRetourAccueil.Text = "<- Accueil";
            this.btnRetourAccueil.UseVisualStyleBackColor = true;
            this.btnRetourAccueil.Click += new System.EventHandler(this.btnRetourAccueil_Click);
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 335);
            this.Controls.Add(this.btnRetourAccueil);
            this.Controls.Add(this.winVersion);
            this.Controls.Add(this.lblEnReparation);
            this.Controls.Add(this.btnModeExpert);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Scan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scan_FormClosing);
            this.Load += new System.EventHandler(this.Scan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnModeExpert;
        private System.Windows.Forms.Label lblEnReparation;
        private System.Windows.Forms.Label winVersion;
        private System.Windows.Forms.Button btnRetourAccueil;
    }
}