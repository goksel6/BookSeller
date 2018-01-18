namespace KitapSatışPlatformu
{
    partial class Form2
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
            this.dataGridViewİngiltere = new System.Windows.Forms.DataGridView();
            this.groupBoxKitapAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewİngiltere)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKitapAdi
            // 
            this.groupBoxKitapAdi.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.kkkkkkkitap;
            this.groupBoxKitapAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxKitapAdi.Controls.Add(this.dataGridViewİngiltere);
            this.groupBoxKitapAdi.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKitapAdi.Location = new System.Drawing.Point(13, 13);
            this.groupBoxKitapAdi.Name = "groupBoxKitapAdi";
            this.groupBoxKitapAdi.Size = new System.Drawing.Size(1008, 636);
            this.groupBoxKitapAdi.TabIndex = 0;
            this.groupBoxKitapAdi.TabStop = false;
            this.groupBoxKitapAdi.Text = "İNGİLİZ EDEBİYATI";
            // 
            // dataGridViewİngiltere
            // 
            this.dataGridViewİngiltere.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewİngiltere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewİngiltere.Location = new System.Drawing.Point(23, 88);
            this.dataGridViewİngiltere.Name = "dataGridViewİngiltere";
            this.dataGridViewİngiltere.RowTemplate.Height = 28;
            this.dataGridViewİngiltere.Size = new System.Drawing.Size(563, 222);
            this.dataGridViewİngiltere.TabIndex = 4;
            this.dataGridViewİngiltere.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewİngiltere_CellClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1033, 610);
            this.Controls.Add(this.groupBoxKitapAdi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxKitapAdi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewİngiltere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKitapAdi;
        private System.Windows.Forms.DataGridView dataGridViewİngiltere;
    }
}