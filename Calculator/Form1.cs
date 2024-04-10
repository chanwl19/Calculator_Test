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
        private string displayEquation;
        private bool isNewNum;
        private List<string> equation = new List<string>();
        private bool isEquationEnd;
        private bool isError;
        private delegate double DelegateFunc(double value);
        private string[] aboutMes = { "I am Wai Lung from COMP 122 Section 004. \nMy Program is Software Engineering Technicians (3408) \nThis is my first Calculator Apps. Hope you enjoy it.",
                                      "I am Wai Lung from COMP 122 Section 004. \nThis is my second semester in Centennial College.\nI enjoy the time studying here",
                                      "I am Wai Lung from COMP 122 Section 004. \nThis Calculator Apps is very interesting, I have encoutered a lot of challenges when developing this applications.\nDespite the challenges I have faced, I still enjoy working on it."};
        public Form1()
        {
            InitializeComponent();
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            changeDisplayNumber("0","0");
            this.isNewNum = true;
            this.isEquationEnd = false;
            this.isError = false;
            this.Size = new System.Drawing.Size(631, 654);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void darkModeBtn_Clicked(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked){
                this.tabPage1.BackColor = System.Drawing.Color.Gray;
            } else {
                this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            };
        }

        private void num7BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("7");
        }

        private void num8BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("8");
        }

        private void num9BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("9");
        }

        private void num4BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("4");
        }

        private void num5BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("5");
        }

        private void num6BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("6");
        }

        private void num1BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("1");
        }

        private void num2BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("2");
        }

        private void num3BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("3");
        }

        private void num0BtnClick(object sender, EventArgs e)
        {
            pressNumBtn("0");
        }

        private void pressNumBtn(string num) {
            checkEquationEnd();
            this.richTextBox1.Text = this.isNewNum ? num : this.richTextBox1.Text + num;
            changeDisplayNumber(this.richTextBox1.Text, this.displayEquation);
            this.isNewNum = false;
        }

        private void changeDisplayNumber(string str, string display) {
            this.richTextBox1.Text = str;
            this.textBox1.Text = display;
        }

        private void clearBtnClick(object sender, EventArgs e)
        {
            clearContent();
        }

        private void clearContent(){
            changeDisplayNumber(this.richTextBox1.Text, "0");
            this.equation.Clear();
            this.displayEquation = "";
            //this.richTextBox1.Text = "0";
            this.isNewNum = true;
            this.isError = false;
        }

        private void floatBtnClick(object sender, EventArgs e)
        {
            checkEquationEnd();
            this.richTextBox1.Text = this.richTextBox1.Text.IndexOf(".") < 0 ? this.richTextBox1.Text + "." : this.richTextBox1.Text;
        }

        private void addBtnClick(object sender, EventArgs e)
        {
            pressOperationBtn(this.richTextBox1.Text, "+");
        }

        private void minusBtnClick(object sender, EventArgs e)
        {
            pressOperationBtn(this.richTextBox1.Text, "-");
        }

        private void multiplyBtnClick(object sender, EventArgs e)
        {
            pressOperationBtn(this.richTextBox1.Text, "*");
        }

        private void divideBtnClick(object sender, EventArgs e)
        {
            pressOperationBtn(this.richTextBox1.Text, "/");
        }

        private void pressOperationBtn(string value, string sign) {
            checkEquationEnd();
            this.displayEquation += $"{value} {sign} ";
            formEquation(sign, value);
            string returnNumStr = Calculation.calculationEquation(new List<string>(this.equation));
            changeDisplayNumber(returnNumStr, this.displayEquation);
            this.isNewNum = true;
        }

        private void formEquation(string sign, string value) {
            if (this.equation.Count == 0){
                this.equation.Add(value);
            } else {
                int lastIndex = this.equation.Count - 1;
                switch (this.equation[lastIndex]) {
                    case "+":
                        this.equation.Add(value);
                        break;
                    case "-":
                        this.equation.Add($"-{value}");
                        this.equation[lastIndex] = "+";
                        break;
                    case "*":
                        this.equation.Add(value);
                        break;
                    case "/":
                        this.equation.Add($"1/{value}");
                        this.equation[lastIndex] = "*";
                        break;
                    default:
                        break;
                }
                    
            }
            this.equation.Add(sign);
        }

        private void equalSign_Click(object sender, EventArgs e)
        {
            if (this.displayEquation.IndexOf("=") <0) {
                if (!this.isNewNum) {
                    formEquation(this.equation[this.equation.Count - 1], this.richTextBox1.Text);
                    this.displayEquation += this.richTextBox1.Text + " =";
                } else {
                    this.displayEquation = this.displayEquation.Remove(this.displayEquation.Length - 2) + " =";
                }
                string returnNumStr = Calculation.calculationEquation(new List<string>(this.equation));
                changeDisplayNumber(returnNumStr, this.displayEquation);
                this.equation.Clear();
                this.isNewNum = true;
                this.isEquationEnd = true;
            }

        }

        private void negativeBtn_Click(object sender, EventArgs e)
        {
            checkEquationEnd();
            string displayVal = this.richTextBox1.Text;
            decimal value = Decimal.Multiply(Convert.ToDecimal(displayVal), -1m);
            changeDisplayNumber(value.ToString(), this.displayEquation);
        }

        private void checkEquationEnd() {
            if (this.isEquationEnd || this.isError) {
                this.clearContent();
                this.isEquationEnd = false;
            }
        }

        private void fractionBtn_Click(object sender, EventArgs e)
        {
            checkEquationEnd();
            string displayVal = this.richTextBox1.Text;
            string reult = "Error";
            try { 
                decimal value = Decimal.Divide(1m, Convert.ToDecimal(displayVal));
                reult = value.ToString();
            } catch (Exception ex) {
                this.isError = true;
            }
            changeDisplayNumber(reult, this.displayEquation);
        }

        private void squareRootBtn_Click(object sender, EventArgs e)
        {
            checkEquationEnd();
            string displayVal = this.richTextBox1.Text;
            string reult = "Error";
            try {
                decimal value = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(displayVal)));
                reult = value.ToString();
            } catch (Exception ex) {
                this.isError = true;
            }
            changeDisplayNumber(reult, this.displayEquation);
        }

        private void standardBtn_Click(object sender, EventArgs e)
        {
            changeCalculatorMode(true);
        }

        private void scienceticBtn_Click(object sender, EventArgs e)
        {
            changeCalculatorMode(false);
        }

        private void changeCalculatorMode(bool isStandard) {
            if (isStandard) {
                this.Size = new System.Drawing.Size(631, 654);
                this.tabPage1.Size = new System.Drawing.Size(617, 613);
                this.tabPage2.Size = new System.Drawing.Size(617, 613);
                this.button21.Visible = false;
                this.button22.Visible = false;
                this.button23.Visible = false;
                this.button24.Visible = false;
            } else{
                this.Size = new System.Drawing.Size(631, 700);
                this.tabPage1.Size = new System.Drawing.Size(617, 659);
                this.tabPage2.Size = new System.Drawing.Size(617, 659);
                this.button21.Visible = true;
                this.button22.Visible = true;
                this.button23.Visible = true;
                this.button24.Visible = true;
            }
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {
            checkEquationEnd();
            string displayVal = this.richTextBox1.Text;
            decimal value = additionalFunction(Math.Sin, Convert.ToDouble(displayVal));
            changeDisplayNumber(value.ToString(), this.displayEquation);
        }

        private void cosBtn_Click(object sender, EventArgs e)
        {
            checkEquationEnd();
            string displayVal = this.richTextBox1.Text;
            decimal value = additionalFunction(Math.Cos, Convert.ToDouble(displayVal));
            changeDisplayNumber(value.ToString(), this.displayEquation);
        }

        private void eBtn_Click(object sender, EventArgs e)
        {
            checkEquationEnd();
            changeDisplayNumber(Math.E.ToString(), this.displayEquation);
        }

        private void piBtn_Click(object sender, EventArgs e)
        {
            checkEquationEnd();
            changeDisplayNumber(Math.PI.ToString(), this.displayEquation);
        }

        private decimal additionalFunction(DelegateFunc func, double value = 0d) {
            double doubleVal = func(value*2*Math.PI/360);
            return Convert.ToDecimal(doubleVal);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            int length = aboutMes.Length ;
            Random random = new Random();
            int index = random.Next(0, length);
            this.richTextBox2.Text = aboutMes[index];
        }
    }
}
