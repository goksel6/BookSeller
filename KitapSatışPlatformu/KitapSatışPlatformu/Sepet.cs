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
    public partial class Sepet : Form
    {
        public  String secilenSirket;
        SparisÖzeti siparisÖzetim;
        public Form1 anasayfa;
        public Sepet(Form1 a)
        {
            InitializeComponent();
            anasayfa = a;
           
        }
        UyelikIslemleri uyeGiris;
        double toplam = 0;
        int toplamUrunSayisi = 0;
        bool flag = true;
        private void Sepet_Load(object sender, EventArgs e)
        {
            
            int deger = 0;
         
            textBoxSnMusteri.Text = anasayfa.textBoxSnMusteri.Text;
            for (int i = 0; i < anasayfa.sepetListesi.Count; i++)
            {
                checkedListBoxSepet.Items.Add(anasayfa.sepetListesi[i]);

                toplam += anasayfa.sepetListesi[i].fiyati;
                if (progressBar1.Value < 100 && flag==true)
                {
                    deger += anasayfa.sepetListesi[i].fiyati;             
                    if (deger<100)
                    {
                        progressBar1.Value += anasayfa.sepetListesi[i].fiyati;
                    }
                    else 
                    {
                        progressBar1.Value = 100;
                        textBoxKargobedava.Text = "Kargonuz Bizden";                     
                        flag = false;
                    }
                    
                }
                       
            }
            textBoxToplamTutar.Text = toplam.ToString();
            toplamUrunSayisi = checkedListBoxSepet.Items.Count;
            textBoxToplamUrun.Text = toplamUrunSayisi.ToString();
        }

        private void buttonSiparisTamamla_Click(object sender, EventArgs e)
        {

            if (textBoxSnMusteri.Text == "Sn. Müşteri")
            {
                DialogResult dialogResult = MessageBox.Show("Siparişinizi tamamlamak için giriş yapınız", "SİZİ TANIMIYORUZ", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.OK)
                {
                    uyeGiris = new UyelikIslemleri(anasayfa);
                    this.Hide();
                    uyeGiris.Show();
                }

            }
            else          
            {

                if (flag == true)
                {
                    if (radioButtonYurtici.Checked)
                    {
                        toplam = Toplama(toplam, 12.50);
                        textBoxToplamTutar.Text = toplam.ToString();
                        secilenSirket = "Yurtiçi Kargo";
                    }
                    else if (radioButtonMng.Checked)
                    {                       
                        toplam = Toplama(toplam, 8.25);
                        textBoxToplamTutar.Text = toplam.ToString();
                        secilenSirket = "MNG Kargo";
                    }
                    else if (radioButtonPtt.Checked)
                    {                       
                        toplam = Toplama(toplam, 5.75);
                        textBoxToplamTutar.Text = toplam.ToString();
                        secilenSirket = "PTT Kargo";
                    }
                    else if (radioButtonAras.Checked)
                    {                       
                        toplam = Toplama(toplam, 6.50);
                        textBoxToplamTutar.Text = toplam.ToString();
                        secilenSirket = "Aras Kargo";
                    }

                    //paket ücretleri
                    if (radioButton1.Checked)
                    {
                        toplam = Toplama(toplam, 3);
                        textBoxToplamTutar.Text = toplam.ToString();
                    }
                    else if (radioButton2.Checked)
                    {
                        toplam = Toplama(toplam, 5);
                        textBoxToplamTutar.Text = toplam.ToString();
                    }
                    else if (radioButton3.Checked)
                    {
                        toplam = Toplama(toplam, 2);
                        textBoxToplamTutar.Text = toplam.ToString();
                    }
                    else if (radioButton4.Checked)
                    {
                        toplam = Toplama(toplam, 4);
                        textBoxToplamTutar.Text = toplam.ToString();
                    }
                }
                if (anasayfa.sepetListesi.Count == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Anasayfaya dönmek için OK butonuna basınız", "SEPETİNİZ BOŞ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                      
                        this.Hide();
                        anasayfa.Show();
                    }
                }
                else
                {
                   siparisÖzetim = new SparisÖzeti(this);
                    this.Hide();
                    siparisÖzetim.Show();
                }
            }
        }

        public double Toplama(double toplam, double ekDeger)
        {
            return (toplam + ekDeger);
        }
        
        private void buttonSil_Click(object sender, EventArgs e)
        {
            int sayac = checkedListBoxSepet.CheckedItems.Count;
            int x;
            for (int i = 0; i < checkedListBoxSepet.CheckedItems.Count; i++)
            {
                toplam -= ((BilgiBlogu)checkedListBoxSepet.CheckedItems[i]).fiyati;
                toplamUrunSayisi--;

                x = progressBar1.Value;
               
                    x -= ((BilgiBlogu)checkedListBoxSepet.CheckedItems[i]).fiyati;
                    if (x<0)
                    {
                        progressBar1.Value = 0;
                    }
                    else
                    {
                        progressBar1.Value -= ((BilgiBlogu)checkedListBoxSepet.CheckedItems[i]).fiyati;
                    }

                if (textBoxKargobedava.Text == "Kargonuz Bizden" && toplam<100)
                {
                    textBoxKargobedava.Text = "Artık Sizden...";

                }
                
                            
                anasayfa.sepetListesi.Remove((BilgiBlogu)checkedListBoxSepet.CheckedItems[i]);
                
            }
            for (int i = (sayac-1); i>=0; i--)
            {
               checkedListBoxSepet.Items.Remove(checkedListBoxSepet.CheckedItems[i]);

            }

            textBoxToplamTutar.Text = toplam.ToString();
            textBoxToplamUrun.Text = toplamUrunSayisi.ToString();

        }

        //ListItem item = new ListItem();
        //item.Text = "Deneme 1";
        //item.Value = "1";
        //// döngü veya manual
        //CheckBoxList1.Items.Add(item);

    }

    }

