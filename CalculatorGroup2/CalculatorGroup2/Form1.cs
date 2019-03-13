using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        protected Boolean OperationIsPressed;
        public Form1()
        {
            InitializeComponent();
            OperationIsPressed = false;
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonDivision.Enabled = false;
            buttonEqual.Enabled = false;
            buttonDot.Enabled = false;
            buttonMultiplication.Enabled = false;
            
        }
        private void EnableAllButtons()
        {
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonDivision.Enabled = true;
            buttonEqual.Enabled = true;
            buttonDot.Enabled = true;
            buttonMultiplication.Enabled = true;

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(OperationIsPressed==true) {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                Screen.AppendText(" + ");
                EnableAllButtons();
                buttonPlus.Enabled = false;

            }
                
            else {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonPlus.Enabled = false;
                Screen.AppendText(" + ");
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {

            Screen.AppendText("0");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen.AppendText("1");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Screen.AppendText("2");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Screen.AppendText("3");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Screen.AppendText("4");
            OperationIsPressed = false;
            EnableAllButtons();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Screen.AppendText("5");
            OperationIsPressed = false;
            EnableAllButtons();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Screen.AppendText("6");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Screen.AppendText("7");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Screen.AppendText("8");
            OperationIsPressed = false;
            EnableAllButtons();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Screen.AppendText("9");
            OperationIsPressed = false;
            EnableAllButtons();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (OperationIsPressed == true)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                Screen.AppendText(" - ");
                EnableAllButtons();
                buttonMinus.Enabled = false;

            }

            else {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonMinus.Enabled = false;
                Screen.AppendText(" - ");
            }
            
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (OperationIsPressed == true)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                Screen.AppendText(" X ");
                EnableAllButtons();
                buttonMultiplication.Enabled = false;

            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonMultiplication.Enabled = false;
                Screen.AppendText(" X ");
            }

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (OperationIsPressed == true)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                Screen.AppendText(" / ");
                EnableAllButtons();
                buttonDivision.Enabled = false;

            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonDivision.Enabled = false;
                Screen.AppendText(" / ");
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            Screen.Text = String.Empty;
            EnableAllButtons();
        }

        private void buttonDeleteOne_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Screen.Text)) { 
            if(OperationIsPressed==true)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                OperationIsPressed = false;
                EnableAllButtons();
            }
            else
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
                EnableAllButtons();
            }
            }
        }
    }
}
