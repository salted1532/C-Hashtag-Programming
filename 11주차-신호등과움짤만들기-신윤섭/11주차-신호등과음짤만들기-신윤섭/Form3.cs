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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int color_1 = 1;
        int color_2 = 1;
        int color_3 = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/엄마에게 다가가는 새끼 코끼리/" + (color_1 >= 5 ? color_1 = 1 : color_1++) + ".jpg");
            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/다가오는 코끼리 두마리/" + (color_2 >= 6 ? color_2 = 1 : color_2++) + ".jpg");
            pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/사진모음/돌아서는 오버액션토끼/" + (color_3 >= 7 ? color_3 = 1 : color_3++) + ".jpg");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
