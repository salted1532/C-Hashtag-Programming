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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            switch(textBox1.Text)
            {
                case "" :
                    MessageBox.Show("A+,A0 ~ F중 자신의 학점을 입력하세요!", "[경고1]");
                    break;
                case "A+":
                    textBox2.Text = "96~100점 사이군요. 이야.. 공부를 정말 열심히 하셨네요!!";
                    break;
                case "A0":
                    textBox2.Text = "91~95점 사이군요. 방심은 금물 더욱 꼼꼼히 공부하셔야겠어요!";
                    break;
                case "B+":
                    textBox2.Text = "86~90점 사이군요. 잘 하셨네요!";
                    break;
                case "B0":
                    textBox2.Text = "81~85점 사이군요! 나쁘지 않아요!";
                    break;
                case "C+":
                    textBox2.Text = "76~80점 사이군요. 더 열심히!";
                    break;
                case "C0":
                    textBox2.Text = "71~75점 사이군요. 조금만더 열심히 하셔야겠어요!";
                    break;
                case "D+":
                    textBox2.Text = "66~70점 사이군요. 더 노력을 열심히 하셔야겠어요!";
                    break;
                case "D0":
                    textBox2.Text = "61~65점 사이군요. 아슬아슬한 턱걸이! 축하드려요!";
                    break;
                case "F":
                    textBox2.Text = "0~59점 사이군요. 더 노력하세요... 재수강이네요. ㅠㅠ";
                    break;
                default :
                    MessageBox.Show("A+, A0 ~F중 자신의 학점을 입력하세요!", "[경고2]");
                    break;
            }
            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }
    }
}
