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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ijumsu;
            string sHakjum;

            if (textBox1.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고1");
                goto Nagayo;
            }
            ijumsu = int.Parse(textBox1.Text);

            if (ijumsu > 100 || ijumsu < 0)
            {
                MessageBox.Show("0 ~ 100 사이의 점수를 입력하세요^^", "경고2");
                goto Nagayo;
            }

            switch (ijumsu / 5)
            {
                case 20:
                case 19:
                    sHakjum = "A+";
                    break;
                case 18:
                    sHakjum = "A0";
                    break;
                case 17:
                    sHakjum = "B+";
                    break;
                case 16:
                    sHakjum = "B0";
                    break;
                case 15:
                    sHakjum = "C+";
                    break;
                case 14:
                    sHakjum = "C0";
                    break;
                case 13:
                    sHakjum = "D+";
                    break;
                case 12:
                    sHakjum = "D0";
                    break;
                default:
                    sHakjum = "F";
                    break;


            }

            textBox2.Text = sHakjum;

        Nagayo: textBox1.Focus();
            {
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.TextLength;
            }
        }
    }
}
