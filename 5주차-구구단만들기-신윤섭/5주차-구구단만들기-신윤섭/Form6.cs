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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //uint[] uGuGuDan = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            uint[] a = { 0, 1, 2 };
            //uint[] b = { 1, 4, 7 };
            uint[] uGuGuDan = new uint[30];
            uint[] b = new uint[10];
            b[0] = 1;

            textBox1.Text = "";

            for (uint i = 0; i < 30; i++)
            {
                uGuGuDan[i] = i + 1;
            }

            for (uint i = 1; i < 10; i++)
            {
                b[i] = b[i - 1] + 3;
            }

            foreach (uint uDan in b)
            {
                foreach (uint uDuisutja in uGuGuDan)
                {
                    foreach (uint i in a)
                    {
                        textBox1.Text += (uDan + i) + "*" + uDuisutja + "=" + ((uDan + i) * uDuisutja) + "\t\n";
                    }
                    textBox1.Text += Environment.NewLine;
                }
                textBox1.Text += Environment.NewLine;
            }
        }
    }
}
