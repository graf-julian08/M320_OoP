using System;
using System.Drawing.Text;

namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string newnum = string.Empty;
        private string newnum2 = string.Empty;
        private string operationsym = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "1";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "1";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "1";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "1";
                newnum2 = outputfield.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "2";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "2";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "2";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "2";
                newnum2 = outputfield.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "3";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "3";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "3";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "3";
                newnum2 = outputfield.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "4";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "4";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "4";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "4";
                newnum2 = outputfield.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "5";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "5";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "5";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "5";
                newnum2 = outputfield.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "6";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "6";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "6";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "6";
                newnum2 = outputfield.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "7";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "7";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "7";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "7";
                newnum2 = outputfield.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "8";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "8";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "8";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "8";
                newnum2 = outputfield.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "9";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "9";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "9";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "9";
                newnum2 = outputfield.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (string.IsNullOrEmpty(newnum))
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "0";
                    newnum = outputfield.Text;
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "0";
                    newnum2 = outputfield.Text;
                }
            }
            else if (string.IsNullOrEmpty(newnum))
            {
                outputfield.Text += "0";
                newnum = outputfield.Text;
            }
            else
            {
                outputfield.Text += "0";
                newnum2 = outputfield.Text;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            outputfield.Text = "+";
            this.operationsym = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            outputfield.Text = "-";
            this.operationsym = "-";
        }

        private void mal_Click(object sender, EventArgs e)
        {
            outputfield.Text = "*";
            this.operationsym = "*";
        }

        private void durch_Click(object sender, EventArgs e)
        {
            outputfield.Text = "/";
            this.operationsym = "/";
        }

        private void gleich_Click(object sender, EventArgs e)
        {
            // Strings in ints umwandeln und rechnen (Logik bleibt gleich)
            int n1 = int.Parse(newnum);
            int n2 = int.Parse(newnum2);

            if (operationsym == "+")
            {
                int resultat = n1 + n2;
                outputfield.Text = resultat.ToString();
            }
            else if (operationsym == "-")
            {
                int resultat = n1 - n2;
                outputfield.Text = resultat.ToString();
            }
            else if (operationsym == "*")
            {
                int resultat = n1 * n2;
                outputfield.Text = resultat.ToString();
            }
            else if (operationsym == "/")
            {
                int resultat = n1 / n2;
                outputfield.Text = resultat.ToString();
            }
        }
    }
}
