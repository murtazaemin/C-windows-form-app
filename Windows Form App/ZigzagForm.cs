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
    public partial class ZigzagForm : Form
    {
        public ZigzagForm()
        {
            InitializeComponent();

            for (int i = 1; i <= 200; i++) {
                if (i % 15 == 0)
                {
                    if(i < 100)
                    {
                        sayilar.Text += string.Format("{0,8}", "zigzag") ;
                    }
                    else
                        sayilar.Text += string.Format("{0,8}", "zagzig") ;
                }
                else
                {
                    if (i % 3 == 0)
                        sayilar.Text += string.Format("{0,10}", "zig") ;
                    else if (i % 5 == 0)
                        sayilar.Text += string.Format("{0,10}","zag") ;
                    else
                        sayilar.Text +=string.Format("{0,10}",Convert.ToString(i));
                }

               

                if (i % 10 == 0) {
                    sayilar.Text += "\n";
                }
            
            }
           
        }
    }
}
