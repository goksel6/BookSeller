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
    public partial class Tarayıcı : Form
    {
        public Tarayıcı()
        {
            InitializeComponent();
        }

        private void Tarayıcı_Load(object sender, EventArgs e)
        {
       
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                webBrowser2.Navigate(textBox1.Text);
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void buttonİleri_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void buttonGit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                webBrowser2.Navigate(textBox1.Text);
            }
            

        }
    }
}
