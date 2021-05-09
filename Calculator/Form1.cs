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
        List<double> numsForSumming = new List<double>();
        List<char> calculations = new List<char>();

        double sum = 0;
        double memorySum = 0;

        bool newCalc = true;
        bool nextNum = true;
        bool divByZero = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            if (txtResult.Text != "0")
            {
                txtResult.Text += btn0.Text;
            }
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn1.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn2.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn3.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn4.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn5.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn6.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn7.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn8.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (newCalc == true)
            {
                txtResult.Text = null;
                newCalc = false;
            }
            txtResult.Text += btn9.Text;
            if (divByZero == true)
            {
                divByZero = false;
            }
        }
        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (divByZero == true)
            {
                txtResult.Text = null;
                divByZero = false;
            }
            if (string.IsNullOrEmpty(txtResult.Text))
            {
                txtResult.Text += "0,";
            }
            else
            {
                string symbol = txtResult.Text.Last<char>().ToString();
                if (symbol != "," && symbol != " " && symbol != "√")
                {
                    if (nextNum == true)
                    {
                        txtResult.Text += btnpoint.Text;
                        if (newCalc == true)
                        {
                            newCalc = false;
                        }

                    }
                }
            }
            if (nextNum == true)
            {
                nextNum = false;
            }
            if (newCalc == true)
            {

                newCalc = false;
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (divByZero == true)
            {
                txtResult.Text = null;
                divByZero = false;
            }
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                string symbol = txtResult.Text.Trim().Last<char>().ToString();
                if (symbol != "√")
                {
                    if (symbol != "*" && symbol != "/" && symbol != "-" && symbol != "+")
                    {
                        if (symbol != ",")
                        {
                            if (newCalc == true)
                            {

                                newCalc = false;
                            }

                            //  numsForSumming.Add(Convert.ToDouble(symbol.ToString()));
                            // calculations.Add(char.Parse(btnPlus.Text));
                            txtResult.Text += " + ";
                            nextNum = true;
                        }

                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder(txtResult.Text);
                        sb[sb.Length - 2] = '+';
                        txtResult.Text = sb.ToString();
                        //calculations[calculations.Count - 1] = '+';
                    }
                }
            }

        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (divByZero == true)
            {
                txtResult.Text = null;
                divByZero = false;
            }
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                string symbol = txtResult.Text.Trim().Last<char>().ToString();
                if (symbol != "√")
                {
                    if (symbol != "*" && symbol != "/" && symbol != "+" && symbol != "-")
                    {
                        if (symbol != ",")
                        {
                            if (newCalc == true)
                            {

                                newCalc = false;
                            }

                            //numsForSumming.Add(Convert.ToDouble(symbol.ToString()));
                            // calculations.Add(char.Parse(btnMinus.Text));
                            txtResult.Text += " - ";
                            nextNum = true;
                        }

                    }
                    else
                    {

                        StringBuilder sb = new StringBuilder(txtResult.Text);
                        sb[sb.Length - 2] = '-';
                        txtResult.Text = sb.ToString();
                        //calculations[calculations.Count - 1] = '-';
                        //txtResult.Text += "-";
                    }
                }
            }
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            if (divByZero == true)
            {
                txtResult.Text = null;
                divByZero = false;
            }
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                string symbol = txtResult.Text.Trim().Last<char>().ToString();
                if (symbol != "√")
                {

                    if (symbol != "-" && symbol != "/" && symbol != "+" && symbol != "*")
                    {
                        if (symbol != ",")
                        {
                            if (newCalc == true)
                            {

                                newCalc = false;
                            }

                            // numsForSumming.Add(Convert.ToDouble(symbol.ToString()));
                            //calculations.Add(char.Parse(btnMult.Text));
                            txtResult.Text += " * ";
                            nextNum = true;
                        }
                    }
                    else
                    {

                        StringBuilder sb = new StringBuilder(txtResult.Text);
                        sb[sb.Length - 2] = '*';
                        txtResult.Text = sb.ToString();
                        // calculations[calculations.Count - 1] = '*';
                    }
                }
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (divByZero == true)
            {
                txtResult.Text = null;
                divByZero = false;
            }
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                string symbol = txtResult.Text.Trim().Last<char>().ToString();
                if (symbol != "√")
                {

                    if (symbol != "*" && symbol != "-" && symbol != "+" && symbol != "/")
                    {
                        if (symbol != ",")
                        {
                            if (newCalc == true)
                            {

                                newCalc = false;
                            }

                            //numsForSumming.Add(Convert.ToDouble(symbol.ToString()));
                            //calculations.Add(char.Parse(btnDiv.Text));
                            txtResult.Text += " / ";
                            nextNum = true;
                        }
                    }
                    else
                    {

                        StringBuilder sb = new StringBuilder(txtResult.Text);
                        sb[sb.Length - 2] = '/';
                        txtResult.Text = sb.ToString();
                        //calculations[calculations.Count - 1] = '/';
                    }
                }
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                int count = 0;
                string symbol = txtResult.Text.Trim().Last<char>().ToString();
                if (symbol != "+" && symbol != "*" && symbol != "/" && symbol != "-" && symbol != "," && symbol != "√")
                {
                    numsForSumming = txtResult.Text.Replace('√',' ').Split('√', '+', '-', '*', '/').Select(double.Parse).ToList();
                    foreach (var cal in txtResult.Text)
                    {
                        if (cal == '+' || cal == '-' || cal == '*' || cal == '/')
                        {
                            calculations.Add(cal);
                            count++;
                        }
                        else if (cal == '√')
                        {
                            numsForSumming[count] = Math.Sqrt(numsForSumming[count]);
                        }
                    }
                    // numsForSumming.Add(double.Parse(txtResult.Text[txtResult.Text.Length-1].ToString()));
                    txtResult.Text = null;
                    sum += numsForSumming[0];
                    for (int i = 0; i < calculations.Count; i++)
                    {
                        if (calculations[i] == '+')
                        {
                            sum += numsForSumming[i + 1];
                        }
                        else if (calculations[i] == '-')
                        {
                            sum -= numsForSumming[i + 1];
                        }
                        else if (calculations[i] == '*')
                        {
                            sum *= numsForSumming[i + 1];
                        }
                        else if (calculations[i] == '/')
                        {
                            if (numsForSumming[i + 1] == 0)
                            {
                                divByZero = true;
                            }
                            sum /= numsForSumming[i + 1];
                        }
                    }
                    if (divByZero == true)
                    {
                        txtResult.Text = "Cannot be divided by 0";
                    }
                    else
                    {
                        txtResult.Text = sum.ToString();
                    }
                    numsForSumming.Clear();
                    calculations.Clear();
                    sum = 0;
                    newCalc = true;
                }

            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string symbol = txtResult.Text.Last<char>().ToString();
            StringBuilder sb = new StringBuilder(txtResult.Text);
            if (symbol == " ")
            {
                sb.Remove(sb.Length - 2, 2);
            }
            else
            {
                sb.Remove(sb.Length - 1, 1);
            }
            txtResult.Text = sb.ToString();
        }//√

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (divByZero == true)
            {
                txtResult.Text = null;
                divByZero = false;
            }

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                txtResult.Text += "√";
            }
            else
            {
                string symbol = txtResult.Text.Trim().Last<char>().ToString();
                if (symbol != "*" && symbol != "-" && symbol != "+" && symbol != "/")
                {
                    if (symbol != ",")
                    {
                        if (newCalc == true)
                        {

                            newCalc = false;
                        }

                        //numsForSumming.Add(Convert.ToDouble(symbol.ToString()));
                        //calculations.Add(char.Parse(btnDiv.Text));
                        txtResult.Text += " * √ ";
                        nextNum = true;
                    }
                }
                else
                {

                    txtResult.Text += "√ ";
                }
            }
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memorySum += txtResult.Text.Replace('√', ' ')
                .Split('√', '+', '-', '*', '/')
                .Select(double.Parse).ToList().Last();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if (memorySum > 0)
            {
                txtResult.Text = memorySum.ToString();
                newCalc = true;
            }
        }

        private void btnMN_Click(object sender, EventArgs e)
        {
            memorySum -= txtResult.Text.Replace('√', ' ')
               .Split('√', '+', '-', '*', '/')
               .Select(double.Parse).ToList().Last();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memorySum = 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }
    }
}