using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9주차_학점계산과판단문_신윤섭
{
    public partial class Form4 : Form
    {
        public TextBox[] txtInput,txtOutput;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 9; i++)
            {
                if(txtInput[i].Text == "")
                {
                    MessageBox.Show("점수를 입력하세요^^", "경고1");
                    txtInput[i].Focus(); 
                    goto Nagayo;
                }
            }

            int[] ijumsu = new int[9];
            string[] sHakjum = new string[9];

            for (int i = 0; i < 9; i++)
            {
                ijumsu[i] = int.Parse(txtInput[i].Text);
            }

            for (int j = 0; j < 9; j++)
            {
                if (ijumsu[j] > 100 || ijumsu[j] < 0)
                {
                    MessageBox.Show("0 ~ 100 사이의 점수를 입력하세요^^", "경고2");
                    txtInput[j].Focus();
                    txtInput[j].SelectionStart = 0;
                    txtInput[j].SelectionLength = textBox1.TextLength; 
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
            for (int i = 0; i < 9; i++)
            {
                txtOutput[i].Text = sHakjum[i];
            }

        Nagayo:;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtInput = new TextBox[] { textBox1, textBox2 , textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            txtOutput = new TextBox[] { textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18 };
        }
    }
}
