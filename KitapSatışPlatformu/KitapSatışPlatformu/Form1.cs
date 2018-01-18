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
    public partial class Form1 : Form
    {
        ArananUrun arananurun;
        Sepet sepetim;
        Form2 ingiliz;
        TurkEdebiyatı türk;
        FransızEdebiyatı fransız;
        RusEdebiyatı Rus;
        form2017 F2017;
        Form2016 F2016;
        Form2013 F2013;
        Form2014 F2014;
        form2015 F2015;
        OkumaListeleri OkumaListe;
        UyelikIslemleri UyeGirisigoster;
        
        public Form1()
        {
            InitializeComponent();
          
        }
        public  List<BilgiBlogu> sepetListesi = new List<BilgiBlogu>();
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
       
        private void buttonUyeGirisi_Click(object sender, EventArgs e)
        {
            if (buttonUyeGirisi.Text == "ÜYE GİRİŞİ")
            {
                UyeGirisigoster = new UyelikIslemleri(this);
                UyeGirisigoster.Show();
            }
            if (buttonUyeGirisi.Text == "ÇIKIŞ YAP")
            {
                textBoxSnMusteri.Text = "Sn. Müşteri";
                buttonUyeGirisi.Text = "ÜYE GİRİŞİ";
            }


        }

        private void buttonTelifHakki_Click(object sender, EventArgs e)
        {
            TelifHaklari TelifHakkigoster = new TelifHaklari();
            TelifHakkigoster.Show();
        }

        

        private void ingilizEdebiyatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ingiliz = new Form2(this);
            ingiliz.Show();          
        }

        private void fransızEdebiyatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
             fransız = new FransızEdebiyatı(this);
            fransız.Show();
        }

        private void rusEdebiyatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rus = new RusEdebiyatı(this);
            Rus.Show();
        }

        private void türkEdebiyatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
             türk = new TurkEdebiyatı(this);
            türk.Show();
        }

        public String arananUrunKontrol;
      

        private void buttonAra_Click(object sender, EventArgs e)
        {
            arananurun = new ArananUrun(this);
            arananUrunKontrol = textBoxUrunArama.Text;
            arananurun.arananurunKontrolDiger = arananUrunKontrol;
            arananurun.Show();
        }

        private void buttonSepetim_Click(object sender, EventArgs e)
        {
            sepetim = new Sepet(this);
            sepetim.Show();
        }

       

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            F2017 = new form2017(this);
            F2017.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            F2016 = new Form2016(this);
            F2016.Show();

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            F2015 = new form2015(this);
            F2015.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            F2014 = new Form2014(this);
            F2014.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            F2013 = new Form2013(this);
            F2013.Show();
        
        }

        private void felsefeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkumaListe = new OkumaListeleri(this, felsefeToolStripMenuItem.Text);
            OkumaListe.Show();
        }

        private void tarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkumaListe = new OkumaListeleri(this, tarihToolStripMenuItem.Text);
            OkumaListe.Show();
        }

     

        private void biyografiotobiyografiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkumaListe = new OkumaListeleri(this, biyografiotobiyografiToolStripMenuItem.Text);
            OkumaListe.Show();
        }

        private void şiirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkumaListe = new OkumaListeleri(this, şiirToolStripMenuItem.Text);
            OkumaListe.Show();
        }

        private void tiyatroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkumaListe = new OkumaListeleri(this, tiyatroToolStripMenuItem.Text);
            OkumaListe.Show();
        }

        private void pictureBoxhk3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docviewer.yandex.com.tr/view/550188097/?*=ZSDD29SxhbsuvvjFaW1fp04JKJh7InVybCI6InlhLWRpc2stcHVibGljOi8vdERTTnMyVG0zYVRIZGFDa29YeXBseTNKUXRLbFZqdkdVOWR4K2t4YmpoYz06L21lcml0b2tyYXNpL1TDvHJrw6dlIFtlUHViXS9EZXJlY2VsZW5kaXJpbG1pxZ8gS2l0YXBsYXIvQWxiZXJ0IENhbXVzIC0gWWFiYW5jxLEuZXB1YiIsInRpdGxlIjoiQWxiZXJ0IENhbXVzIC0gWWFiYW5jxLEuZXB1YiIsInVpZCI6IjU1MDE4ODA5NyIsInl1IjoiODM3NzUxNzg0MTUxMjQ4NTY4OSIsIm5vaWZyYW1lIjpmYWxzZSwidHMiOjE1MTQwNDYxMzc1MTF9");
        }

        private void pictureBoxhk1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docviewer.yandex.com.tr/view/550188097/?*=SiATfyuRMr1keC1By7cxpavmO6J7InVybCI6InlhLWRpc2stcHVibGljOi8vdERTTnMyVG0zYVRIZGFDa29YeXBseTNKUXRLbFZqdkdVOWR4K2t4YmpoYz06L21lcml0b2tyYXNpL1TDvHJrw6dlIFtlUHViXS9EZXJlY2VsZW5kaXJpbG1pxZ8gS2l0YXBsYXIvQWxleGFuZHJlIER1bWFzIC0gw5zDpyBTaWxhaMWfw7ZyLmVwdWIiLCJ0aXRsZSI6IkFsZXhhbmRyZSBEdW1hcyAtIMOcw6cgU2lsYWjFn8O2ci5lcHViIiwidWlkIjoiNTUwMTg4MDk3IiwieXUiOiI4Mzc3NTE3ODQxNTEyNDg1Njg5Iiwibm9pZnJhbWUiOmZhbHNlLCJ0cyI6MTUxNDA0NzE0NDQ4N30%3D");
        }

        private void pictureBoxik2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docviewer.yandex.com.tr/view/550188097/?*=%2Bvkz9zG4C6m8UiNuBJGhuEwKRWp7InVybCI6InlhLWRpc2stcHVibGljOi8vdERTTnMyVG0zYVRIZGFDa29YeXBseTNKUXRLbFZqdkdVOWR4K2t4YmpoYz06L21lcml0b2tyYXNpL1TDvHJrw6dlIFtlUHViXS9EZXJlY2VsZW5kaXJpbG1pxZ8gS2l0YXBsYXIvQW1pbiBNYWFsb3VmIC0gU2VtZXJrYW50LmVwdWIiLCJ0aXRsZSI6IkFtaW4gTWFhbG91ZiAtIFNlbWVya2FudC5lcHViIiwidWlkIjoiNTUwMTg4MDk3IiwieXUiOiI4Mzc3NTE3ODQxNTEyNDg1Njg5Iiwibm9pZnJhbWUiOmZhbHNlLCJ0cyI6MTUxNDA0NzI5MjQwOX0%3D");
        }

        private void pictureBoxhk2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docviewer.yandex.com.tr/view/550188097/?*=gABXrWGcXC%2FhQ45wvZI7%2FbPzeOp7InVybCI6InlhLWRpc2stcHVibGljOi8vdERTTnMyVG0zYVRIZGFDa29YeXBseTNKUXRLbFZqdkdVOWR4K2t4YmpoYz06L21lcml0b2tyYXNpL1TDvHJrw6dlIFtlUHViXS9EZXJlY2VsZW5kaXJpbG1pxZ8gS2l0YXBsYXIvRW1pbGUgWm9sYSAtIEdlcm1pbmFsKENhbikuZXB1YiIsInRpdGxlIjoiRW1pbGUgWm9sYSAtIEdlcm1pbmFsKENhbikuZXB1YiIsInVpZCI6IjU1MDE4ODA5NyIsInl1IjoiODM3NzUxNzg0MTUxMjQ4NTY4OSIsIm5vaWZyYW1lIjpmYWxzZSwidHMiOjE1MTQwNDc0NjU0Mjh9");
        }

        private void pictureBoxik3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docviewer.yandex.com.tr/view/550188097/?*=tQvAylY21EzhdGSBV3trYYXR7Pl7InVybCI6InlhLWRpc2stcHVibGljOi8vdERTTnMyVG0zYVRIZGFDa29YeXBseTNKUXRLbFZqdkdVOWR4K2t4YmpoYz06L21lcml0b2tyYXNpL1TDvHJrw6dlIFtlUHViXS9EZXJlY2VsZW5kaXJpbG1pxZ8gS2l0YXBsYXIvRnJhbnogS2Fma2EgLSBEw7Zuw7zFn8O8bSAoxLDFnyBCYW5rYXPEsSkuZXB1YiIsInRpdGxlIjoiRnJhbnogS2Fma2EgLSBEw7Zuw7zFn8O8bSAoxLDFnyBCYW5rYXPEsSkuZXB1YiIsInVpZCI6IjU1MDE4ODA5NyIsInl1IjoiODM3NzUxNzg0MTUxMjQ4NTY4OSIsIm5vaWZyYW1lIjpmYWxzZSwidHMiOjE1MTQwNDc2MDQ3ODJ9");
        }

        private void pictureBoxik1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docviewer.yandex.com.tr/view/550188097/?*=3G3lykfRrsUQOZCMK19qpAEj7AF7InVybCI6InlhLWRpc2stcHVibGljOi8vdERTTnMyVG0zYVRIZGFDa29YeXBseTNKUXRLbFZqdkdVOWR4K2t4YmpoYz06L21lcml0b2tyYXNpL1TDvHJrw6dlIFtlUHViXS9EZXJlY2VsZW5kaXJpbG1pxZ8gS2l0YXBsYXIvRnlvZG9yIE1paGFpbG92acOnIERvc3RveWV2c2tpIC0gS3VtYXJiYXouZXB1YiIsInRpdGxlIjoiRnlvZG9yIE1paGFpbG92acOnIERvc3RveWV2c2tpIC0gS3VtYXJiYXouZXB1YiIsInVpZCI6IjU1MDE4ODA5NyIsInl1IjoiODM3NzUxNzg0MTUxMjQ4NTY4OSIsIm5vaWZyYW1lIjpmYWxzZSwidHMiOjE1MTQwNDc3Nzk1MzZ9");
        }

        private void pictureBoxhk4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docviewer.yandex.com.tr/view/550188097/?*=5mub%2F5a1asPpU46LJL11b1L6m517InVybCI6InlhLWRpc2stcHVibGljOi8vdERTTnMyVG0zYVRIZGFDa29YeXBseTNKUXRLbFZqdkdVOWR4K2t4YmpoYz06L21lcml0b2tyYXNpL1TDvHJrw6dlIFtlUHViXS9EZXJlY2VsZW5kaXJpbG1pxZ8gS2l0YXBsYXIvR2VvcmdlIE9yd2VsbCAtIEFzcGlkaXN0cmEuZXB1YiIsInRpdGxlIjoiR2VvcmdlIE9yd2VsbCAtIEFzcGlkaXN0cmEuZXB1YiIsInVpZCI6IjU1MDE4ODA5NyIsInl1IjoiODM3NzUxNzg0MTUxMjQ4NTY4OSIsIm5vaWZyYW1lIjpmYWxzZSwidHMiOjE1MTQwNDc4ODYwMDd9");
        }

        private void nobelAlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nobelcs nobel = new Nobelcs();
            nobel.Show();
        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BizeUlaşın ulas = new BizeUlaşın();
            ulas.Show();
        }

        private void buttonGizlilik_Click(object sender, EventArgs e)
        {
            GizlilikPolitikasi gizlilikPol = new GizlilikPolitikasi();
            gizlilikPol.Show();
        }

        private void buttonSatisSöz_Click(object sender, EventArgs e)
        {
            SatısSozles satıl = new SatısSozles();
            satıl.Show();
        }

        private void buttonUyelikSoz_Click(object sender, EventArgs e)
        {
            UyeSoz us = new UyeSoz();
            us.Show();
        }

        private void buttonHakkimizda_Click(object sender, EventArgs e)
        {
            Hakkımızda h = new Hakkımızda();
            h.Show();
        }

        private void buttonİletisim_Click(object sender, EventArgs e)
        {
            BizeUlaşın ulas = new BizeUlaşın();
            ulas.Show();
        }

        private void bİZKİMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkımızda h = new Hakkımızda();
            h.Show();
        }

        private void kararsızOkurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.idefix.com/Kararsiz-Okur");
        }

        private void pictureBoxHY1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://canyayinlari.com/");
        }

        private void pictureBoxHY2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ykykultur.com.tr/");
        }

        private void kARGOTAKİPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarayıcı tr = new Tarayıcı();
            tr.Show();
        }

        private void buttonEkitap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yadi.sk/d/42mr9aNm3L6KwD/meritokrasi/T%C3%BCrk%C3%A7e%20%5BePub%5D/Derecelendirilmi%C5%9F%20Kitaplar");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.kafkaokur.com/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
       
            System.Diagnostics.Process.Start("http://www.prefix.com.tr/");
        }
    }
}
