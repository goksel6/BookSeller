using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KitapSatışPlatformu
{
    public partial class form2017 : Form
    {
        Form1 anasayfa;
     
        public form2017(Form1 a)
        {
            anasayfa = a;
            InitializeComponent();
        }

        private void form2017_Load(object sender, EventArgs e)
        {
            yukle();
        }
        void yukle()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            //xml dosyamızı okumak için bir reader oluşturuyoruz.
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"veri2017.xml", new XmlReaderSettings());
            //içeriği Dataset e aktarıyoruz.
            ds.ReadXml(xmlFile);
            //datagridviewin kaynağı olarak dataseti gösteriyoruz.
            dataGridView2017.DataSource = ds.Tables[0];          
            xmlFile.Close();
        }

        private void dataGridView2017_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BilgiBlogu birBlok = new BilgiBlogu();
            DialogResult dialogResult = MessageBox.Show("Bu ürün sepete eklensin mi?", "Karar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            String SecilmisKitapAdi = dataGridView2017.Rows[e.RowIndex].Cells[0].Value.ToString();
            String SecilmisKitapYayınevi = dataGridView2017.Rows[e.RowIndex].Cells[2].Value.ToString();
            String SecilmisKitapYazarAdi = dataGridView2017.Rows[e.RowIndex].Cells[1].Value.ToString();
            int SecilmisKitapFiyat = Convert.ToInt32(dataGridView2017.Rows[e.RowIndex].Cells[3].Value);
            birBlok.kitapAdi = SecilmisKitapAdi;
            birBlok.yayınevi = SecilmisKitapYayınevi;
            birBlok.fiyati = SecilmisKitapFiyat;
            birBlok.yazarAdi = SecilmisKitapYazarAdi;

            if (dialogResult == DialogResult.Yes)
            {
                anasayfa.sepetListesi.Add(birBlok);

            }
          
        }
    }
}
