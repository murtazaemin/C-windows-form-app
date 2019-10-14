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
    public partial class FibonacciForm : Form
    {
        public FibonacciForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(Convert.ToString(fibonacci(sayi)));
            }
            else
                MessageBox.Show("HATA : bir sayı girin...");
        }

        private int fibonacci(int i)
        {
            if (i == 1)
                return 0;
            else if (i == 2)
                return 1;
            else
                return fibonacci(i - 1) + fibonacci(i - 2);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        
    }
}
