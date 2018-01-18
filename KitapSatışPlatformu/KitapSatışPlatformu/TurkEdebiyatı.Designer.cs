namespace KitapSatışPlatformu
{
    partial class TurkEdebiyatı
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
            this.dataGridViewTürkiye = new System.Windows.Forms.DataGridView();
            this.groupBoxKitapAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTürkiye)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKitapAdi
            // 
            this.groupBoxKitapAdi.BackColor = System.Drawing.Color.SeaShell;
            this.groupBoxKitapAdi.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.kkkkkkkitap;
            this.groupBoxKitapAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxKitapAdi.Controls.Add(this.dataGridViewTürkiye);
            this.groupBoxKitapAdi.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKitapAdi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKitapAdi.Name = "groupBoxKitapAdi";
            this.groupBoxKitapAdi.Size = new System.Drawing.Size(1016, 550);
            this.groupBoxKitapAdi.TabIndex = 1;
            this.groupBoxKitapAdi.TabStop = false;
            this.groupBoxKitapAdi.Text = "TÜRK EDEBİYATI";
            // 
            // dataGridViewTürkiye
            // 
            this.dataGridViewTürkiye.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewTürkiye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTürkiye.Location = new System.Drawing.Point(6, 84);
            this.dataGridViewTürkiye.Name = "dataGridViewTürkiye";
            this.dataGridViewTürkiye.RowTemplate.Height = 28;
            this.dataGridViewTürkiye.Size = new System.Drawing.Size(675, 228);
            this.dataGridViewTürkiye.TabIndex = 5;
            this.dataGridViewTürkiye.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTürkiye_CellClick);
            // 
            // TurkEdebiyatı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 574);
            this.Controls.Add(this.groupBoxKitapAdi);
            this.Name = "TurkEdebiyatı";
            this.Text = "TurkEdebiyatı";
            this.Load += new System.EventHandler(this.TurkEdebiyatı_Load);
            this.groupBoxKitapAdi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTürkiye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKitapAdi;
        private System.Windows.Forms.DataGridView dataGridViewTürkiye;
    }
}