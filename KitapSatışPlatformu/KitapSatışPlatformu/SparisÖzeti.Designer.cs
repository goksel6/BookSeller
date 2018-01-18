namespace KitapSatışPlatformu
{
    partial class SparisÖzeti
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxacikAdres = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxİl = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxOdemeSec = new System.Windows.Forms.GroupBox();
            this.buttonTamamlandı = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxCvc = new System.Windows.Forms.TextBox();
            this.textBoxCvckayıt = new System.Windows.Forms.TextBox();
            this.textBoxSkt = new System.Windows.Forms.TextBox();
            this.comboBoxAy = new System.Windows.Forms.ComboBox();
            this.comboBoxYıl = new System.Windows.Forms.ComboBox();
            this.textBoxKartno = new System.Windows.Forms.TextBox();
            this.textBoxKartSahi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxKargoAdi = new System.Windows.Forms.TextBox();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldk = new System.Windows.Forms.Label();
            this.labelsn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxOdemeSec.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxTel);
            this.groupBox1.Controls.Add(this.richTextBoxacikAdres);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBoxİl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(420, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres Bilgileri";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTel.Location = new System.Drawing.Point(7, 296);
            this.maskedTextBoxTel.Mask = "(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(285, 36);
            this.maskedTextBoxTel.TabIndex = 3;
            // 
            // richTextBoxacikAdres
            // 
            this.richTextBoxacikAdres.Location = new System.Drawing.Point(6, 134);
            this.richTextBoxacikAdres.Name = "richTextBoxacikAdres";
            this.richTextBoxacikAdres.Size = new System.Drawing.Size(286, 155);
            this.richTextBoxacikAdres.TabIndex = 2;
            this.richTextBoxacikAdres.Text = "Açık Adresinizi Giriniz...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "İlçe";
            // 
            // comboBoxİl
            // 
            this.comboBoxİl.FormattingEnabled = true;
            this.comboBoxİl.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon",
            "04 Ağrı",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.comboBoxİl.Location = new System.Drawing.Point(7, 49);
            this.comboBoxİl.Name = "comboBoxİl";
            this.comboBoxİl.Size = new System.Drawing.Size(285, 36);
            this.comboBoxİl.TabIndex = 0;
            this.comboBoxİl.Text = "Şehir";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBoxOdemeSec
            // 
            this.groupBoxOdemeSec.Controls.Add(this.buttonTamamlandı);
            this.groupBoxOdemeSec.Controls.Add(this.checkBox3);
            this.groupBoxOdemeSec.Controls.Add(this.groupBox3);
            this.groupBoxOdemeSec.Controls.Add(this.checkBox2);
            this.groupBoxOdemeSec.Controls.Add(this.groupBox2);
            this.groupBoxOdemeSec.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxOdemeSec.Location = new System.Drawing.Point(753, 13);
            this.groupBoxOdemeSec.Name = "groupBoxOdemeSec";
            this.groupBoxOdemeSec.Size = new System.Drawing.Size(529, 588);
            this.groupBoxOdemeSec.TabIndex = 1;
            this.groupBoxOdemeSec.TabStop = false;
            this.groupBoxOdemeSec.Text = "Ödeme Seçenekleri";
            // 
            // buttonTamamlandı
            // 
            this.buttonTamamlandı.Location = new System.Drawing.Point(6, 520);
            this.buttonTamamlandı.Name = "buttonTamamlandı";
            this.buttonTamamlandı.Size = new System.Drawing.Size(193, 56);
            this.buttonTamamlandı.TabIndex = 4;
            this.buttonTamamlandı.Text = "Tamamlandı";
            this.buttonTamamlandı.UseVisualStyleBackColor = true;
            this.buttonTamamlandı.Click += new System.EventHandler(this.buttonTamamlandı_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(6, 446);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(480, 32);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Mesafeli Satış Sözleşmesini okudum ve kabul ediyorum!";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 134);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kapıda Ödeme";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(368, 36);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Ödeme Yapacak Kisi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kredi Kartı ",
            "Nakit",
            "Kupon"});
            this.comboBox1.Location = new System.Drawing.Point(6, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 36);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Ödeme Seçeneği";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 482);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(516, 32);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = " Ön Bilgilendirme Sözleşmesini okudum ve kabul ediyorum!";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBoxCvc);
            this.groupBox2.Controls.Add(this.textBoxCvckayıt);
            this.groupBox2.Controls.Add(this.textBoxSkt);
            this.groupBox2.Controls.Add(this.comboBoxAy);
            this.groupBox2.Controls.Add(this.comboBoxYıl);
            this.groupBox2.Controls.Add(this.textBoxKartno);
            this.groupBox2.Controls.Add(this.textBoxKartSahi);
            this.groupBox2.Location = new System.Drawing.Point(6, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 265);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kredi Kartı ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(247, 32);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = " E-arşiv fatura istiyorum!";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxCvc
            // 
            this.textBoxCvc.Location = new System.Drawing.Point(7, 162);
            this.textBoxCvc.Name = "textBoxCvc";
            this.textBoxCvc.Size = new System.Drawing.Size(217, 36);
            this.textBoxCvc.TabIndex = 6;
            this.textBoxCvc.Text = "CVC";
            // 
            // textBoxCvckayıt
            // 
            this.textBoxCvckayıt.Location = new System.Drawing.Point(230, 162);
            this.textBoxCvckayıt.Name = "textBoxCvckayıt";
            this.textBoxCvckayıt.PasswordChar = '*';
            this.textBoxCvckayıt.Size = new System.Drawing.Size(145, 36);
            this.textBoxCvckayıt.TabIndex = 5;
            // 
            // textBoxSkt
            // 
            this.textBoxSkt.Location = new System.Drawing.Point(7, 120);
            this.textBoxSkt.Name = "textBoxSkt";
            this.textBoxSkt.Size = new System.Drawing.Size(217, 36);
            this.textBoxSkt.TabIndex = 4;
            this.textBoxSkt.Text = "Son Kullanma Tarihi";
            // 
            // comboBoxAy
            // 
            this.comboBoxAy.FormattingEnabled = true;
            this.comboBoxAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxAy.Location = new System.Drawing.Point(230, 120);
            this.comboBoxAy.Name = "comboBoxAy";
            this.comboBoxAy.Size = new System.Drawing.Size(54, 36);
            this.comboBoxAy.TabIndex = 3;
            // 
            // comboBoxYıl
            // 
            this.comboBoxYıl.FormattingEnabled = true;
            this.comboBoxYıl.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBoxYıl.Location = new System.Drawing.Point(290, 120);
            this.comboBoxYıl.Name = "comboBoxYıl";
            this.comboBoxYıl.Size = new System.Drawing.Size(85, 36);
            this.comboBoxYıl.TabIndex = 2;
            // 
            // textBoxKartno
            // 
            this.textBoxKartno.Location = new System.Drawing.Point(7, 78);
            this.textBoxKartno.Name = "textBoxKartno";
            this.textBoxKartno.Size = new System.Drawing.Size(368, 36);
            this.textBoxKartno.TabIndex = 1;
            this.textBoxKartno.Text = "Kart Numarası";
            // 
            // textBoxKartSahi
            // 
            this.textBoxKartSahi.Location = new System.Drawing.Point(7, 36);
            this.textBoxKartSahi.Name = "textBoxKartSahi";
            this.textBoxKartSahi.Size = new System.Drawing.Size(368, 36);
            this.textBoxKartSahi.TabIndex = 0;
            this.textBoxKartSahi.Text = "Kart Sahibinin Adı";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(392, 584);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxKargoAdi);
            this.groupBox4.Controls.Add(this.textBoxAdet);
            this.groupBox4.Controls.Add(this.textBoxToplamTutar);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(420, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 131);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Özet";
            // 
            // textBoxKargoAdi
            // 
            this.textBoxKargoAdi.Location = new System.Drawing.Point(156, 71);
            this.textBoxKargoAdi.Name = "textBoxKargoAdi";
            this.textBoxKargoAdi.ReadOnly = true;
            this.textBoxKargoAdi.Size = new System.Drawing.Size(136, 36);
            this.textBoxKargoAdi.TabIndex = 2;
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(7, 71);
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.ReadOnly = true;
            this.textBoxAdet.Size = new System.Drawing.Size(143, 36);
            this.textBoxAdet.TabIndex = 1;
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.Location = new System.Drawing.Point(7, 29);
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.ReadOnly = true;
            this.textBoxToplamTutar.Size = new System.Drawing.Size(285, 36);
            this.textBoxToplamTutar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.labeldk);
            this.groupBox5.Controls.Add(this.labelsn);
            this.groupBox5.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(420, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(319, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kalan Süre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // labeldk
            // 
            this.labeldk.AutoSize = true;
            this.labeldk.Location = new System.Drawing.Point(6, 32);
            this.labeldk.Name = "labeldk";
            this.labeldk.Size = new System.Drawing.Size(24, 28);
            this.labeldk.TabIndex = 1;
            this.labeldk.Text = "3";
            // 
            // labelsn
            // 
            this.labelsn.AutoSize = true;
            this.labelsn.Location = new System.Drawing.Point(95, 32);
            this.labelsn.Name = "labelsn";
            this.labelsn.Size = new System.Drawing.Size(36, 28);
            this.labelsn.TabIndex = 0;
            this.labelsn.Text = "00";
            // 
            // SparisÖzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1294, 613);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxOdemeSec);
            this.Controls.Add(this.groupBox1);
            this.Name = "SparisÖzeti";
            this.Text = "SparisÖzeti";
            this.Load += new System.EventHandler(this.SparisÖzeti_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxOdemeSec.ResumeLayout(false);
            this.groupBoxOdemeSec.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxacikAdres;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxİl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxKargoAdi;
        private System.Windows.Forms.TextBox textBoxAdet;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxOdemeSec;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxCvc;
        private System.Windows.Forms.TextBox textBoxCvckayıt;
        private System.Windows.Forms.TextBox textBoxSkt;
        private System.Windows.Forms.ComboBox comboBoxAy;
        private System.Windows.Forms.ComboBox comboBoxYıl;
        private System.Windows.Forms.TextBox textBoxKartno;
        private System.Windows.Forms.TextBox textBoxKartSahi;
        private System.Windows.Forms.Button buttonTamamlandı;
        private System.Windows.Forms.Label labelsn;
        private System.Windows.Forms.Label labeldk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
    }
}