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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int colors = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/신호등/" + (colors >= 5 ? colors = 1 : colors++) + ".png");
            //pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/신호등/" + colors + ".png");
            //colors++;
            //if (colors >= 5)
            //{
            //    colors = 1;
            //}
        }
    }
}
