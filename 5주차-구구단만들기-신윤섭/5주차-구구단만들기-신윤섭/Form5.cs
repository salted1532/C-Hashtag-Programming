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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //while (true)문
            uint uDan = 1;//uint = unsigned int 양수만
            uint uDuisutja = 1;
            uint i = 0;
            textBox1.Text = "";

            while (true)
            {
                while (true)
                {
                    while(true)
                    {
                        textBox1.Text += (uDan + i) + "X" + uDuisutja + "=" + ((uDan+i) * uDuisutja) + "\t\n";
                        i++;
                        if(i == 3)
                        {
                            break;
                        }
                    }
                    i = 0;
                    uDuisutja++;
                    textBox1.Text += Environment.NewLine;
                    if (uDuisutja == 10)
                    {
                        break;
                    }
                }
                uDan += 3;
                textBox1.Text += Environment.NewLine;
                uDuisutja = 1;//중요
                if (uDan == 10)
                {
                    break;
                }
            }
        }
    }
}
