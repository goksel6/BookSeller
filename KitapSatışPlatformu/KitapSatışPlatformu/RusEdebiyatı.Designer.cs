﻿namespace KitapSatışPlatformu
{
    partial class RusEdebiyatı
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
            this.groupBoxKitapAdi = new System.Windows.Forms.GroupBox();
            this.dataGridViewRusya = new System.Windows.Forms.DataGridView();
            this.groupBoxKitapAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRusya)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKitapAdi
            // 
            this.groupBoxKitapAdi.BackColor = System.Drawing.Color.SeaShell;
            this.groupBoxKitapAdi.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.kkkkkkkitap;
            this.groupBoxKitapAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxKitapAdi.Controls.Add(this.dataGridViewRusya);
            this.groupBoxKitapAdi.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKitapAdi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKitapAdi.Name = "groupBoxKitapAdi";
            this.groupBoxKitapAdi.Size = new System.Drawing.Size(1019, 551);
            this.groupBoxKitapAdi.TabIndex = 2;
            this.groupBoxKitapAdi.TabStop = false;
            this.groupBoxKitapAdi.Text = "RUS EDEBİYATI";
            // 
            // dataGridViewRusya
            // 
            this.dataGridViewRusya.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewRusya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRusya.Location = new System.Drawing.Point(23, 92);
            this.dataGridViewRusya.Name = "dataGridViewRusya";
            this.dataGridViewRusya.RowTemplate.Height = 28;
            this.dataGridViewRusya.Size = new System.Drawing.Size(607, 215);
            this.dataGridViewRusya.TabIndex = 5;
            this.dataGridViewRusya.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRusya_CellClick);
            // 
            // RusEdebiyatı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 575);
            this.Controls.Add(this.groupBoxKitapAdi);
            this.Name = "RusEdebiyatı";
            this.Text = "RusEdebiyatı";
            this.Load += new System.EventHandler(this.RusEdebiyatı_Load);
            this.groupBoxKitapAdi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRusya)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKitapAdi;
        private System.Windows.Forms.DataGridView dataGridViewRusya;
    }
}