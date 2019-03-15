using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operation;
using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        protected Boolean OperationIsPressed;
        protected Boolean isPressed;
        // when an operation is completed and the user writes another number, the past result should be replaced with the new input
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
            buttonMod.Enabled = true;
            buttonMultiplication.Enabled = true;
            buttonDeleteOne.Enabled = true;
            buttonDeleteAll.Enabled = true;
            buttonChangeSign.Enabled = true;
            
        

        }

        private void ReplaceResults()
        {

            if (isPressed == true)
            {
                Screen.Text = String.Empty;
                isPressed = false;
            }


        }
        private void DisableAllButtons()
        {
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonDivision.Enabled = false;
            buttonEqual.Enabled = false;
            buttonMod.Enabled = false;
            buttonMultiplication.Enabled = false;
            buttonDeleteOne.Enabled = false;
            buttonDeleteAll.Enabled = false;
            buttonChangeSign.Enabled = false;
        }



        private void button0_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("0");
            OperationIsPressed = false;
            EnableAllButtons();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("1");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("2");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("3");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("4");
            OperationIsPressed = false;
            EnableAllButtons();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("5");
            OperationIsPressed = false;
            EnableAllButtons();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("6");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("7");
            OperationIsPressed = false;
            EnableAllButtons();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("8");
            OperationIsPressed = false;
            EnableAllButtons();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReplaceResults();
            Screen.AppendText("9");
            OperationIsPressed = false;
            EnableAllButtons();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (OperationIsPressed == true)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                Screen.AppendText(" + ");
                EnableAllButtons();
                buttonPlus.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;

            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonPlus.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
                Screen.AppendText(" + ");
            }

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
                buttonChangeSign.Enabled = false;



            }

            else {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonMinus.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
                Screen.AppendText(" - ");
                buttonChangeSign.Enabled = false;

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
                buttonChangeSign.Enabled = false;


            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonMultiplication.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
                Screen.AppendText(" X ");
                buttonChangeSign.Enabled = false;
                isPressed = true;

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
                buttonChangeSign.Enabled = false;

            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonDivision.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
                Screen.AppendText(" / ");
                buttonChangeSign.Enabled = false;

            }
            // isPressed = true;
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
            //isPressed = true;
            //buttonDot.Enabled = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            Screen.AppendText(".");
            buttonDot.Enabled = false;
            ReplaceResults();
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {
            if (Screen.Text == "∞")
            {
                Screen.Text = string.Empty;

            }
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Screen.Text, @"^\d+$") || Regex.IsMatch(Screen.Text, @"^\d*\.?\d*$"))
            {

                float result = OperationRoot.PerformationRoot(float.Parse(Screen.Text, CultureInfo.InvariantCulture.NumberFormat));
                Screen.Text = String.Empty;
                Screen.AppendText(result + "");
                buttonDot.Enabled = true;
            }
            isPressed = true;

        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Screen.Text, @"[-+]?(0?|[1-9][0-9]*)(\.[0-9]*[1-9])?([eE][-+]?(0|[1-9][0-9]*))?")) 
            {
                float result = OperationSquare.PerformationSquare(float.Parse(Screen.Text, CultureInfo.InvariantCulture.NumberFormat));
                Screen.Text = String.Empty;
                Screen.AppendText(result + "");
                buttonDot.Enabled = true;
            }
            isPressed = true; // move this to all the operations 
        }

        private void buttonMod_Click(object sender, EventArgs e) 
        {
            if (OperationIsPressed == true)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 3);
                Screen.AppendText(" % ");
                EnableAllButtons();
                buttonMod.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;

            }

            else
            {
                OperationIsPressed = true;
                EnableAllButtons();
                buttonMod.Enabled = false;
                buttonEqual.Enabled = false;
                buttonDot.Enabled = true;
                Screen.AppendText(" % ");
            }


            if (Regex.IsMatch(Screen.Text, @"^\d+$"))
            {
                float result = OperationMod.PerformationMod(float.Parse(Screen.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(Screen.Text, CultureInfo.InvariantCulture.NumberFormat));
                Screen.Text = String.Empty;
                Screen.AppendText(result + "");



            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            string equation = Screen.Text;
            string last = Screen.Text.Split(' ')[Screen.Text.Split(' ').Length - 1];

            if (Regex.IsMatch(last, @"^\d+$")) {
                if (Screen.Text.Contains(' '))
                {
                    equation = Screen.Text.Substring(0, Screen.Text.LastIndexOf(' ')) + " (-" + last + ")";
                }
                else {
                    equation = "(-" + last + ")";
                }


            }
            if (last[0].Equals('(') && last[last.Length - 1].Equals(')')) {
                if (last.Substring(1,1).Equals("-") && Regex.IsMatch(last.Substring(2, last.Length - 3), @"^\d+$")){
                    if (last.Substring(1, 1).Equals("-")) {
                        last = last.Substring(2, last.Length - 3);

                        if (Screen.Text.Contains(' '))
                        {
                            equation = Screen.Text.Substring(0, Screen.Text.LastIndexOf(' ')) + " " + last ;
                        }
                        else
                        {
                            equation =  last ;
                        }
                    }
                }
            }
            Screen.Text = equation;
        }

    }
}
