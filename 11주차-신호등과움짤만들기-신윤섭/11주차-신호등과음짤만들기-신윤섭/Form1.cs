using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11주차_신호등과음짤만들기_신윤섭
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeSinhodoong(int Color)     // 우리가 직접 만든 자작 함수 프로시저
        {
            switch(Color)
            {
                case 0 :
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/신호등/신호등(준비중).png");
                    break;
                case 1 :
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/신호등/신호등(적색).png");
                    break;
                case 2 :
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/신호등/신호등(노란색).png");
                    break;
                case 3 :
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/신호등/신호등(녹색).png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/신호등/신호등(노란색).png");
                    break;
            }
        }
        int colors = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeSinhodoong(colors);
            colors++;
            if(colors >= 5)
            {
                colors = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeSinhodoong(0);
            if (colors == 1)
            {

            }
            else if (colors == 2)
            {

            }
            else if (colors == 3)
            {

            }
        }
    }
}
