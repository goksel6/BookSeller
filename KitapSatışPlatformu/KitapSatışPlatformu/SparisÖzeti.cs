using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapSatışPlatformu
{
    public partial class SparisÖzeti : Form
    {
        Sepet sepetim;
        public SparisÖzeti(Sepet s)
        {
            sepetim = s;
            InitializeComponent();
        }
        public int saniye=59;
        public int dakika = 2;
        private void SparisÖzeti_Load(object sender, EventArgs e)
        {
           
            timer1.Enabled=true;
            labelsn.Text = saniye.ToString();
            labeldk.Text = dakika.ToString();
            for (int i = 0; i < sepetim.anasayfa.sepetListesi.Count; i++)
            {
                listBox1.Items.Add(sepetim.anasayfa.sepetListesi[i]);
            }
            textBoxKargoAdi.Text = sepetim.secilenSirket;
            textBoxAdet.Text = sepetim.textBoxToplamUrun.Text;
            textBoxToplamTutar.Text = sepetim.textBoxToplamTutar.Text;

            }

        private void buttonTamamlandı_Click(object sender, EventArgs e)
        {
            bool  hata = false;
            if(richTextBoxacikAdres.Text== "Açık Adresinizi Giriniz...")
            {
                errorProvider1.SetError(richTextBoxacikAdres, "Adresinizi giriniz");
                hata = true;                   
            }

           if (maskedTextBoxTel.Text== "")
            {
                errorProvider1.SetError(maskedTextBoxTel, "Telefon numaranızı giriniz");
                hata = true;
            }
         if(textBoxKartSahi.Text== "Kart Sahibinin Adı" || textBoxKartno.Text== "Kart Numarası" || textBoxCvckayıt.Text=="")
            {
                errorProvider1.SetError(groupBox2, "Bu bölümde herhangi bir alan boş bırakılamaz");
                hata = true;
            }
         if(comboBox1.SelectedText== "Ödeme Seçeneği")
            {
                errorProvider1.SetError(comboBox1, "Lütfen bir ödeme seçeneği seçiniz ");
                hata = true;
            }
          if(!checkBox3.Checked)
            {
                errorProvider1.SetError(checkBox3, "Bu alanı işaretlemeniz zorunludur");
                hata = true;
            }
         if (!checkBox2.Checked)
            {
                errorProvider1.SetError(checkBox3, "Bu alanı işaretlemeniz zorunludur");
                hata = true;
            }
            if (hata == false)
            {
                sepetim.anasayfa.sepetListesi.Clear();
                this.Hide();
                MessageBox.Show("İşleminiz Başarıyla Tamamlandı");
            }            
                     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
           
            labelsn.Text = saniye.ToString();
            if (saniye == 0)
            {
                dakika--;
                labeldk.Text = dakika.ToString();
                saniye = 60;
               
                if(dakika==0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Zaman aşımına uğradınız");
                    this.Hide();
                    sepetim.Show();
                }

            }
        }
    }
}
