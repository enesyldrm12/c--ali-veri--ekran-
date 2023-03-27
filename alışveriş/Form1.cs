using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alışveriş
{
    public partial class Form1 : Form
    {
        int c,d,a,b;
        double kalan,sonuc;

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label10.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            if (checkBox1.Checked = true)
            {
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;

            }

        }

        int m;

        private void button2_Click(object sender, EventArgs e)
        {
            m = Convert.ToInt32(textBox1.Text);
            kalan = m - sonuc;
            label10.Text = kalan.ToString() + "TL";


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "büyük boy(30tl)")
            {
                c = 30;

            }
            else if (comboBox1.Text == "orta boy(20tl)")
            {
                c = 20;
            }
            else if (comboBox1.Text == "küçük boy(10tl)")
            {
                c = 10;
            }
            else
            {
                c = 0;
            }
            if (comboBox2.Text == "etli(50tl)")
            {
                d = 50;

            }
            else if (comboBox2.Text == "tavuklu(35tl)")
            {
                d = 35;
            }
            else
            {
                d = 0;
            }
            if (comboBox3.Text == "büyük boy(15tl)")
            {
                a = 15;

            }
            else if (comboBox3.Text == "orta boy(10tl)")
            {
                a = 10;
            }
            else if (comboBox3.Text == "küçük boy(5tl)")
            {
                a = 5;
            }
            else
            {
                a = 0;
            }
            if (comboBox4.Text == "büyük boy(20tl)")
            {
                b = 20;

            }
            else if (comboBox4.Text == "orta boy(15tl)")
            {
                b = 15;
            }
            else if (comboBox4.Text == "küçük boy(5tl)")
            {
                b = 5;
            }
            else
            {
                b = 0;
            }
            sonuc = a + b + c + d;
            if (checkBox1.Checked)
            {
                sonuc = (sonuc - (sonuc * 0.05));
            }
            else if (checkBox2.Checked)
            {
                sonuc = (sonuc - (sonuc * 0.03));
            }
            else if (checkBox3.Checked)
            {
                sonuc = (sonuc - (sonuc * 0.1));
            }
            label8.Text = sonuc.ToString();
           
        }
       
    }
}
