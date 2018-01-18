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
    public partial class YeniKayıt : Form
    {
        public YeniKayıt()
        {
            InitializeComponent();
        }

        bool IsNumeric(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

        private void buttonUyeOl_Click(object sender, EventArgs e)
        {
            String connectionString = "data source=DESKTOP-RUVJ75R;initial catalog=PRODUCTS;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {         
               if(IsNumeric(textBoxparolaGir.Text)==true)
                {
                    SqlCommand commandekleme = new SqlCommand();
                    commandekleme.CommandType = CommandType.Text;
                    commandekleme.CommandText = "insert into USERS(UserNames, Passwords) values ('" + textBoxAdGir.Text + "'," + Convert.ToInt32(textBoxparolaGir.Text) + ")";
                    commandekleme.Connection = connection;
                    if ((textBoxparolaGir.Text == textBoxParolaTekrarGir.Text) && (checkBoxSozlesme.Checked))
                    {
                        connection.Open();
                        commandekleme.ExecuteNonQuery();
                        MessageBox.Show("Aramıza hoşgeldiniz!");
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Eksik ya da hatalı bilgi girdiniz!");
                    }
                }
               else
                {
                    MessageBox.Show("Eksik ya da hatalı bilgi girdiniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu Kullanıcı Adı Zaten Var!");
            }
        }

        private void YeniKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
