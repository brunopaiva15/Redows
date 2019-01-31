namespace Redows
{
    partial class Avance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avance));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesCortana = new System.Windows.Forms.Button();
            this.btnDesNDU = new System.Windows.Forms.Button();
            this.btnDesactiverPrefetch = new System.Windows.Forms.Button();
            this.btnDesactiverSuperfetch = new System.Windows.Forms.Button();
            this.btnRetourAccueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Outils avancés de Redows.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesCortana
            // 
            this.btnDesCortana.Location = new System.Drawing.Point(73, 147);
            this.btnDesCortana.Name = "btnDesCortana";
            this.btnDesCortana.Size = new System.Drawing.Size(121, 23);
            this.btnDesCortana.TabIndex = 30;
            this.btnDesCortana.Text = "Désactiver Cortana";
            this.btnDesCortana.UseVisualStyleBackColor = true;
            this.btnDesCortana.Click += new System.EventHandler(this.btnDesCortana_Click);
            // 
            // btnDesNDU
            // 
            this.btnDesNDU.Location = new System.Drawing.Point(73, 187);
            this.btnDesNDU.Name = "btnDesNDU";
            this.btnDesNDU.Size = new System.Drawing.Size(121, 23);
            this.btnDesNDU.TabIndex = 32;
            this.btnDesNDU.Text = "Désactiver NDU";
            this.btnDesNDU.UseVisualStyleBackColor = true;
            this.btnDesNDU.Click += new System.EventHandler(this.btnDesNDU_Click);
            // 
            // btnDesactiverPrefetch
            // 
            this.btnDesactiverPrefetch.Location = new System.Drawing.Point(73, 227);
            this.btnDesactiverPrefetch.Name = "btnDesactiverPrefetch";
            this.btnDesactiverPrefetch.Size = new System.Drawing.Size(121, 23);
            this.btnDesactiverPrefetch.TabIndex = 33;
            this.btnDesactiverPrefetch.Text = "Désactiver Prefetch";
            this.btnDesactiverPrefetch.UseVisualStyleBackColor = true;
            this.btnDesactiverPrefetch.Click += new System.EventHandler(this.btnDesactiverPrefetch_Click);
            // 
            // btnDesactiverSuperfetch
            // 
            this.btnDesactiverSuperfetch.Location = new System.Drawing.Point(73, 267);
            this.btnDesactiverSuperfetch.Name = "btnDesactiverSuperfetch";
            this.btnDesactiverSuperfetch.Size = new System.Drawing.Size(121, 23);
            this.btnDesactiverSuperfetch.TabIndex = 34;
            this.btnDesactiverSuperfetch.Text = "Désactiver Superfetch";
            this.btnDesactiverSuperfetch.UseVisualStyleBackColor = true;
            this.btnDesactiverSuperfetch.Click += new System.EventHandler(this.btnDesactiverSuperfetch_Click);
            // 
            // btnRetourAccueil
            // 
            this.btnRetourAccueil.Location = new System.Drawing.Point(10, 314);
            this.btnRetourAccueil.Name = "btnRetourAccueil";
            this.btnRetourAccueil.Size = new System.Drawing.Size(84, 23);
            this.btnRetourAccueil.TabIndex = 39;
            this.btnRetourAccueil.Text = "<- Accueil";
            this.btnRetourAccueil.UseVisualStyleBackColor = true;
            this.btnRetourAccueil.Click += new System.EventHandler(this.btnRetourAccueil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Redows.Properties.Resources.winrep;
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Avance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 347);
            this.Controls.Add(this.btnRetourAccueil);
            this.Controls.Add(this.btnDesactiverSuperfetch);
            this.Controls.Add(this.btnDesactiverPrefetch);
            this.Controls.Add(this.btnDesNDU);
            this.Controls.Add(this.btnDesCortana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Avance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Avance_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesCortana;
        private System.Windows.Forms.Button btnDesNDU;
        private System.Windows.Forms.Button btnDesactiverPrefetch;
        private System.Windows.Forms.Button btnDesactiverSuperfetch;
        private System.Windows.Forms.Button btnRetourAccueil;
    }
}