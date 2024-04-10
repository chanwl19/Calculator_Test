using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button25 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 659);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button24);
            this.tabPage1.Controls.Add(this.button23);
            this.tabPage1.Controls.Add(this.button22);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Controls.Add(this.button18);
            this.tabPage1.Controls.Add(this.button17);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculator";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.SteelBlue;
            this.button24.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(520, 571);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(56, 56);
            this.button24.TabIndex = 28;
            this.button24.Text = "π";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Visible = false;
            this.button24.Click += new System.EventHandler(this.piBtn_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.SteelBlue;
            this.button23.Font = new System.Drawing.Font("PMingLiU", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(459, 571);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 56);
            this.button23.TabIndex = 27;
            this.button23.Text = "e";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Visible = false;
            this.button23.Click += new System.EventHandler(this.eBtn_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.SteelBlue;
            this.button22.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(397, 571);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 56);
            this.button22.TabIndex = 26;
            this.button22.Text = "cos";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Visible = false;
            this.button22.Click += new System.EventHandler(this.cosBtn_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.SteelBlue;
            this.button21.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(335, 571);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 56);
            this.button21.TabIndex = 25;
            this.button21.Text = "sin";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Visible = false;
            this.button21.Click += new System.EventHandler(this.sinBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(558, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.SteelBlue;
            this.button20.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(507, 281);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(69, 284);
            this.button20.TabIndex = 23;
            this.button20.Text = "=";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.equalSign_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.SteelBlue;
            this.button19.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(421, 485);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(80, 80);
            this.button19.TabIndex = 22;
            this.button19.Text = "√";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.squareRootBtn_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.SteelBlue;
            this.button18.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(335, 485);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 80);
            this.button18.TabIndex = 21;
            this.button18.Text = "1/X";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.fractionBtn_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Coral;
            this.button17.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(421, 384);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 80);
            this.button17.TabIndex = 20;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.divideBtnClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Coral;
            this.button16.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(335, 384);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 80);
            this.button16.TabIndex = 19;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.multiplyBtnClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Coral;
            this.button15.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(421, 281);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 80);
            this.button15.TabIndex = 18;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.minusBtnClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Coral;
            this.button14.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(335, 281);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 80);
            this.button14.TabIndex = 17;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.addBtnClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("PMingLiU", 30F);
            this.button13.Location = new System.Drawing.Point(335, 186);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(241, 80);
            this.button13.TabIndex = 16;
            this.button13.Text = "Clear";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("PMingLiU", 25F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(233, 485);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 80);
            this.button10.TabIndex = 15;
            this.button10.Text = "+/-";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.negativeBtn_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(125, 485);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 80);
            this.button11.TabIndex = 14;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.floatBtnClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(18, 485);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 80);
            this.button12.TabIndex = 13;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.num0BtnClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(233, 384);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button7.TabIndex = 12;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.num3BtnClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(125, 384);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button8.TabIndex = 11;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.num2BtnClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(18, 384);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 10;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.num1BtnClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(233, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 9;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.num6BtnClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(125, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.num5BtnClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(18, 281);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button6.TabIndex = 7;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.num4BtnClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(233, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 6;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.num9BtnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(125, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 5;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.num8BtnClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.num7BtnClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(255, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Dark Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.darkModeBtn_Clicked);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(125, 151);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Scientific";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.scienceticBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 151);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standard";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.standardBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("PMingLiU", 50F);
            this.richTextBox1.Location = new System.Drawing.Point(18, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(558, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button25);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About me";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(233, 219);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(318, 153);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(579, 156);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(233, 182);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(138, 31);
            this.button25.TabIndex = 3;
            this.button25.Text = "Generate About Me";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 667);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "My Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox1;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox2;
        private Button button25;
    }
}

