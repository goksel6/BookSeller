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
    public partial class ArananUrun : Form
    {
        public İncele inceleForm;
        public Form1 anasayfa;
        public ArananUrun(Form1 a)
        {
            InitializeComponent();
            anasayfa = a;
        }
        public String arananurunKontrolDiger;
        private void ArananUrun_Load(object sender, EventArgs e)
        {
            String connectionString = "data source=DESKTOP-RUVJ75R;initial catalog=PRODUCTS;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand commandara = new SqlCommand();
            commandara.CommandType = CommandType.Text;
            commandara.CommandText = "Select Book_name, Author_name,Publisher_name,Price,Country From BOOK, AUTHORS,PUBLISHER where (Author_name LIKE '%' + @aranan + '%' and AUTHORS.Author_id=BOOK.BAuthor_id and PBook_id=Book_id) or (Book_name LIKE '%' + @aranan + '%' and BOOK.BAuthor_id=AUTHORS.Author_id and PBook_id=Book_id) or (AUTHORS.Country LIKE '%' + @aranan + '%' and AUTHORS.Author_id=BOOK.BAuthor_id and PBook_id=Book_id) or(Publisher_name LIKE '%' + @aranan + '%' and AUTHORS.Author_id=BOOK.BAuthor_id and PBook_id=Book_id)";
            commandara.Connection = connection;
            commandara.Parameters.AddWithValue("@aranan", anasayfa.textBoxUrunArama.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(commandara);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(table);
                DataGridViewArananUrun.DataSource = table;
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Başarısız.");
            }         
        }


        private void DataGridViewArananUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            BilgiBlogu birBlok = new BilgiBlogu();
            DialogResult dialogResult = MessageBox.Show("Bu ürün detayları gösterilmeksizin sepete eklensin mi?", "Karar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            String SecilmisKitapAdi = DataGridViewArananUrun.Rows[e.RowIndex].Cells[0].Value.ToString();
            String SecilmisKitapYayınevi = DataGridViewArananUrun.Rows[e.RowIndex].Cells[2].Value.ToString();
            String SecilmisKitapYazarAdi= DataGridViewArananUrun.Rows[e.RowIndex].Cells[1].Value.ToString();
            int SecilmisKitapFiyat= Convert.ToInt32(DataGridViewArananUrun.Rows[e.RowIndex].Cells[3].Value);
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
        }
    }
}
