namespace KitapSatışPlatformu
{
    partial class YeniKayıt
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
            this.checkBoxSozlesme = new System.Windows.Forms.CheckBox();
            this.buttonUyeOl = new System.Windows.Forms.Button();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.textBoxTelGir = new System.Windows.Forms.TextBox();
            this.textBoxParolaTek = new System.Windows.Forms.TextBox();
            this.textBoxParolaTekrarGir = new System.Windows.Forms.TextBox();
            this.textBoxparolaGir = new System.Windows.Forms.TextBox();
            this.textBoxAdGir = new System.Windows.Forms.TextBox();
            this.textBoxTelNo = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBoxKitapAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKitapAdi
            // 
            this.groupBoxKitapAdi.Controls.Add(this.checkBoxSozlesme);
            this.groupBoxKitapAdi.Controls.Add(this.buttonUyeOl);
            this.groupBoxKitapAdi.Controls.Add(this.comboBoxCinsiyet);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxTelGir);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxParolaTek);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxParolaTekrarGir);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxparolaGir);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxAdGir);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxTelNo);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxParola);
            this.groupBoxKitapAdi.Controls.Add(this.textBoxAdSoyad);
            this.groupBoxKitapAdi.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKitapAdi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKitapAdi.Name = "groupBoxKitapAdi";
            this.groupBoxKitapAdi.Size = new System.Drawing.Size(477, 454);
            this.groupBoxKitapAdi.TabIndex = 1;
            this.groupBoxKitapAdi.TabStop = false;
            this.groupBoxKitapAdi.Text = "MERHABA";
            // 
            // checkBoxSozlesme
            // 
            this.checkBoxSozlesme.AutoSize = true;
            this.checkBoxSozlesme.Checked = true;
            this.checkBoxSozlesme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSozlesme.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSozlesme.Location = new System.Drawing.Point(6, 336);
            this.checkBoxSozlesme.Name = "checkBoxSozlesme";
            this.checkBoxSozlesme.Size = new System.Drawing.Size(430, 35);
            this.checkBoxSozlesme.TabIndex = 12;
            this.checkBoxSozlesme.Text = "Üyelik Sözleşmesi\'ni okudum, onaylıyorum.";
            this.checkBoxSozlesme.UseVisualStyleBackColor = true;
            // 
            // buttonUyeOl
            // 
            this.buttonUyeOl.Location = new System.Drawing.Point(0, 381);
            this.buttonUyeOl.Name = "buttonUyeOl";
            this.buttonUyeOl.Size = new System.Drawing.Size(436, 61);
            this.buttonUyeOl.TabIndex = 11;
            this.buttonUyeOl.Text = "ÜYE OL";
            this.buttonUyeOl.UseVisualStyleBackColor = true;
            this.buttonUyeOl.Click += new System.EventHandler(this.buttonUyeOl_Click);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK",
            "DİĞER"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(6, 274);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(430, 39);
            this.comboBoxCinsiyet.TabIndex = 10;
            this.comboBoxCinsiyet.Text = "CİNSİYET";
            // 
            // textBoxTelGir
            // 
            this.textBoxTelGir.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTelGir.Location = new System.Drawing.Point(208, 231);
            this.textBoxTelGir.Name = "textBoxTelGir";
            this.textBoxTelGir.Size = new System.Drawing.Size(228, 39);
            this.textBoxTelGir.TabIndex = 9;
            // 
            // textBoxParolaTek
            // 
            this.textBoxParolaTek.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxParolaTek.Location = new System.Drawing.Point(6, 184);
            this.textBoxParolaTek.Name = "textBoxParolaTek";
            this.textBoxParolaTek.ReadOnly = true;
            this.textBoxParolaTek.Size = new System.Drawing.Size(196, 39);
            this.textBoxParolaTek.TabIndex = 8;
            this.textBoxParolaTek.Text = "PAROLA TEKRAR*:";
            // 
            // textBoxParolaTekrarGir
            // 
            this.textBoxParolaTekrarGir.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxParolaTekrarGir.Location = new System.Drawing.Point(208, 186);
            this.textBoxParolaTekrarGir.Name = "textBoxParolaTekrarGir";
            this.textBoxParolaTekrarGir.PasswordChar = '*';
            this.textBoxParolaTekrarGir.Size = new System.Drawing.Size(228, 39);
            this.textBoxParolaTekrarGir.TabIndex = 7;
            // 
            // textBoxparolaGir
            // 
            this.textBoxparolaGir.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxparolaGir.Location = new System.Drawing.Point(208, 139);
            this.textBoxparolaGir.Name = "textBoxparolaGir";
            this.textBoxparolaGir.PasswordChar = '*';
            this.textBoxparolaGir.Size = new System.Drawing.Size(228, 39);
            this.textBoxparolaGir.TabIndex = 6;
            // 
            // textBoxAdGir
            // 
            this.textBoxAdGir.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdGir.Location = new System.Drawing.Point(208, 96);
            this.textBoxAdGir.Name = "textBoxAdGir";
            this.textBoxAdGir.Size = new System.Drawing.Size(228, 39);
            this.textBoxAdGir.TabIndex = 5;
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTelNo.Location = new System.Drawing.Point(6, 229);
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.ReadOnly = true;
            this.textBoxTelNo.Size = new System.Drawing.Size(196, 39);
            this.textBoxTelNo.TabIndex = 2;
            this.textBoxTelNo.Text = "TELEFON NO:";
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxParola.Location = new System.Drawing.Point(6, 139);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.ReadOnly = true;
            this.textBoxParola.Size = new System.Drawing.Size(196, 39);
            this.textBoxParola.TabIndex = 1;
            this.textBoxParola.Text = "PAROLA*:";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad.Location = new System.Drawing.Point(6, 94);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.ReadOnly = true;
            this.textBoxAdSoyad.Size = new System.Drawing.Size(196, 39);
            this.textBoxAdSoyad.TabIndex = 0;
            this.textBoxAdSoyad.Text = "AD SOYAD*:";
            // 
            // YeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(554, 503);
            this.Controls.Add(this.groupBoxKitapAdi);
            this.Name = "YeniKayıt";
            this.Text = "YeniKayıt";
            this.Load += new System.EventHandler(this.YeniKayıt_Load);
            this.groupBoxKitapAdi.ResumeLayout(false);
            this.groupBoxKitapAdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKitapAdi;
        private System.Windows.Forms.TextBox textBoxTelNo;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.CheckBox checkBoxSozlesme;
        private System.Windows.Forms.Button buttonUyeOl;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.TextBox textBoxTelGir;
        private System.Windows.Forms.TextBox textBoxParolaTek;
        private System.Windows.Forms.TextBox textBoxParolaTekrarGir;
        private System.Windows.Forms.TextBox textBoxparolaGir;
        private System.Windows.Forms.TextBox textBoxAdGir;
    }
}