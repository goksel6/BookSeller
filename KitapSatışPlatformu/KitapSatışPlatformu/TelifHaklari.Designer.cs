namespace KitapSatışPlatformu
{
    partial class TelifHaklari
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTelifHakki = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelifHakki)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "© Copyright 1996-2017 Arkhe Kitap Mağazacılık ve Pazarlama A.Ş.";
            // 
            // pictureBoxTelifHakki
            // 
            this.pictureBoxTelifHakki.Image = global::KitapSatışPlatformu.Properties.Resources._2017_12_09_13_42_03;
            this.pictureBoxTelifHakki.Location = new System.Drawing.Point(52, 37);
            this.pictureBoxTelifHakki.Name = "pictureBoxTelifHakki";
            this.pictureBoxTelifHakki.Size = new System.Drawing.Size(929, 355);
            this.pictureBoxTelifHakki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTelifHakki.TabIndex = 0;
            this.pictureBoxTelifHakki.TabStop = false;
            // 
            // TelifHaklari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1021, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxTelifHakki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelifHaklari";
            this.Text = "TelifHaklari";
            this.Load += new System.EventHandler(this.TelifHaklari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelifHakki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTelifHakki;
        private System.Windows.Forms.Label label1;
    }
}