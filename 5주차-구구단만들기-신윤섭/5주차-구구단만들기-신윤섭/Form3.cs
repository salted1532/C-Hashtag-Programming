using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5주차_구구단만들기_신윤섭
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //while 문
            uint uDan = 1;//uint = unsigned int 양수만
            uint uDuisutja = 1;
            uint i =0;

            textBox1.Text = "";

            while (uDan < 10)
            {
                while (uDuisutja < 10)
                {
                    while (i < 3)
                    {
                        textBox1.Text += (uDan + i) + "X" + uDuisutja + "=" + ((uDan + i) * uDuisutja) + "\t\n";
                        i++;
                    }
                    uDuisutja++;
                    textBox1.Text += Environment.NewLine;
                    i = 0;
                }
                uDan += 3;
                textBox1.Text += Environment.NewLine;
                uDuisutja = 1;//중요
            }
        }
    }
}
