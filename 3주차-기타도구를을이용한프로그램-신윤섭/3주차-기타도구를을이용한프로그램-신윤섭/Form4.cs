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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Text = textBox1.Text + "님은 " + radioButton1.Text + "이고 연령은 " + comboBox1.Text +"\r\n반려동물은 " + listBox1.Text + " 입니다~";
            }
            if (radioButton2.Checked == true)
            {
                textBox2.Text = textBox1.Text + "님은 " + radioButton2.Text + "이고 연령은 " + comboBox1.Text + "\r\n반려동물은 " + listBox1.Text + " 입니다~";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
