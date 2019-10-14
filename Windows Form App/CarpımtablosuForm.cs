using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknokaucuk
{
    public partial class CarpımtablosuForm : Form
    {
        public CarpımtablosuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo1.Text = "";

            int sayi = Convert.ToInt32(textsayi1.Text);

            int sonuc;

            if (sayi >= 1 && sayi <= 15)
            {
                for (int i = 0; i <= sayi; i++)
                {
                    for (int j = 0; j <= sayi; j++)
                    {
                        if (i == 0 || j == 0)
                        {
                            sonuc = i + j;
                            if (sonuc >= 100)
                                tablo1.Text += string.Format("{0,5}", Convert.ToInt32(sonuc));
                            else if (sonuc >= 10)
                                tablo1.Text += string.Format("{0,6}", Convert.ToInt32(sonuc));
                            else
                                tablo1.Text += string.Format("{0,7}", Convert.ToInt32(sonuc));
                        }
                        else
                        {
                            sonuc = i * j;
                            if (sonuc >= 100)
                                tablo1.Text += string.Format("{0,5}", Convert.ToInt32(sonuc));
                            else if (sonuc >= 10)
                                tablo1.Text += string.Format("{0,6}", Convert.ToInt32(sonuc));
                            else
                                tablo1.Text += string.Format("{0,7}", Convert.ToInt32(sonuc));
                        }
                    }

                    tablo1.Text += "\n";

                }
            }
            else
                MessageBox.Show("1 ile 15 arasında bir sayı girin");
        }

        private void textsayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

       
    }
}
