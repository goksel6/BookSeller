namespace KitapSatışPlatformu
{
    partial class Form2016
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
            this.dataGridView2016 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2016)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.kitaaaaaaaaaaaaap;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView2016);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2016 Yılında En Çok Okunan 5 Kitap";
            // 
            // dataGridView2016
            // 
            this.dataGridView2016.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView2016.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2016.Location = new System.Drawing.Point(26, 42);
            this.dataGridView2016.Name = "dataGridView2016";
            this.dataGridView2016.RowTemplate.Height = 28;
            this.dataGridView2016.Size = new System.Drawing.Size(599, 244);
            this.dataGridView2016.TabIndex = 0;
            this.dataGridView2016.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2016_CellClick);
            // 
            // Form2016
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(928, 525);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2016";
            this.Text = "2016 Kitapları";
            this.Load += new System.EventHandler(this.Form2016_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2016)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2016;
    }
}