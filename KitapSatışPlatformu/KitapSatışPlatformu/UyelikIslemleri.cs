using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapSatışPlatformu
{
   
    public partial class UyelikIslemleri : Form
    {
        Form1 Anasayfa;
        public UyelikIslemleri(Form1 a)
        {
            InitializeComponent();
            Anasayfa = a;
        }
        public String arananUrunKontrol;
        private void buttonUyeOlmakIstiyorum_Click(object sender, EventArgs e)
        {
            YeniKayıt yeniKayit = new YeniKayıt();
            yeniKayit.Show();
        }

        private void buttonSifremiUnuttum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İnanın yapabileceğimiz bir şey yok!");
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            //ArananUrun arananurun = new ArananUrun();
            //arananUrunKontrol = textBoxUrunArama.Text;
            //arananurun.arananurunKontrolDiger = arananUrunKontrol;
            //arananurun.Show();
        }

        private void UyelikIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            textBoxKullanıcıAdı.Show();
            if (textBoxKullanıcıAdı.Text == "") 
            {
                errorProvider1.SetError(textBoxKullanıcıAdı, "Kullanıcı Adınızı Yazınız");
            }
            if (maskedTextBoxSifre.Text == "")
            {
                errorProvider1.SetError(maskedTextBoxSifre, "Şifrenizi Yazınız");
            }
            if(textBoxKullanıcıAdı.Text!="" && maskedTextBoxSifre.Text != "")
            {      
                        
                int aysunundegiskeni = Convert.ToInt32(maskedTextBoxSifre.Text);
                PRODUCTSEntities db = new PRODUCTSEntities();
                //foreach (var item in db.USERS)
                {
                    if (db.USERS.Any(kisi => kisi.UserNames == textBoxKullanıcıAdı.Text && kisi.Passwords == aysunundegiskeni))
                    {
                        MessageBox.Show("Hoşgeldiniz Sn." + textBoxKullanıcıAdı.Text);
                        Anasayfa.textBoxSnMusteri.Text = textBoxKullanıcıAdı.Text;

                    }
                    else
                    {
                        MessageBox.Show("Bu Bilgilere Sahip Bir Kullanıcı Bulunmamakta");
                    }
                }
            }
            this.Hide();

            Anasayfa.buttonUyeGirisi.Text = "ÇIKIŞ YAP";
        }
    }
}
