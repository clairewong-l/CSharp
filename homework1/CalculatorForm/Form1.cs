using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calculate()
        {
            double result = 0;
            double num1 = double.Parse(num1Txt.Text);
            double num2 = double.Parse(num2Txt.Text);
            int ch = comboBox1.SelectedIndex;
            switch (ch)
            {
                case 0:
                    result = num1 + num2;
                    resultTxt.Text = result.ToString();
                    break;
                case 1:
                    result = num1 - num2;
                    resultTxt.Text = result.ToString();
                    break;
                case 2:
                    result = num1 * num2;
                    resultTxt.Text = result.ToString();
                    break;
                case 3:
                    if (num2 == 0) { resultTxt.Text = "除数为0"; ; break; }
                    result = num1 / num2;
                    resultTxt.Text = result.ToString();
                    break;
            }
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
