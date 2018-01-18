namespace KitapSatışPlatformu
{
    partial class form2017
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
            this.groupbox2017 = new System.Windows.Forms.GroupBox();
            this.dataGridView2017 = new System.Windows.Forms.DataGridView();
            this.groupbox2017.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2017)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox2017
            // 
            this.groupbox2017.BackgroundImage = global::KitapSatışPlatformu.Properties.Resources.kitaaaaaaaaaaaaap;
            this.groupbox2017.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupbox2017.Controls.Add(this.dataGridView2017);
            this.groupbox2017.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupbox2017.Location = new System.Drawing.Point(7, 12);
            this.groupbox2017.Name = "groupbox2017";
            this.groupbox2017.Size = new System.Drawing.Size(890, 484);
            this.groupbox2017.TabIndex = 0;
            this.groupbox2017.TabStop = false;
            this.groupbox2017.Text = "2017 Yılında En Çok Okunan 5 Kitap";
            // 
            // dataGridView2017
            // 
            this.dataGridView2017.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView2017.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2017.Location = new System.Drawing.Point(6, 33);
            this.dataGridView2017.Name = "dataGridView2017";
            this.dataGridView2017.RowTemplate.Height = 28;
            this.dataGridView2017.Size = new System.Drawing.Size(624, 244);
            this.dataGridView2017.TabIndex = 0;
            this.dataGridView2017.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2017_CellClick);
            // 
            // form2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(909, 508);
            this.Controls.Add(this.groupbox2017);
            this.Name = "form2017";
            this.Text = "2017 Kitapları";
            this.Load += new System.EventHandler(this.form2017_Load);
            this.groupbox2017.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2017)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox2017;
        private System.Windows.Forms.DataGridView dataGridView2017;
    }
}