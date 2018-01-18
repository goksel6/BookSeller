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
    public partial class BizeUlaşın : Form
    {
        public BizeUlaşın()
        {
            InitializeComponent();
        }
        private void childForm(Form ChildForm)
        {
            bool durum = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Text == ChildForm.Text)
                {
                    durum = true;
                    ChildForm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                ChildForm.MdiParent = this;
                ChildForm.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            childForm(new İletişimBilgilerimiz());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            childForm(new Şubelerimiz());
        }

       
    }
}
