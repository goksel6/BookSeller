namespace KitapSatışPlatformu
{
    partial class ArananUrun
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
            this.DataGridViewArananUrun = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArananUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewArananUrun
            // 
            this.DataGridViewArananUrun.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DataGridViewArananUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewArananUrun.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewArananUrun.Name = "DataGridViewArananUrun";
            this.DataGridViewArananUrun.RowTemplate.Height = 28;
            this.DataGridViewArananUrun.Size = new System.Drawing.Size(1049, 401);
            this.DataGridViewArananUrun.TabIndex = 0;
            this.DataGridViewArananUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewArananUrun_CellClick);
            // 
            // ArananUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1073, 425);
            this.Controls.Add(this.DataGridViewArananUrun);
            this.Name = "ArananUrun";
            this.Text = "ArananUrun";
            this.Load += new System.EventHandler(this.ArananUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArananUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewArananUrun;
    }
}