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

        private decimal newnum;
        private decimal newnum2;
        private string operationsym = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "1";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "1";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "1";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "1";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "2";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "2";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "2";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "2";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "3";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "3";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "3";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "3";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "4";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "4";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "4";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "4";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "5";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "5";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "5";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "5";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "6";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "6";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "6";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "6";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "7";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "7";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "7";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "7";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "8";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "8";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "8";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "8";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "9";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "9";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "9";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "9";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (outputfield.Text == "+" || outputfield.Text == "-" || outputfield.Text == "*" || outputfield.Text == "/")
            {
                if (operationsym == "")
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "0";
                    decimal.TryParse(outputfield.Text, out newnum);
                }
                else
                {
                    outputfield.Text = string.Empty;
                    outputfield.Text += "0";
                    decimal.TryParse(outputfield.Text, out newnum2);
                }
            }
            else
                if (operationsym == "")
            {
                outputfield.Text += "0";
                decimal.TryParse(outputfield.Text, out newnum);
            }
            else
            {
                outputfield.Text += "0";
                decimal.TryParse(outputfield.Text, out newnum2);
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            outputfield.Text = "+";
            this.operationsym = "+";

            // Console.WriteLine("Operation: " + operationsym);
            // Console.WriteLine("Number: " + newnum);
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
            if (operationsym == "+")
            {
                decimal resultat = newnum + newnum2;
                outputfield.Text = resultat.ToString("0.#######");
            }
            else if (operationsym == "-")
            {
                decimal resultat = newnum - newnum2;
                outputfield.Text = resultat.ToString("0.#######");
            }

            else if (operationsym == "*")
            {
                decimal resultat = newnum * newnum2;
                outputfield.Text = resultat.ToString("0.#######");
            }

            else if (operationsym == "/")
            {
                decimal resultat = newnum / newnum2;
                outputfield.Text = resultat.ToString("0.#######");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            outputfield.Text = string.Empty;
            operationsym = string.Empty;
            newnum = 0;
            newnum2 = 0;
        }
    }
}

// Wenn ich noch will, dass man die Operatoren auf das Resultat anwenden kann, müsste ich beim operationsym machen, dass es sich auf das resultat bezieht und am Schluss resultat als newnum speichern.
