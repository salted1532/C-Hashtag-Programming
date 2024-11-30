using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3주차_기타도구를을이용한프로그램_신윤섭
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = "당신의 연령은 " + "\r\n";
            if (radioButton1.Checked == true)
            {
                str = str + radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                str = str + radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                str = str + radioButton3.Text;
            }
            if (radioButton4.Checked == true)
            {
                str = str + radioButton4.Text;
            }
            if (radioButton5.Checked == true)
            {
                str = str + radioButton5.Text;
            }
            if (radioButton6.Checked == true)
            {
                str = str + radioButton6.Text;
            }

            str = str + "\r\n" + "\r\n" + "좋아하는 색은 " + "\r\n";

            if(checkBox1.Checked == true)
            {
                str = str + checkBox1.Text + ", ";
            }
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text + ", ";
            }
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text + ", ";
            }
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text + ", ";
            }
            if (checkBox5.Checked == true)
            {
                str = str + checkBox5.Text + ", ";
            }
            if (checkBox6.Checked == true)
            {
                str = str + checkBox6.Text;
            }
            str = str + Environment.NewLine + " 입니다.";
            textBox1.Text = str;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
