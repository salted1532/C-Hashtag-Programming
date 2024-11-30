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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text + "님 오후수업 화이팅", "\"[안내사항]\"");
            MessageBox.Show(textBox1.Text + "님 오후수업 화이팅", Convert.ToChar(34) + "\"[안내사항]\"" + Convert.ToChar(34));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
