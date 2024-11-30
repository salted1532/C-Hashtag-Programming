using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12주차_마우스로동작하는계산기만들기_신윤섭
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
            this.Width = 550;
            groupBox1.Text = "";
            groupBox2.Text = "";
            this.Text = "일반 계산기";
            일반ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void 공학계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            this.Width = 800;
            textBox1.Width = 750;
            label1.Text = "This Calculator is made By S.Y.S in Dept. Software Engineering of  Seoil University !";
            this.Text = "공학 계산기";
            공학계산기ToolStripMenuItem.Checked = true;
            일반ToolStripMenuItem.Checked = false;
        }
        private void 일반ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            this.Width = 550;
            textBox1.Width = 480;
            label1.Text = "By S.Y.S in Dept. Software Engineering of  Seoil University !";
            this.Text = "일반 계산기";
            일반ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;
        }
        private Form2 child_frm2;
        private Form3 child_frm3;
        private Form4 child_frm4;
        private void 개발자소개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child_frm2 = new Form2();
            child_frm2.Owner = this;
            child_frm2.Show();
            this.Hide();
        }
        private void 교수님에게하고픈말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child_frm3 = new Form3();
            child_frm3.Owner = this;
            child_frm3.Show();
            this.Hide();
        }
        private void 계산기사용법ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child_frm4 = new Form4();
            child_frm4.Owner = this;
            child_frm4.Show();
            this.Hide();
        }
        private void 개발환경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("운영 체제 : Windows 10\n 개발 도구 : Microsoft Visual Studio Community 2019" + "\n 개발 언어 : C #", "[ 개발 환경 ]");
        }
        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("마우스로 동작하는 계산기 1.0", "[ 버전 정보 ]");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (textBox1.Text != "") 
            {
                textBox1.Text += "0";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text += "000";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            // clear 버튼
            textBox1.Text = "";
            bJjeom_Flag = false;
            Stored_Sutja = 0;
            Stored_Younsanja = "";
        }
         
        private void button12_Click(object sender, EventArgs e)
        {
            // . 버튼
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            if (bJjeom_Flag == false)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "0";
                }
                textBox1.Text += ".";
                bJjeom_Flag = true;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            // ← 버튼
            if( textBox1.Text != "")
            {
                if (textBox1.Text.Substring(textBox1.TextLength - 1) == ".")
                {
                    bJjeom_Flag = false;
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                if( textBox1.Text == "0")
                {
                    textBox1.Text = "";
                }
            }
        }
        Boolean bJjeom_Flag = false;
        Double Stored_Sutja;
        String Stored_Younsanja = "";
        Boolean Clear_Flag = false; // true : 지우고 숫자표시
        private void button15_Click(object sender, EventArgs e)
        {
            // + 버튼
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            geasan();
            //첫번째 연사자 입력시
            Stored_Sutja = Double.Parse(textBox1.Text);
            Stored_Younsanja = "+";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            // - 버튼
            geasan();
            //첫번째 연사자 입력시
            Stored_Sutja = Double.Parse(textBox1.Text);
            Stored_Younsanja = "-";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            // × 버튼
            geasan();
            //첫번째 연사자 입력시
            Stored_Sutja = Double.Parse(textBox1.Text);
            Stored_Younsanja = "×";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            // ÷ 버튼
            geasan();
            //첫번째 연사자 입력시
            Stored_Sutja = Double.Parse(textBox1.Text);
            Stored_Younsanja = "÷";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            // = 버튼
            geasan();
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //1/X 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //X^2 버튼
            if (textBox1.Text != "")
            {
                //textBox1.Text = (double.Parse(textBox1.Text)* double.Parse(textBox1.Text)).ToString();
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //±버튼
            /*if(double.Parse(textBox1.Text) > 0)
            {
                textBox1.Text = (-double.Parse(textBox1.Text)).ToString();
            }
            else if (double.Parse(textBox1.Text) < 0)
            {
                textBox1.Text = (-double.Parse(textBox1.Text)).ToString();
            }*/
            if(textBox1.Text != "")
            {
                textBox1.Text = (-double.Parse(textBox1.Text)).ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //n! 버튼
            if (textBox1.Text == "")
            {
                textBox1.Text = "0과 양의 정수를 입력하세요";
                goto Exit;
            }
            else if (textBox1.Text == "0과 양의 정수를 입력하세요")
            {
                textBox1.Text = "0과 양의 정수를 입력하세요";
                goto Exit;
            }
            else if(textBox1.Text ==  "0.")
            {
                textBox1.Text = "1";
                goto Exit;
            } 
            else if (double.Parse(textBox1.Text) < 0)
            {
                textBox1.Text = "0과 양의 정수를 입력하세요";
                goto Exit;
            }
            else if(bJjeom_Flag == true)
            {
                textBox1.Text = "0과 양의 정수를 입력하세요!";
                goto Exit;
            }
            double dinput = double.Parse(textBox1.Text);
            double dResult = Factorial(dinput); // 재귀함수 사용
            /*double dResult = 1; //반복문 사용
            for(double j = dinput; j > 0; j--)
            {
                dResult = dResult * j;
            }*/
            textBox1.Text = dResult.ToString();
        Exit:;
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }
        public double Factorial (double dinput) //팩토리얼 재귀함수
        {
            if(dinput == 1)
            {
                return 1.0;
            }
            else
            {
                return Factorial(dinput - 1) * dinput;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //sin 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Sin(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //cos 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Cos(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //tan 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Tan(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //X^3 버튼
            if(textBox1.Text == "")
            {
                goto Exit;
            }
            if (textBox1.Text != "")
            {
                for(int i = 0; i< 3; i++)
                {
                    textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 3).ToString();
                }
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // |X| 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Abs(double.Parse(textBox1.Text)).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }
        private void geasan()
        {
            if (Stored_Younsanja != "")
            {
                //두번째 이상 연산자 입력시
                if (Stored_Younsanja == "+")
                {
                    textBox1.Text = (Stored_Sutja + Double.Parse(textBox1.Text)).ToString();
                }
                else if (Stored_Younsanja == "-")
                {
                    textBox1.Text = (Stored_Sutja - Double.Parse(textBox1.Text)).ToString();
                }
                else if (Stored_Younsanja == "×")
                {
                    textBox1.Text = (Stored_Sutja * Double.Parse(textBox1.Text)).ToString();
                }
                else if (Stored_Younsanja == "÷")
                {
                    textBox1.Text = (Stored_Sutja / Double.Parse(textBox1.Text)).ToString();
                }
                else if (Stored_Younsanja == "^")
                {
                    textBox1.Text = Math.Pow(Stored_Sutja, Double.Parse(textBox1.Text)).ToString();
                }
                else if (Stored_Younsanja == "%")
                {
                    textBox1.Text = (Stored_Sutja % Double.Parse(textBox1.Text)).ToString();
                }
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            // X^Y 버튼
            if(textBox1.Text == "")
            {
                goto Exit;
            }
            geasan();
            //첫번째 연사자 입력시
            Stored_Sutja = Double.Parse(textBox1.Text);
            Stored_Younsanja = "^";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // 1/|X| 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text =(1 / Math.Abs(double.Parse(textBox1.Text))).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // 10^X 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Pow(10, double.Parse(textBox1.Text)).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // ∏ 버튼
            textBox1.Text = "";
            if (Clear_Flag == true)
            {
                textBox1.Text = "";
                Clear_Flag = false;
            }
            textBox1.Text += Math.PI;
            bJjeom_Flag = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            // x mod y 버튼
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            geasan();
            //첫번째 연사자 입력시
            Stored_Sutja = Double.Parse(textBox1.Text);
            Stored_Younsanja = "%";
            bJjeom_Flag = false;
            Clear_Flag = true;
        Exit:;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            // X의 제곱근(√) 버튼
            if (textBox1.Text != "")
            {
                textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
            }
            Stored_Sutja = 0;
            Stored_Younsanja = "";
            bJjeom_Flag = false;
            Clear_Flag = true;
        }
    }
}
