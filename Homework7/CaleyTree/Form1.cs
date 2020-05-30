using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics = this.panel1.CreateGraphics();
            graphics.Clear(panel1.BackColor);


            th1 = double.Parse(textBox5.Text) * Math.PI / 180;
            th2 = double.Parse(textBox6.Text) * Math.PI / 180;
            per1 = double.Parse(textBox3.Text);
            per2 = double.Parse(textBox4.Text);
            leng  = double.Parse(textBox2.Text);
            n = int.Parse(textBox1.Text);
            pen = pens[comboBox1.SelectedIndex];
            drawCaleyTree(n, panel1.Width / 2, panel1.Height, leng, -Math.PI / 2);
        }

        private Graphics graphics;

        double th1 { get; set; } //右分支角度
        double th2 { get; set; } //左分支角度
        double per1 { get; set; }//右分支长度比
        double per2 { get; set; }//左分支长度比
        int n { get; set; }//递归深度
        double leng { get; set; }//主干长度
        Pen pen { get; set; }
        Pen[] pens = { Pens.OrangeRed, Pens.AliceBlue, Pens.YellowGreen, Pens.Tan, Pens.RosyBrown };


        void drawCaleyTree(int n, double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCaleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCaleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine (double x0,double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        
            +
            pen = Pens.OrangeRed;
            comboBox1.DataSource = pens;
            comboBox1.DisplayMember = "Color";
        }

    }
}
