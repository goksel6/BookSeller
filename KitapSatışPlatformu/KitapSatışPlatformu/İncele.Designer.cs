namespace KitapSatışPlatformu
{
    partial class İncele
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
            this.dataGridViewincele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewincele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün İncelemesi";
            // 
            // dataGridViewincele
            // 
            this.dataGridViewincele.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewincele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewincele.Location = new System.Drawing.Point(9, 60);
            this.dataGridViewincele.Name = "dataGridViewincele";
            this.dataGridViewincele.RowTemplate.Height = 28;
            this.dataGridViewincele.Size = new System.Drawing.Size(1198, 155);
            this.dataGridViewincele.TabIndex = 1;
            // 
            // İncele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1223, 243);
            this.Controls.Add(this.dataGridViewincele);
            this.Controls.Add(this.label1);
            this.Name = "İncele";
            this.Text = "İncele";
            this.Load += new System.EventHandler(this.İncele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewincele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewincele;
    }
}