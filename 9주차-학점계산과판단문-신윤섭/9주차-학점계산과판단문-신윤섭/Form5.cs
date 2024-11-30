using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9주차_학점계산과판단문_신윤섭
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            if (textBox1.Text == "")
            {
                MessageBox.Show("별점을 입력하세요!", "[경고1]");
                textBox1.Focus();
                goto Exit;
            }
            else if (textBox1.Text == "★") {
                textBox2.Text = "매우 불만족입니다!";
            }
            else if (textBox1.Text == "★★")
            {
                textBox2.Text = "불만족입니다!";
            }
            else if (textBox1.Text == "★★★")
            {
                textBox2.Text = "보통입니다.";
            }
            else if (textBox1.Text == "★★★★")
            {
                textBox2.Text = "만족합니다!";
            }
            else if (textBox1.Text == "★★★★★")
            {
                textBox2.Text = "매우 만족합니다!";
            }
            else
            {
                MessageBox.Show("1~5개 별점을 입력하세요!", "[경고2]");
            }
            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        Exit:;
        }
    }
}
