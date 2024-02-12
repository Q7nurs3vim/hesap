using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiş_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAd.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (numCorba.Value > 0)
                {
                    hesap += numCorba.Value * 12;
                    txtBilgi.Text += String.Format("Çorba {0:C}", numCorba.Value * 12) + "\r\n";
                }

                txtBilgi.Text += "-----------------";
                txtBilgi.Text += String.Format("Toplam {0:C}", hesap);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi2.Text = "";
                txtBilgi2.Text += txtAd.Text + "\r\n";
                txtBilgi2.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (numCorba.Value > 0)
                {
                    hesap += numSalata.Value * 12;
                    txtBilgi2.Text += String.Format("Salata {0:C}", numSalata.Value * 12) + "\r\n";
                }

                txtBilgi2.Text += "-----------------";
                txtBilgi2.Text += String.Format("Toplam {0:C}", hesap);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi3.Text = "";
                txtBilgi3.Text += txtAd.Text + "\r\n";
                txtBilgi3.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (numAna.Value > 0)
                {
                    hesap += numAna.Value * 12;
                    txtBilgi3.Text += String.Format("Ana Yemek {0:C}", numAna.Value * 12) + "\r\n";
                }

                txtBilgi3.Text += "-----------------";
                txtBilgi3.Text += String.Format("Toplam {0:C}", hesap);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi4.Text = "";
                txtBilgi4.Text += txtAd.Text + "\r\n";
                txtBilgi4.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (numTatlı.Value > 0)
                {
                    hesap += numSalata.Value * 12;
                    txtBilgi4.Text += String.Format("Tatlı {0:C}", numTatlı.Value * 12) + "\r\n";
                }

                txtBilgi4.Text += "-----------------";
                txtBilgi4.Text += String.Format("Toplam {0:C}", hesap);
            }
               
        }
    }
    
}
