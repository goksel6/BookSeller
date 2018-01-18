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
    public partial class İncele : Form
    {
        String incelenenKitID;
        String incelenenPubAdı;
        public İncele(String incelenenKitapID, String incelenenPublisherAdı)
        {
            InitializeComponent();
            incelenenKitID = incelenenKitapID;
            incelenenPubAdı = incelenenPublisherAdı;
        }

        private void İncele_Load(object sender, EventArgs e)
        {
            
            String connectionString = "data source=DESKTOP-RUVJ75R;initial catalog=PRODUCTS;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand commandFransaKitap = new SqlCommand();
            commandFransaKitap.CommandType = CommandType.Text;
            commandFransaKitap.CommandText = "SELECT * FROM PUBLISHER  WHERE pBook_id=@kitID AND Publisher_name=@pubAd ";
            commandFransaKitap.Connection = connection;
            commandFransaKitap.Parameters.AddWithValue("@kitID", incelenenKitID);
            commandFransaKitap.Parameters.AddWithValue("@pubAd", incelenenPubAdı);

            SqlDataAdapter adapter = new SqlDataAdapter(commandFransaKitap);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(table);
                dataGridViewincele.DataSource = table;
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Başarısız.");
            }
        }
    }
}
