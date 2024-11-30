using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5주차_구구단만들기_신윤섭
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int iDan =1; iDan < 10; iDan++)
            {
                for(int num = 1; num < 10; num++)
                {
                    //textBox1.Text = textBox1.Text + iDan + "*" + num + "=" + (iDan * num) + "\r\n";
                    textBox1.Text += iDan + "*" + num + "=" + (iDan * num) + "\r\n";// 같은 코딩
                }
                //textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text += Environment.NewLine;// 같은 코딩
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //while 문
            uint uDan = 1;//uint = unsigned int 양수만
            uint uDuisutja = 1;

            textBox2.Text = "";

            while(uDan < 10)
            {
                while (uDuisutja < 10)
                {
                    textBox2.Text += uDan + "*" + uDuisutja + "=" + (uDan * uDuisutja) + "\r\n";
                    uDuisutja++;
                }
                uDan++;
                textBox2.Text += Environment.NewLine;
                uDuisutja = 1;//중요
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //do while 문
            uint uDan = 1;//uint = unsigned int 양수만
            uint uDuisutja = 1;

            textBox3.Text = "";

            do
            {
                do
                {
                    textBox3.Text += uDan + "*" + uDuisutja + "=" + (uDan * uDuisutja) + "\r\n";
                    uDuisutja++;
                } while (uDuisutja < 10);
                uDan++;
                textBox3.Text += Environment.NewLine;
                uDuisutja = 1;//중요
            } while (uDan < 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //while (true)문
            uint uDan = 1;//uint = unsigned int 양수만
            uint uDuisutja = 1;
            textBox4.Text = "";
            while (true)
            {
                while (true)
                {
                    textBox4.Text += uDan + "*" + uDuisutja + "=" + (uDan * uDuisutja) + "\r\n";
                    uDuisutja++;
                    if(uDuisutja == 10) {
                        break;
                    }
                }
                uDan++;
                textBox4.Text += Environment.NewLine;
                uDuisutja = 1;//중요
                if (uDan == 10) {
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uint[] uGuGuDan = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

            textBox5.Text = "";

            foreach(uint uDan in uGuGuDan)
            {
                foreach (uint uDuisutja in uGuGuDan)
                {
                    textBox5.Text += uDan + "*" + uDuisutja + "=" + (uDan * uDuisutja) + "\r\n";
                }
                textBox5.Text += Environment.NewLine;
            }
        }
    }
}
