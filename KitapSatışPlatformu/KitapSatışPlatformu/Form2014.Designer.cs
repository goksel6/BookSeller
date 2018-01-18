namespace KitapSatışPlatformu
{
    partial class Form2014
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
            this.dataGridView2014 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2014)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.kitaaaaaaaaaaaaap;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView2014);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2014 Yılında En Çok Okunan 5 Kitap";
            // 
            // dataGridView2014
            // 
            this.dataGridView2014.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView2014.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2014.Location = new System.Drawing.Point(6, 42);
            this.dataGridView2014.Name = "dataGridView2014";
            this.dataGridView2014.RowTemplate.Height = 28;
            this.dataGridView2014.Size = new System.Drawing.Size(601, 254);
            this.dataGridView2014.TabIndex = 0;
            this.dataGridView2014.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2014_CellClick);
            // 
            // Form2014
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(927, 537);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2014";
            this.Text = "2014 Kitapları";
            this.Load += new System.EventHandler(this.Form2014_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2014)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2014;
    }
}