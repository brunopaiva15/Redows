﻿namespace Redows
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.lblTitre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInfos = new System.Windows.Forms.Button();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.btnAvance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitreBase = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(31, 2);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "WinRepair 1.6.1";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitre.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bienvenue.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Redows est un outil très pratique.\r\nIl regroupe plusieurs commandes \r\nsimples, ma" +
    "is efficaces.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(102, 270);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Commencer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInfos
            // 
            this.btnInfos.Location = new System.Drawing.Point(232, 350);
            this.btnInfos.Name = "btnInfos";
            this.btnInfos.Size = new System.Drawing.Size(25, 23);
            this.btnInfos.TabIndex = 5;
            this.btnInfos.Text = "?";
            this.btnInfos.UseVisualStyleBackColor = true;
            this.btnInfos.Click += new System.EventHandler(this.btnInfos_Click);
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Location = new System.Drawing.Point(102, 350);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(124, 23);
            this.btnCheckUpdates.TabIndex = 4;
            this.btnCheckUpdates.Text = "Vérifier les mises à jour";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);
            // 
            // btnAvance
            // 
            this.btnAvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvance.Location = new System.Drawing.Point(102, 321);
            this.btnAvance.Name = "btnAvance";
            this.btnAvance.Size = new System.Drawing.Size(155, 23);
            this.btnAvance.TabIndex = 29;
            this.btnAvance.Text = "Outils avancés";
            this.btnAvance.UseVisualStyleBackColor = true;
            this.btnAvance.Click += new System.EventHandler(this.btnAvance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Redows.Properties.Resources.winrep;
            this.pictureBox1.Location = new System.Drawing.Point(135, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitreBase
            // 
            this.lblTitreBase.AutoSize = true;
            this.lblTitreBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreBase.Location = new System.Drawing.Point(117, 9);
            this.lblTitreBase.Name = "lblTitreBase";
            this.lblTitreBase.Size = new System.Drawing.Size(119, 31);
            this.lblTitreBase.TabIndex = 30;
            this.lblTitreBase.Text = "Redows";
            this.lblTitreBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(162, 40);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 17);
            this.lblVersion.TabIndex = 31;
            this.lblVersion.Text = "v2.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 384);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitreBase);
            this.Controls.Add(this.btnAvance);
            this.Controls.Add(this.btnCheckUpdates);
            this.Controls.Add(this.btnInfos);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accueil_FormClosing);
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInfos;
        private System.Windows.Forms.Button btnCheckUpdates;
        private System.Windows.Forms.Button btnAvance;
        private System.Windows.Forms.Label lblTitreBase;
        private System.Windows.Forms.Label lblVersion;
    }
}