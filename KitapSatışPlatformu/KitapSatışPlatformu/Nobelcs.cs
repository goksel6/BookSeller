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
    public partial class Nobelcs : Form
    {
        public Nobelcs()
        {
            InitializeComponent();
        }

        private void buttonYıllar_Click(object sender, EventArgs e)
        {
            if (buttonYıllar.Text=="2017")
            {
                buttonYıllar.Text = "2016";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[0];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[0];
                linkLabelYazarAra.Text = "Kazuo Ishiguro";
                labelNobelKitap.Text ="Günden Kalanlar";
                label2.Text = "2017";
            }
            else if (buttonYıllar.Text == "2016")
            {
                buttonYıllar.Text = "2015";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[1];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[1];
                linkLabelYazarAra.Text = "Bob Dylan";
                labelNobelKitap.Text = "Plaklar";
                label2.Text = "2016";
            }
            else if (buttonYıllar.Text == "2015")
            {
                buttonYıllar.Text = "2014";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[2];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[2];
                linkLabelYazarAra.Text = "Svetlana Aleksiyavic";
                labelNobelKitap.Text = "Kadın Yok Savaşın Yüzünde";
                label2.Text = "2015";
            }
            else if (buttonYıllar.Text == "2014")
            {
                buttonYıllar.Text = "2013";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[3];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[3];
                linkLabelYazarAra.Text = "Patrick Madiano";
                labelNobelKitap.Text = "Dora Bruder";
                label2.Text = "2014";
            }
            else if (buttonYıllar.Text == "2013")
            {
                buttonYıllar.Text = "2012";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[4];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[4];
                linkLabelYazarAra.Text = "Alice Munro";
                labelNobelKitap.Text = "Nefret Arkadaşlık Flört Aşk Evlilik";
                label2.Text = "2013";
            }
            else if (buttonYıllar.Text == "2012")
            {
                buttonYıllar.Text = "2011";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[5];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[5];
                linkLabelYazarAra.Text = "Mo Yan";
                labelNobelKitap.Text = "Kızıl Darı Tarlaları";
                label2.Text = "2012";
            }
            else if (buttonYıllar.Text == "2011")
            {
                buttonYıllar.Text = "2017";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[6];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[6];
                linkLabelYazarAra.Text = "Tomas Transtromer";
                labelNobelKitap.Text = "Seçilmiş Şiirler";
                label2.Text = "2011";
            }
            else if (buttonYıllar.Text == "2010")
            {
                buttonYıllar.Text = "2016";
                pictureBoxNobelKitap.Image = ımageListkitap.Images[0];
                pictureBoxNobelYazar.Image = ımageListyazar.Images[0];
                linkLabelYazarAra.Text = "Kazuo Ishiguro";
                labelNobelKitap.Text = "Günden Kalanlar";
                label2.Text = "2010";
            }
        }

        private void linkLabelYazarAra_Click(object sender, EventArgs e)
        {
            if (linkLabelYazarAra.Text == "Kazuo Ishiguro")
            {
                System.Diagnostics.Process.Start("http://www.wikizero.org/index.php?q=aHR0cHM6Ly90ci53aWtpcGVkaWEub3JnL3dpa2kvS2F6dW9fSXNoaWd1cm8");
            }
            else if (linkLabelYazarAra.Text == "Bob Dylan")
            {
                System.Diagnostics.Process.Start("http://www.wikizero.org/index.php?q=aHR0cHM6Ly90ci53aWtpcGVkaWEub3JnL3dpa2kvQm9iX0R5bGFu");
            }
            else if (linkLabelYazarAra.Text == "Svetlana Aleksiyavic")
            {
                System.Diagnostics.Process.Start("http://www.wikizero.org/index.php?q=aHR0cHM6Ly90ci53aWtpcGVkaWEub3JnL3dpa2kvU3ZldGxhbmFfQWxla3NpeWV2aSVDMyVBNw");
            }
            else if (linkLabelYazarAra.Text == "Patrick Madiano")
            {
                System.Diagnostics.Process.Start("http://www.wikizero.org/index.php?q=aHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvUGF0cmlja19Nb2RpYW5v");
            }
            else if (linkLabelYazarAra.Text == "Alice Munro")
            {
                System.Diagnostics.Process.Start("http://www.wikizero.org/index.php?q=aHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvQWxpY2VfTXVucm8");
            }
            else if (linkLabelYazarAra.Text == "Mo Yan")
            {
                System.Diagnostics.Process.Start("http://www.wikizero.org/index.php?q=aHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvTW9fWWFu");
            }
            else if (linkLabelYazarAra.Text == "Tomas Transtromer")
            {
                System.Diagnostics.Process.Start("http://www.wikizero.org/index.php?q=aHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvVG9tYXNfVHJhbnN0ciVDMyVCNm1lcg");
            }


        }
    }
}
