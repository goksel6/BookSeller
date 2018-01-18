namespace KitapSatışPlatformu
{
    partial class FransızEdebiyatı
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
            this.dataGridViewFransa = new System.Windows.Forms.DataGridView();
            this.groupBoxKitapAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFransa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKitapAdi
            // 
            this.groupBoxKitapAdi.BackColor = System.Drawing.Color.SeaShell;
            this.groupBoxKitapAdi.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.kkkkkkkitap;
            this.groupBoxKitapAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxKitapAdi.Controls.Add(this.dataGridViewFransa);
            this.groupBoxKitapAdi.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKitapAdi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKitapAdi.Name = "groupBoxKitapAdi";
            this.groupBoxKitapAdi.Size = new System.Drawing.Size(995, 555);
            this.groupBoxKitapAdi.TabIndex = 2;
            this.groupBoxKitapAdi.TabStop = false;
            this.groupBoxKitapAdi.Text = "FRANSIZ EDEBİYATI";
            // 
            // dataGridViewFransa
            // 
            this.dataGridViewFransa.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewFransa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFransa.Location = new System.Drawing.Point(6, 87);
            this.dataGridViewFransa.Name = "dataGridViewFransa";
            this.dataGridViewFransa.RowTemplate.Height = 28;
            this.dataGridViewFransa.Size = new System.Drawing.Size(644, 211);
            this.dataGridViewFransa.TabIndex = 5;
            this.dataGridViewFransa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFransa_CellClick);
            // 
            // FransızEdebiyatı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 579);
            this.Controls.Add(this.groupBoxKitapAdi);
            this.Name = "FransızEdebiyatı";
            this.Text = "FransızEdebiyatı";
            this.Load += new System.EventHandler(this.FransızEdebiyatı_Load);
            this.groupBoxKitapAdi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFransa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKitapAdi;
        private System.Windows.Forms.DataGridView dataGridViewFransa;
    }
}