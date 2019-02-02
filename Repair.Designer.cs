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
    partial class Repair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair));
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnReparerWIM = new System.Windows.Forms.Button();
            this.btnOpenNumIndex = new System.Windows.Forms.Button();
            this.tbxPathNumIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnConnaitre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModeBasique = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCacherCMD = new System.Windows.Forms.CheckBox();
            this.lblEnReparation = new System.Windows.Forms.Label();
            this.winVersion = new System.Windows.Forms.Label();
            this.btnAvance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(93, 114);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(171, 34);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "So you\'re an expert then?\r\nWe trust you!";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReparerWIM
            // 
            this.btnReparerWIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparerWIM.Location = new System.Drawing.Point(9, 47);
            this.btnReparerWIM.Name = "btnReparerWIM";
            this.btnReparerWIM.Size = new System.Drawing.Size(331, 35);
            this.btnReparerWIM.TabIndex = 12;
            this.btnReparerWIM.Text = "Repair with WIM file";
            this.btnReparerWIM.UseVisualStyleBackColor = true;
            this.btnReparerWIM.Click += new System.EventHandler(this.btnReparerWIM_Click);
            // 
            // btnOpenNumIndex
            // 
            this.btnOpenNumIndex.Location = new System.Drawing.Point(303, 180);
            this.btnOpenNumIndex.Name = "btnOpenNumIndex";
            this.btnOpenNumIndex.Size = new System.Drawing.Size(44, 23);
            this.btnOpenNumIndex.TabIndex = 4;
            this.btnOpenNumIndex.Text = "...";
            this.btnOpenNumIndex.UseVisualStyleBackColor = true;
            this.btnOpenNumIndex.Click += new System.EventHandler(this.btnOpenNumIndex_Click);
            // 
            // tbxPathNumIndex
            // 
            this.tbxPathNumIndex.Location = new System.Drawing.Point(124, 182);
            this.tbxPathNumIndex.Name = "tbxPathNumIndex";
            this.tbxPathNumIndex.Size = new System.Drawing.Size(173, 20);
            this.tbxPathNumIndex.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "WIM file to use:";
            // 
            // tbxIndex
            // 
            this.tbxIndex.Location = new System.Drawing.Point(292, 22);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(48, 20);
            this.tbxIndex.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Index number :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnConnaitre
            // 
            this.btnConnaitre.Location = new System.Drawing.Point(124, 209);
            this.btnConnaitre.Name = "btnConnaitre";
            this.btnConnaitre.Size = new System.Drawing.Size(223, 23);
            this.btnConnaitre.TabIndex = 6;
            this.btnConnaitre.Text = "Know index number";
            this.btnConnaitre.UseVisualStyleBackColor = true;
            this.btnConnaitre.Click += new System.EventHandler(this.btnConnaitre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Index number :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Redows.Properties.Resources.winrep;
            this.pictureBox1.Location = new System.Drawing.Point(136, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnModeBasique
            // 
            this.btnModeBasique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeBasique.Location = new System.Drawing.Point(7, 362);
            this.btnModeBasique.Name = "btnModeBasique";
            this.btnModeBasique.Size = new System.Drawing.Size(96, 23);
            this.btnModeBasique.TabIndex = 13;
            this.btnModeBasique.Text = "<- Easy mode";
            this.btnModeBasique.UseVisualStyleBackColor = true;
            this.btnModeBasique.Click += new System.EventHandler(this.btnModeBasique_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxCacherCMD);
            this.groupBox2.Controls.Add(this.btnReparerWIM);
            this.groupBox2.Controls.Add(this.tbxIndex);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(7, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 99);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repair";
            // 
            // cbxCacherCMD
            // 
            this.cbxCacherCMD.AutoSize = true;
            this.cbxCacherCMD.Location = new System.Drawing.Point(12, 25);
            this.cbxCacherCMD.Name = "cbxCacherCMD";
            this.cbxCacherCMD.Size = new System.Drawing.Size(75, 17);
            this.cbxCacherCMD.TabIndex = 0;
            this.cbxCacherCMD.Text = "Hide CMD";
            this.cbxCacherCMD.UseVisualStyleBackColor = true;
            this.cbxCacherCMD.CheckedChanged += new System.EventHandler(this.cbxCacherCMD_CheckedChanged);
            // 
            // lblEnReparation
            // 
            this.lblEnReparation.AutoSize = true;
            this.lblEnReparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnReparation.Location = new System.Drawing.Point(49, 114);
            this.lblEnReparation.Name = "lblEnReparation";
            this.lblEnReparation.Size = new System.Drawing.Size(267, 34);
            this.lblEnReparation.TabIndex = 34;
            this.lblEnReparation.Text = "Repair in progress. Don\'t touch anything.\r\n(Okay, you\'re an expert. So you know.)" +
    "";
            this.lblEnReparation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnReparation.Visible = false;
            // 
            // winVersion
            // 
            this.winVersion.AutoSize = true;
            this.winVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winVersion.Location = new System.Drawing.Point(12, 15);
            this.winVersion.Name = "winVersion";
            this.winVersion.Size = new System.Drawing.Size(0, 13);
            this.winVersion.TabIndex = 35;
            this.winVersion.Visible = false;
            // 
            // btnAvance
            // 
            this.btnAvance.AutoSize = true;
            this.btnAvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvance.Location = new System.Drawing.Point(18, 15);
            this.btnAvance.Name = "btnAvance";
            this.btnAvance.Size = new System.Drawing.Size(16, 17);
            this.btnAvance.TabIndex = 36;
            this.btnAvance.Text = "  ";
            this.btnAvance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAvance.Visible = false;
            // 
            // Repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 397);
            this.Controls.Add(this.btnAvance);
            this.Controls.Add(this.winVersion);
            this.Controls.Add(this.lblEnReparation);
            this.Controls.Add(this.btnModeBasique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnaitre);
            this.Controls.Add(this.btnOpenNumIndex);
            this.Controls.Add(this.tbxPathNumIndex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Repair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Repair_FormClosing);
            this.Load += new System.EventHandler(this.Repair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReparerWIM;
        private System.Windows.Forms.Button btnOpenNumIndex;
        private System.Windows.Forms.TextBox tbxPathNumIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnConnaitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModeBasique;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnReparation;
        private System.Windows.Forms.Label winVersion;
        private System.Windows.Forms.CheckBox cbxCacherCMD;
        private System.Windows.Forms.Label btnAvance;
    }
}