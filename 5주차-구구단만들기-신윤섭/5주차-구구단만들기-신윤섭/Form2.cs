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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int iDan = 1; iDan < 10; iDan += 3)
            {
                for (int num = 1; num < 10; num++)
                {
                    for(int next = 0; next < 3; next++)
                    {
                        textBox1.Text +=  (iDan + next) + "*" + num + "=";
                        textBox1.Text += ((iDan + next) * num) + "\t\n";
                        
                    }
                    textBox1.Text += Environment.NewLine;
                }
                textBox1.Text += Environment.NewLine;
            }
        }
    }
}
