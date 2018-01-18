namespace KitapSatışPlatformu
{
    partial class OkumaListeleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewfelsefe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfelsefe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.arkaa;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridViewfelsefe);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(941, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçtiğiniz Türe Göre Kitaplarımız";
            // 
            // dataGridViewfelsefe
            // 
            this.dataGridViewfelsefe.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewfelsefe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfelsefe.Location = new System.Drawing.Point(27, 65);
            this.dataGridViewfelsefe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewfelsefe.Name = "dataGridViewfelsefe";
            this.dataGridViewfelsefe.RowTemplate.Height = 28;
            this.dataGridViewfelsefe.Size = new System.Drawing.Size(425, 177);
            this.dataGridViewfelsefe.TabIndex = 0;
            this.dataGridViewfelsefe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewfelsefe_CellClick);
            // 
            // OkumaListeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 517);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OkumaListeleri";
            this.Text = "Felsefe Kitap";
            this.Load += new System.EventHandler(this.türFelsefe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfelsefe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewfelsefe;
    }
}