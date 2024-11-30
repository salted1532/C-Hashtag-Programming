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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("충전기");
            listBox1.Items.Add("치솔");
            listBox1.Items.Add("치약");
            listBox1.Items.Add("손수선");
            listBox1.Items.Add("타월");
            listBox1.Items.Add("잠옷");
            listBox1.Items.Add("양말");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
