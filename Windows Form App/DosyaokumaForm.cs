using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace teknokaucuk
{
    public partial class DosyaokumaForm : Form
    {
        public DosyaokumaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK) {
                string[] lines =  File.ReadAllLines(file.FileName);
                //string[] c;
                //string a = "asdsad\tasdsa  qwe";
                List<double> list = new List<double>();
                for (int i = 0; i < lines.Length; i++)
                {
                    foreach (string s in lines[i].ToString().Split(new[] { "\n","\f","\v","\t"," " }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        listBox1.Items.Add(s);
                        list.Add(Convert.ToDouble(s));
                    }
                     
                }
                
                list.Sort();
                list.Reverse();
                foreach (double sirala in list)
                   listBox2.Items.Add(sirala);
            }
        }

        



        
    }
}
