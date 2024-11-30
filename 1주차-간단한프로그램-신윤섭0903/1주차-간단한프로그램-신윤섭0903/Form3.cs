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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + "님 코로나 19에 걸리지 않도록 조심하세용~";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
