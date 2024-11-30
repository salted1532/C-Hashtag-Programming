using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1주차_간단한프로그램_신윤섭0903
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + "님~~~!,\r\n당신의 학번은" + textBox2.Text + "\r\n입니다.";
            MessageBox.Show(textBox1.Text + "님~~~!,\n당신의 학번은" + textBox2.Text + "\n입니다.", "\"공지사항\"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
