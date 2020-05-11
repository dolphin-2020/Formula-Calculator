using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace DOLPHIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AutoSize = false;
            textBox1.Height = 42;
            textBox1.Margin = new Padding(0);
            button10.Margin = new Padding(10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            radioButton1.Checked = true;
            this.Height = 490;
            this.Width = 310;
         
        }
        private bool ReEnter = true;
        private string holdNum = "0";
        private string HoldOperator = "+";
        private string CurrentOperator = "+";

        private void enter(string input)
        {
            if (ReEnter == true)
            {
                textBox1.Text = input;
                ReEnter = false;
                HoldOperator = CurrentOperator;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = input;
                }
                else
                {
                    textBox1.Text += input;
                }
          
            }
        }

        private void Cacl()
        {
            switch (HoldOperator)
            {
                case "+":
                    holdNum = (double.Parse(holdNum)+double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = holdNum;
                    break;
                case "-":
                    holdNum = (double.Parse(holdNum) - double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = holdNum;
                    break;
                case "*":
                    holdNum = (double.Parse(holdNum) * double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = holdNum;
                    break;
                case "/":
                    if (double.Parse(textBox1.Text) == 0)
                    {
                        textBox1.Text = "Divide by Zero";
                        ReEnter = true;
                        holdNum = "0";
                        HoldOperator = "+";
                        CurrentOperator = "+";
                        break;
                    }
                    else
                    {
                        holdNum = (double.Parse(holdNum) / double.Parse(textBox1.Text)).ToString();
                        textBox1.Text = holdNum;
                        break;
                    }
                  
            }
        }

        private void button17_Click(object sender, EventArgs e)//1
        {
            enter("1");
        }

        private void button18_Click(object sender, EventArgs e)//2
        {
            enter("2");
        }

        private void button19_Click(object sender, EventArgs e)//3
        {
            enter("3");
        }

        private void button13_Click(object sender, EventArgs e)//4
        {
            enter("4");
        }

        private void button14_Click(object sender, EventArgs e)//5
        {
            enter("5");
        }

        private void button15_Click(object sender, EventArgs e)//6
        {
            enter("6");
        }

        private void button9_Click(object sender, EventArgs e)//7
        {
            enter("7");
        }

        private void button10_Click(object sender, EventArgs e)//8
        {
            enter("8");
        }

        private void button11_Click(object sender, EventArgs e)//9
        {
            enter("9");
        }

        private void button22_Click(object sender, EventArgs e)//0
        {
            if (ReEnter == true)
            {
                textBox1.Text = "0";
                ReEnter = false;
                HoldOperator = CurrentOperator;
            }
            else if(textBox1.Text=="0"&&ReEnter==false)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)//c
        {
            ReEnter = true;
            holdNum = "0";
            HoldOperator = "+";
            CurrentOperator = "+";
            textBox1.Text = "0";
        }

        private void button23_Click(object sender, EventArgs e)// .
        {
            if (ReEnter == true)
            {
                textBox1.Text = "0.";
                ReEnter = false;
            }
            else if (ReEnter == false && !textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button20_Click(object sender, EventArgs e)//+
        {
            if (ReEnter == true)
            {
                CurrentOperator = "+";
            }
            else
            {
                Cacl();
                ReEnter = true;
                CurrentOperator = "+";
            }
        }

        private void button16_Click(object sender, EventArgs e)//-
        {
            if (ReEnter == true)
            {
                CurrentOperator = "-";
            }
            else
            {
                Cacl();
                ReEnter = true;
                CurrentOperator = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)//*
        {
            if (ReEnter == true)
            {
                CurrentOperator = "*";
            }
            else
            {
                Cacl();
                ReEnter = true;
                CurrentOperator = "*";
            }
        }

        private void button8_Click(object sender, EventArgs e)//  /
        {
            if (ReEnter == true)
            {
                CurrentOperator = "/";
            }
            else
            {
                Cacl();
                ReEnter = true;
                CurrentOperator = "/";
            }
        }

        private void button5_Click(object sender, EventArgs e)//  1/x
        {
            if (double.Parse(textBox1.Text)==0)
            {
                textBox1.Text = "Divided by zero";
                ReEnter = true;
                holdNum = "0";
                HoldOperator = "+";
                CurrentOperator = "+";
            }
            else
            {
                textBox1.Text =( 1 / double.Parse(textBox1.Text)).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)// Square
        {
            textBox1.Text = (double.Parse(textBox1.Text) * double.Parse(textBox1.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)//sqrt
        {
            textBox1.Text = Math.Sqrt( double.Parse(textBox1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)//CE
        {
            ReEnter = true;
            holdNum = "0";
            HoldOperator = "+";
            CurrentOperator = "+";
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)//back
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
                ReEnter = true; 
            }
        }

        private void button1_Click(object sender, EventArgs e)//%  Caclulate rate like tax, not divide by 100.
        {
            textBox1.Text =(double.Parse(holdNum)*double.Parse(textBox1.Text) / 100).ToString();
        }

        private void button24_Click(object sender, EventArgs e)//=
        {
            if (ReEnter == true)
            {
                holdNum = "0";
                HoldOperator = "+";
                CurrentOperator = "+";
            }
            else
            {
                Cacl();
                holdNum = "0";
                HoldOperator = "+";
                CurrentOperator = "+";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.Visible = true;
                this.Height = 490;
                this.Width = 310;
                textBox1.Width = 270;
                textBox1.Text = "0";
                this.BackColor = Color.Black;
                textBox1.BackColor = Color.DarkGray;
                textBox1.ForeColor = Color.OrangeRed;
                radioButton1.ForeColor = Color.DarkOrange;
                radioButton3.ForeColor = Color.DarkOrange;
                radioButton2.ForeColor = Color.DarkOrange;
                radioButton2.Visible = true;
                radioButton3.Location = new Point(y: 60, x: 205);
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel2.Visible = true;
                this.Height = 485;
                this.Width = 285;
                textBox1.Width = 240;
                textBox1.Text = "0";
                panel2.Location = new Point(6, 80);
                this.BackColor = Color.Black;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.Purple;
                radioButton3.ForeColor = Color.White;
                textBox1.BackColor = Color.Purple;
                textBox1.ForeColor = Color.White;
                radioButton3.Location = new Point(y:60, x:176);
                radioButton2.Visible = false;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel3.Visible = true;
                this.Height = 490;
                this.Width = 500;
                textBox1.Width = 460;
                textBox1.Text = "cos(-(9*(-2)-3)/2)-7^2-7!+(8-3)^3";
                panel3.Location =new Point  (8, 80);
                this.BackColor = Color.LightBlue;
                textBox1.BackColor = Color.RoyalBlue;
                textBox1.ForeColor = Color.White;
                radioButton1.ForeColor = Color.Blue;
                radioButton3.ForeColor = Color.Blue;
                radioButton2.ForeColor = Color.Blue;
                radioButton2.Visible = true;
                radioButton3.Location = new Point(y: 60, x: 205);
            }
            else
            {
                panel3.Visible = false;
            }
        }

        ///////////////////////////////////////////////////////////////////Scientific
        ///

        public static string CalcPlusMinusMutiplyDivide(string str)
        {
            double testNum = 0;
            bool IsNum = false;
            IsNum = double.TryParse(str, out testNum);
            if (IsNum)
            {
                return str;
            }
            //Remove all the space.
            string a = str;
            str = a.Trim();
            string b = "";
            StringBuilder x2 = new StringBuilder();
            if (a[0] == '+' || a[0] == '-')
            {
                a = '0' + a;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != ' ')
                {
                    b += a[i];
                }
            }
            StringBuilder c = new StringBuilder();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '!' && b[i - 1] == ']')
                {
                    c[c.Length - 1] = '!';
                    c.Append(']');
                }
                else
                {
                    c.Append(b[i]);
                }
            }
            b = c.ToString();


            if (b[0] != '[')
            {
                b = '[' + b;
            }
            if (b[b.Length - 1] != ']')
            {
                b += ']';
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != '+' && b[i] != '-' && b[i] != '*' && b[i] != '/' && b[i] != '^' && b[i] != '√')
                {
                    x2.Append(b[i]);
                }
                else
                {
                    if (b[i - 1] != ']' && b[i - 1] != '[')
                    {
                        x2.Append(']');
                    }
                    x2.Append(b[i]);
                    if (b[i + 1] != '[' && b[i - 1] != '[')
                        x2.Append('[');
                }
            }

            StringBuilder x3 = new StringBuilder();
            for (int i = 0; i < x2.Length; i++)
            {
                if ((x2[i] == '+' || x2[i] == '-' || x2[i] == '*' || x2[i] == '/' || x2[i] == '^' || x2[i] == '√') && x2[i - 1] != '[')
                {
                    x3.Append(" ");
                    x3.Append(x2[i]);
                    x3.Append(" ");
                }
                else
                {
                    x3.Append(x2[i]);
                }
            }

            string temp = x3.ToString();

            string[] list = temp.Split(' ');
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Contains('['))
                {
                    string x4 = list[i].Substring(1, list[i].Length - 2);
                    list[i] = x4;
                }
            }

            ///////////////////////////////------------------------factorial
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Contains('!'))
                {
                    double t = double.Parse(list[i].Substring(0, list[i].Length - 1));

                    int j = (int)t;
                    int resultInt = 1;
                    if (j >= 0)
                    {
                        while (j > 0)
                        {
                            if (j == 0)
                            {
                                resultInt *= 1;
                            }
                            else
                            {
                                resultInt *= j;
                            }
                            j--;
                        }
                        list[i] = resultInt.ToString();
                    }
                    else
                    {
                        return "Factorial can't be negative number";
                    }
                }
            }

            //////////////////////-----------------------------AnyPow
            if (list.Contains("^"))
            {
                Stack<string> stack = new Stack<string>();
                for (int i = 0; i < list.Length; i++)
                {
                    double r = 0;
                    if (list[i] == "^")
                    {
                        r = Math.Pow(double.Parse(stack.Pop()), double.Parse(list[i + 1]));
                        stack.Push(r.ToString());
                        i++;
                    }
                    else
                    {
                        stack.Push(list[i]);
                    }
                }

                list = stack.Reverse().ToArray();


            }

            ///////////////////////////////////////----------------any root
            if (list.Contains("√"))
            {
                Stack<string> stack = new Stack<string>();
                for (int i = 0; i < list.Length; i++)
                {
                    double r = 0;
                    if (list[i] == "√")
                    {
                        r = Math.Pow(double.Parse(list[i + 1]), 1/double.Parse(stack.Pop()));
                        stack.Push(r.ToString());
                        i++;
                    }
                    else
                    {
                        stack.Push(list[i]);
                    }
                }

                list = stack.Reverse().ToArray();

            }

            //////////////////////-----------------------------mutiplyDivide
            Queue<string> MutiDiv = new Queue<string>();
            Stack<string> MutiDiv2 = new Stack<string>();
            for (int i = 0; i < list.Length; i++)
            {
                MutiDiv.Enqueue(list[i]);
            }

            while (true)
            {
                string x = MutiDiv.Dequeue();
                if (x != "*" && x != "/")
                {
                    MutiDiv2.Push(x);
                }
                else
                {
                    double temp2 = 0;
                    if (x == "*")
                    {
                        double t1 = double.Parse(MutiDiv2.Pop());
                        double t2 = double.Parse(MutiDiv.Dequeue());
                        temp2 = t1 * t2;
                        MutiDiv2.Push(temp2.ToString());
                    }
                    if (x == "/")
                    {
                        double t1 = double.Parse(MutiDiv2.Pop());
                        double t2 = double.Parse(MutiDiv.Dequeue());
                        if (t2 == 0)
                        {
                            return "Divide by zero";
                        }
                        else
                        {
                            temp2 = t1 / t2;
                            MutiDiv2.Push(temp2.ToString());
                        }
                    }
                }
                if (MutiDiv.Count == 0)
                {
                    break;
                }
            }

            ////////////////////////--------------------plusMinus
            Stack<string> plusMinus = new Stack<string>();
            while (true)
            {
                if (MutiDiv2.Count == 0)
                {
                    break;
                }
                plusMinus.Push(MutiDiv2.Pop());
            }

            Stack<string> result = new Stack<string>();
            while (true)
            {
                if (plusMinus.Count == 0)
                {
                    break;
                }
                else
                {
                    string z = plusMinus.Pop();

                    if (z != "+" && z != "-")
                    {
                        result.Push(z);
                    }
                    else
                    {
                        if (z == "+")
                        {
                            double r1 = double.Parse(result.Pop());
                            double r2 = double.Parse(plusMinus.Pop());
                            double r3 = r1 + r2;
                            result.Push(r3.ToString());
                        }
                        if (z == "-")
                        {
                            double r1 = double.Parse(result.Pop());
                            double r2 = double.Parse(plusMinus.Pop());
                            double r3 = r1 - r2;
                            result.Push(r3.ToString());
                        }
                    }
                }
            }
            return result.Pop();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string Calc(string str)
        {
            string b = str;
            if (b.Contains("Atan"))
            {
                b = b.Replace("Atan", "K");
            }
            if (b.Contains("log10"))
            {
                b = b.Replace("log10", "D");
            }
            if (b.Contains("sin"))
            {
                b = b.Replace("sin", "A");
            }
            if (b.Contains("cos"))
            {
                b = b.Replace("cos", "B");
            }
            if (b.Contains("tan"))
            {
                b = b.Replace("tan", "C");
            }
            if (b.Contains("log2"))
            {
                b = b.Replace("log2", "F");
            }
            if (b.Contains("Rad"))
            {
                b = b.Replace("Rad", "H");
            }
            if (b.Contains("In"))
            {
                b = b.Replace("In", "J");
            }
           

            string a = "";
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != ' ')
                {
                    a += b[i];
                }
            }

            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != ')')
                {
                    stack.Push(a[i].ToString());
                }
                else
                {
                    Stack<string> x = new Stack<string>();
                    string y = "";

                    while (stack.Peek() != "(")
                    {
                        x.Push(stack.Pop());
                    }

                    //Remove '('
                    stack.Pop();
                    while (true)
                    {
                        if (x.Count == 0) break;
                        y += x.Pop();
                    }

                    y = CalcPlusMinusMutiplyDivide(y);////

                    if (stack.Count == 0)
                    {
                        y = '[' + y + ']';

                        stack.Push(y);
                    }
                    else
                    {
                        string r = "";
                        switch (stack.Peek())
                        {
                            case "+":
                            case "-":
                            case "*":
                            case "/":
                            case "^":
                            case "√":
                            case "(":
                                y = '[' + y + ']';
                                stack.Push(y);
                                break;
                            case "A"://sin
                                stack.Pop();
                                r = Math.Sin(double.Parse(y)).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            case "B"://cos
                                stack.Pop();
                                r = Math.Cos(double.Parse(y)).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            case "C"://tan
                                stack.Pop();
                                r = Math.Tan(double.Parse(y)).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            case "D"://log10
                                stack.Pop();
                                r = Math.Log10(double.Parse(y)).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            case "F"://log2
                                stack.Pop();
                                r = Math.Log(double.Parse(y), 2).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            case "H"://rad
                                stack.Pop();
                                r = (double.Parse(y) / 57.3).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            case "J"://In
                                stack.Pop();
                                r = Math.Log(double.Parse(y), Math.E).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            case "K"://Atan
                                stack.Pop();
                                r = Math.Atan(double.Parse(y)).ToString();
                                r = '[' + r + ']';
                                stack.Push(r.ToString());
                                break;
                            default:
                                break;
                        }
                    }

                }
            }
            var c = stack.Reverse().ToArray();
            string d = "";
            for (int i = 0; i < c.Length; i++)
            {
                d += c[i];
            }
            string g = CalcPlusMinusMutiplyDivide(d);
            double testNum = 0;
            bool IsNum = false;
            IsNum=double.TryParse(g,out testNum);
            if (IsNum == true)
            {
                return g;
            }
            else
            {
                return "Formula is wrong!";
            }
            
        }
        private bool isEnter = false;
        private string input = "";

        private void button48_Click(object sender, EventArgs e)//0
        {
            if (isEnter == false&&textBox1.Text=="0")
            {
                isEnter = false;
            }
            else
            {
                textBox1.Text += "0";
            }
        }
        private void button32_Click(object sender, EventArgs e)//.
        {
               textBox1.Text+=".";
            isEnter = true;
        }
        private void button47_Click(object sender, EventArgs e)//1
        {
            if (isEnter == true)
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox1.Text = "1";
                isEnter = true;
            }
        }

        private void button46_Click(object sender, EventArgs e)//2
        {
            if (isEnter == true)
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Text = "2";
                isEnter = true;
            }

        }

        private void button45_Click(object sender, EventArgs e)//3
        { 
            if (isEnter == true)
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Text = "3";
                isEnter = true;
            }
        }

        private void button44_Click(object sender, EventArgs e)//4
        {
            if (isEnter == true)
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Text = "4";
                isEnter = true;
            }
        }

        private void button42_Click(object sender, EventArgs e)//5
        {
            if (isEnter == true)
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Text = "5";
                isEnter = true;
            }
        }

        private void button41_Click(object sender, EventArgs e)//6
        {
            if (isEnter == true)
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Text = "6";
                isEnter = true;
            }
        }

        private void button40_Click(object sender, EventArgs e)//7
        {
            if (isEnter == true)
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Text = "7";
                isEnter = true;
            }
        }

        private void button39_Click(object sender, EventArgs e)//8
        {
            if (isEnter == true)
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Text = "8";
                isEnter = true;
            }
        }

        private void button38_Click(object sender, EventArgs e)//9
        {
            if (isEnter == true)
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Text = "9";
                isEnter = true;
            }
        }

        private void button43_Click(object sender, EventArgs e)//+
        {
            if (isEnter == true)
            {
                textBox1.Text += "+";
            }
            else
            {
                textBox1.Text = "+";
                isEnter = true;
            }
        }

        private void button37_Click(object sender, EventArgs e)//-
        {
            if (isEnter == true)
            {
                textBox1.Text += "-";
            }
            else
            {
                textBox1.Text = "-";
                isEnter = true;
            }
        }

        private void button33_Click(object sender, EventArgs e)//Rad
        {
            if (isEnter == true)
            {
                textBox1.Text += "Rad(";
            }
            else
            {
                textBox1.Text = "Rad(";
                isEnter = true;
            }
        }

        private void button62_Click(object sender, EventArgs e)//e
        {
            if (isEnter == true)
            {
                textBox1.Text += "2.718";
            }
            else
            {
                textBox1.Text = "2.718";
                isEnter = true;
            }
        }

        private void button61_Click(object sender, EventArgs e)//PI
        {
            if (isEnter == true)
            {
                textBox1.Text += "3.14";
            }
            else
            {
                textBox1.Text = "3.14";
                isEnter = true;
            }
        }

        private void button34_Click(object sender, EventArgs e)//Atan
        {
            if (isEnter == true)
            {
                textBox1.Text += "Atan(";
            }
            else
            {
                textBox1.Text = "Atan(";
                isEnter = true;
            }
        }

        private void button36_Click(object sender, EventArgs e)//e^x
        {
            if (isEnter == true)
            {
                textBox1.Text += "2.718^";
            }
            else
            {
                textBox1.Text = "2.718^";
                isEnter = true;
            }
        }

        private void button64_Click(object sender, EventArgs e)//In
        {
            if (isEnter == true)
            {
                textBox1.Text += "In(";
            }
            else
            {
                textBox1.Text = "In(";
                isEnter = true;
            }
        }

        private void button55_Click(object sender, EventArgs e)//sin
        {
            if (isEnter == true)
            {
                textBox1.Text += "sin(";
            }
            else
            {
                textBox1.Text = "sin(";
                isEnter = true;
            }
        }

        private void button54_Click(object sender, EventArgs e)//cos
        {
            if (isEnter == true)
            {
                textBox1.Text += "cos(";
            }
            else
            {
                textBox1.Text = "cos(";
                isEnter = true;
            }
        }

        private void button53_Click(object sender, EventArgs e)//tan
        {
            if (isEnter == true)
            {
                textBox1.Text += "tan(";
            }
            else
            {
                textBox1.Text = "tan(";
                isEnter = true;
            }
        }

        private void button65_Click(object sender, EventArgs e)//!
        {
            if (isEnter == true)
            {
                textBox1.Text += "!";
            }
            else
            {
                textBox1.Text = "!";
                isEnter = true;
            }
        }

        private void button66_Click(object sender, EventArgs e)//*
        {
            if (isEnter == true)
            {
                textBox1.Text += "*";
            }
            else
            {
                textBox1.Text = "*";
                isEnter = true;
            }
        }

        private void button30_Click(object sender, EventArgs e)//  /
        {
            if (isEnter == true)
            {
                textBox1.Text += "/";
            }
            else
            {
                textBox1.Text = "/";
                isEnter = true;
            }
        }

        private void button31_Click(object sender, EventArgs e)//x^3
        {
            if (isEnter == true)
            {
                textBox1.Text += "^3";
            }
            else
            {
                textBox1.Text = "^3";
                isEnter = true;
            }
        }

        private void button56_Click(object sender, EventArgs e)//x^y
        {
            if (isEnter == true)
            {
                textBox1.Text += "^";
            }
            else
            {
                textBox1.Text = "^";
                isEnter = true;
            }
        }

        private void button57_Click(object sender, EventArgs e)//x√y
        {
            if (isEnter == true)
            {
                textBox1.Text += "√";
            }
            else
            {
                textBox1.Text = "√";
                isEnter = true;
            }
        }

        private void button59_Click(object sender, EventArgs e)//log2
        {
            if (isEnter == true)
            {
                textBox1.Text += "log2(";
            }
            else
            {
                textBox1.Text = "log2(";
                isEnter = true;
            }
        }

        private void button63_Click(object sender, EventArgs e)//log10
        {
            if (isEnter == true)
            {
                textBox1.Text += "log10(";
            }
            else
            {
                textBox1.Text = "log10(";
                isEnter = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)//(
        {
            if (isEnter == true)
            {
                textBox1.Text += "(";
            }
            else
            {
                textBox1.Text = "(";
                isEnter = true;
            }
        }

        private void button26_Click(object sender, EventArgs e)//)
        {
            if (isEnter == true)
            {
                textBox1.Text += ")";
            }
            else
            {
                textBox1.Text = ")";
                isEnter = true;
            }
        }

        private void button28_Click(object sender, EventArgs e)//x^2
        {
            if (isEnter == true)
            {
                textBox1.Text += "^2";
            }
            else
            {
                textBox1.Text = "^2";
                isEnter = true;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (isEnter == true)
            {
                textBox1.Text += "2√";
            }
            else
            {
                textBox1.Text = "2√";
                isEnter = true;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (isEnter == true)
            {
                textBox1.Text += "3√";
            }
            else
            {
                textBox1.Text = "3√";
                isEnter = true;
            }
        }

        private void button51_Click(object sender, EventArgs e)//%
        {

            if (isEnter == true)
            {
                textBox1.Text += "/100";
            }
            else
            {
                textBox1.Text = "/100";
                isEnter = true;
            }
        }
        private void button58_Click(object sender, EventArgs e)//1/x
        {
            if (isEnter == true)
            {
                textBox1.Text += "1/";
            }
            else
            {
                textBox1.Text = "1/";
                isEnter = true;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            double y=x.Next(0, 10000);
            if (isEnter == true)
            {
                textBox1.Text += y.ToString();
            }
            else
            {
                textBox1.Text = y.ToString();
                isEnter = true;
            }
        }
        private void button52_Click(object sender, EventArgs e)//C
        {
            textBox1.Text = "0";
            isEnter = false;
            input = "";
        }

        private void button50_Click(object sender, EventArgs e)//Back
        {
            if (textBox1.Text.Length <= 1)
            {
                textBox1.Text = "0";
                isEnter = false;
                input = "";
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            input = textBox1.Text;
            try
            {
                textBox1.Text = Calc(input);
            }
            catch
            {
                textBox1.Text = " Formula are wrong";
            }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="binary"></param>
        /// <param name="e"></param>
        /// 
        private bool Enable = true;
        private void button78_Click(object sender, EventArgs e)//0
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button67_Click(object sender, EventArgs e)//1
        {
            if (Enable == true)
            {
                textBox1.Text = "1";
                Enable = false;
            }
            else
            {
                textBox1.Text += "1";
            }
            
        }

        private void button80_Click(object sender, EventArgs e)//2
        {
            if (Enable == true)
            {
                textBox1.Text = "2";
                Enable = false;
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button82_Click(object sender, EventArgs e)//3
        {
            if (Enable == true)
            {
                textBox1.Text = "3";
                Enable = false;
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button71_Click(object sender, EventArgs e)//4
        {
            if (Enable == true)
            {
                textBox1.Text = "4";
                Enable = false;
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button73_Click(object sender, EventArgs e)//5
        {
            if (Enable == true)
            {
                textBox1.Text = "5";
                Enable = false;
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button75_Click(object sender, EventArgs e)//6
        {
            if (Enable == true)
            {
                textBox1.Text = "6";
                Enable = false;
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button81_Click(object sender, EventArgs e)//7
        {
            if (Enable == true)
            {
                textBox1.Text = "7";
                Enable = false;
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button83_Click(object sender, EventArgs e)//8
        {
            if (Enable == true)
            {
                textBox1.Text = "8";
                Enable = false;
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button85_Click(object sender, EventArgs e)//9
        {
            if (Enable == true)
            {
                textBox1.Text = "9";
                Enable = false;
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button70_Click(object sender, EventArgs e)//C
        {
            textBox1.Text = "0";
            button69.Enabled = true;
            button76.Enabled = true;
            Enable = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (textBox1.Text.Contains("2")|| textBox1.Text.Contains("3")||textBox1.Text.Contains("4") ||
                        textBox1.Text.Contains("5") || textBox1.Text.Contains("6") || textBox1.Text.Contains("7") ||
                        textBox1.Text.Contains("8") || textBox1.Text.Contains("9"))
     
                {
                    button76.Enabled = false;
                    button69.Enabled = true;
                }
                else
                {
                    button76.Enabled = true;
                    button69.Enabled = true;
                }
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
           textBox1.Text= ConvertTOBinary(textBox1.Text);
            button69.Enabled = false;
            button76.Enabled = true;
        }

        public static string ConvertTOBinary(string a)
        {
            string temp = "";
            string result = "";
            int b = int.Parse(a);
            while (b > 0)
            {
                temp += b % 2;
                b /= 2;
            }
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                result += temp[i];
            }
            return result;
        }

        public static string ConvertTODecimal(string a)
        {
            int idx = 0;
            double x = 0;
            for (int i = a.Length-1; i >=0; i--)
            {
                if (a[idx++] == '1')
                {
                    x += Math.Pow(2, i);
                }
               
            }
            return x.ToString();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            button76.Enabled = false;
            button69.Enabled = true;
            textBox1.Text = ConvertTODecimal(textBox1.Text);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

