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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고1");
                textBox1.Focus(); goto Nagayo;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고2");
                textBox2.Focus(); goto Nagayo;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고3");
                textBox3.Focus(); goto Nagayo;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고4");
                textBox4.Focus(); goto Nagayo;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고5");
                textBox5.Focus(); goto Nagayo;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고6");
                textBox6.Focus(); goto Nagayo;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고7");
                textBox7.Focus(); goto Nagayo;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고8");
                textBox8.Focus(); goto Nagayo;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("점수를 입력하세요^^", "경고9");
                textBox9.Focus(); goto Nagayo;
            }

            int[] ijumsu = new int[9];
            string[] sHakjum = new string[9];

            ijumsu[0] = int.Parse(textBox1.Text);
            ijumsu[1] = int.Parse(textBox2.Text);
            ijumsu[2] = int.Parse(textBox3.Text);
            ijumsu[3] = int.Parse(textBox4.Text);
            ijumsu[4] = int.Parse(textBox5.Text);
            ijumsu[5] = int.Parse(textBox6.Text);
            ijumsu[6] = int.Parse(textBox7.Text);
            ijumsu[7] = int.Parse(textBox8.Text);
            ijumsu[8] = int.Parse(textBox9.Text);

            for (int j = 0; j < 9; j++)
            {
                if (ijumsu[j] > 100 || ijumsu[j] < 0)
                {
                    MessageBox.Show("0 ~ 100 사이의 점수를 입력하세요^^", "경고2");
                    goto Nagayo;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (ijumsu[i] >= 96)
                {
                    sHakjum[i] = "A+";
                }
                else if (ijumsu[i] >= 91)
                {
                    sHakjum[i] = "A0";
                }
                else if (ijumsu[i] >= 86)
                {
                    sHakjum[i] = "B+";
                }
                else if (ijumsu[i] >= 81)
                {
                    sHakjum[i] = "B0";
                }
                else if (ijumsu[i] >= 76)
                {
                    sHakjum[i] = "C+";
                }
                else if (ijumsu[i] >= 71)
                {
                    sHakjum[i] = "C0";
                }
                else if (ijumsu[i] >= 66)
                {
                    sHakjum[i] = "D+";
                }
                else if (ijumsu[i] >= 61)
                {
                    sHakjum[i] = "D0";
                }
                else
                {
                    sHakjum[i] = "F";
                }
            }

            textBox10.Text = sHakjum[0];
            textBox11.Text = sHakjum[1];
            textBox12.Text = sHakjum[2];
            textBox13.Text = sHakjum[3];
            textBox14.Text = sHakjum[4];
            textBox15.Text = sHakjum[5];
            textBox16.Text = sHakjum[6];
            textBox17.Text = sHakjum[7];
            textBox18.Text = sHakjum[8];

        Nagayo:; 
        }
    }
}
