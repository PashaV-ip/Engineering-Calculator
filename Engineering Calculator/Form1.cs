using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineering_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string funct;
        public string num1;
        public string num2;
        public bool number2TorF = false;
        public bool rndTorF = false;

        private void NullButton_Click(object sender, EventArgs e) //Группа цифр
        {
            if (number2TorF)
            {
                number2TorF = false;
                InputField.Text = "0";
            }
            Button button = (Button)sender;
            if(InputField.Text == "0")
            InputField.Text = button.Text;
            else InputField.Text += button.Text;
            fullExpression.Text += button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e) //Кнопка "C"
        {
            InputField.Text = "0";
            fullExpression.Text = "";
            number2TorF = false;
            rndTorF = false;
        }

        private void AllClearButton_Click(object sender, EventArgs e) //Кнопка AC
        {

        }

        private void PlussButton_Click(object sender, EventArgs e) //Кнопки простых вычислений "+ - * /"
        {
            Button button = (Button)sender;
            funct = button.Text;
            num1 = InputField.Text;
            if (number2TorF)
                fullExpression.Text += " " + button.Text + " ";
            number2TorF = true;
            rndTorF = false;
        }

        private void EquallyButton_Click(object sender, EventArgs e) //Равно
        {
            num2 = InputField.Text;
            if (funct == "+")
            {
                num1 = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
                InputField.Text = num1;
            }
            else if (funct == "-")
            {
                num1 = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
                InputField.Text = num1;
            }
            else if (funct == "x")
            {
                num1 = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
                InputField.Text = num1;
            }
            else if (funct == "/")
            {
                num1 = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
                InputField.Text = num1;
            }
            rndTorF = false;
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            InputField.Text = (Convert.ToDouble(InputField.Text)*(-1)).ToString();
        }

        private void RndButton_Click(object sender, EventArgs e)
        {
            if (rndTorF == false)
            {
                InputField.Text += ".";
                rndTorF = true;
            }
        }
    }
}
