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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            string sinput;

           sinput  = textBox1.Text;

            switch (sinput)
            {
                case "":
                    MessageBox.Show("별점을 입력하세요!", "[경고1]");
                    textBox1.Focus();
                    goto Exit;
                case "★" : 
                    textBox2.Text = "매우 불만족입니다!";
                    break;
                case "★★": 
                    textBox2.Text = "불만족입니다!";
                    break;
                case "★★★": 
                    textBox2.Text = "보통입니다.";
                    break;
                case "★★★★": 
                    textBox2.Text = "만족합니다!";
                    break;
                case "★★★★★": 
                    textBox2.Text = "매우 만족합니다!";
                    break;
                default :
                    MessageBox.Show("1~5개 별점을 입력하세요!", "[경고2]");
                    break;
            }
            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        Exit:;
        }
    }
}
