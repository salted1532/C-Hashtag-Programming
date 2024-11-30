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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //do while 문
            uint uDan = 1;//uint = unsigned int 양수만
            uint uDuisutja = 1;
            uint i = 0;
            textBox1.Text = "";

            do
            {
                do
                {
                    do
                    {
                        textBox1.Text += (uDan + i) + "*" + uDuisutja + "=" + ((uDan + i) * uDuisutja) + "\t\n";
                        i++;
                    } while (i < 3);
                    uDuisutja++;
                    textBox1.Text += Environment.NewLine;
                    i = 0;
                } while (uDuisutja < 10);
                uDan += 3;
                textBox1.Text += Environment.NewLine;
                uDuisutja = 1;//중요
            } while (uDan < 10);
        }
    }
}
