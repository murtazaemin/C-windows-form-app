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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ToplacarpForm toplacarp = new ToplacarpForm();

            toplacarp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZigzagForm zigzagform = new ZigzagForm();

            zigzagform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FibonacciForm fibonacciform = new FibonacciForm();

            fibonacciform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarpımtablosuForm carpımtablosuform = new CarpımtablosuForm();

            carpımtablosuform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DosyaokumaForm dosyaokumaform = new DosyaokumaForm();

            dosyaokumaform.Show();
        }
    }
}
