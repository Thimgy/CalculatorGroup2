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
            DisableAllButtons();
            
        }
        private void EnableAllButtons()
        {
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonDivision.Enabled = true;
            buttonEqual.Enabled = true;
            buttonMultiplication.Enabled = true;
            buttonDeleteOne.Enabled = true;
            buttonDeleteAll.Enabled = true;
            
        

        }
        private void DisableAllButtons()
        {
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonDivision.Enabled = false;
            buttonEqual.Enabled = false;
            buttonMultiplication.Enabled = false;
            buttonDeleteOne.Enabled = false;
            buttonDeleteAll.Enabled = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(OperationIsPressed==true) {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                Screen.AppendText(" + ");
                EnableAllButtons();
                buttonPlus.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;

            }
                
            else {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonPlus.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
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
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;

            }

            else {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonMinus.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
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
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;

            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonMultiplication.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
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
                buttonEqual.Enabled = false;
                buttonDot.Enabled = false;

            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonDivision.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = false;
                Screen.AppendText(" / ");
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            Screen.Text = String.Empty;
            DisableAllButtons();
            
        }

        private void buttonDeleteOne_Click(object sender, EventArgs e)
        {
            char test = Screen.Text[Screen.Text.Length - 1];
            if (test == ' ')
            {
                OperationIsPressed = true;
            }


            if (!String.IsNullOrEmpty(Screen.Text)) {
                if (OperationIsPressed == true)
                {
                    Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                    if (String.IsNullOrEmpty(Screen.Text))
                    {
                        DisableAllButtons();
                    }
                    else {
                        OperationIsPressed = false;
                        EnableAllButtons();
                    }

                }
                else
                {
                     Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);

                    if (String.IsNullOrEmpty(Screen.Text))
                    {
                        DisableAllButtons();
                    }
                    else
                    {
                        char last = Screen.Text[Screen.Text.Length - 1];
                        if (last == ' ')
                        {
                            DisableAllButtons();
                            buttonDeleteOne.Enabled = true;
                            buttonDeleteAll.Enabled = true;
                            Screen.Focus();
                            Screen.SelectionStart = Screen.Text.Length;


                        }
                        else
                        {
                            buttonEqual.Enabled = true;
                        }
                    }

                }
            }
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            OperationLogic op = new OperationLogic();
            String[] text = Screen.Text.Split(' ');
            Screen.Text = String.Empty;
            Screen.Text = op.PerformOperation(text) + "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            Screen.AppendText(".");
            buttonDot.Enabled = false;

        }
    }
}
