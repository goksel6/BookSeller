using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace KitapSatışPlatformu
{
    public partial class RusEdebiyatı : Form
    {
        Form1 anasayfa;
        İncele inceleForm;
        public RusEdebiyatı(Form1 a)
        {
            anasayfa = a;
            InitializeComponent();
        }
        
        private void RusEdebiyatı_Load(object sender, EventArgs e)
        {
            String connectionString = "data source=DESKTOP-RUVJ75R;initial catalog=PRODUCTS;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand commandFransaKitap = new SqlCommand();
            commandFransaKitap.CommandType = CommandType.Text;
            commandFransaKitap.CommandText = "SELECT Book_name as KİTAP, Author_name as YAZAR, Publisher_name as YAYINEVİ,  Price as FİYAT FROM PUBLISHER,BOOK, AUTHORS WHERE Country='Rusya' AND Author_id=BAuthor_id AND PBook_id=Book_id";
            commandFransaKitap.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter(commandFransaKitap);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(table);
                dataGridViewRusya.DataSource = table;
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Başarısız.");
            }
        }

        private void dataGridViewRusya_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BilgiBlogu birBlok = new BilgiBlogu();
            DialogResult dialogResult = MessageBox.Show("Bu ürün detayları gösterilmeksizin sepete eklensin mi?", "Karar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            String SecilmisKitapAdi = dataGridViewRusya.Rows[e.RowIndex].Cells[0].Value.ToString();
            String SecilmisKitapYayınevi = dataGridViewRusya.Rows[e.RowIndex].Cells[2].Value.ToString();
            String SecilmisKitapYazarAdi = dataGridViewRusya.Rows[e.RowIndex].Cells[1].Value.ToString();
            int SecilmisKitapFiyat = Convert.ToInt32(dataGridViewRusya.Rows[e.RowIndex].Cells[3].Value);
            birBlok.kitapAdi = SecilmisKitapAdi;
            birBlok.yayınevi = SecilmisKitapYayınevi;
            birBlok.fiyati = SecilmisKitapFiyat;
            birBlok.yazarAdi = SecilmisKitapYazarAdi;

            if (dialogResult == DialogResult.Yes)
            {
                anasayfa.sepetListesi.Add(birBlok);

            }
            else if (dialogResult == DialogResult.No)
            {
                using (var db = new PRODUCTSEntities())
                {

                    var result = from k in db.BOOK
                                 where k.Book_name == SecilmisKitapAdi
                                 select new
                                 {
                                     k.Book_id

                                 };
                    foreach (var item in result)
                    {
                        inceleForm = new İncele(item.Book_id.ToString(), SecilmisKitapYayınevi);
                        inceleForm.Show();
                    }
                }
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }
    }
}
