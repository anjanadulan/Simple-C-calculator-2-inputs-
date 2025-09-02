using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculato_2Inputs
{
    public partial class Form1 : Form
    {
        // declare globle variables
        double n1, n2, ans;
        string op,eq; //oparator



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //checking equal sign preesed or not, if preesed clear all befor enter number again
            if (this.Oparate.Text == "=")   // checking
            {
                this.Display.Clear();
                this.Oparate.Clear();
            }

            this.Display.Text = this.Display.Text + "9";
        }

        //Clear button
        private void btnClr_Click(object sender, EventArgs e)
        {
            this.Display.Clear();
            this.Oparate.Clear();
        }

        //Oparators
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //checking empty text spaces
            if (string.IsNullOrWhiteSpace(Display.Text))   // check if empty
            {
                MessageBox.Show("Please enter a number first!");
                return;
            }


            n1 = Convert.ToDouble(this.Display.Text);
            this.Oparate.Clear();
            this.Oparate.Text = "+";
            op = "+";
            this.Display.Clear();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //checking empty text spaces
            if (string.IsNullOrWhiteSpace(Display.Text))   // check if empty
            {
                MessageBox.Show("Please enter a number first!");
                return;
            }


            n1 = Convert.ToDouble(this.Display.Text);
            this.Oparate.Clear();
            this.Oparate.Text = "-";
            op = "-";
            this.Display.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            //checking empty text spaces
            if (string.IsNullOrWhiteSpace(Display.Text))   // check if empty
            {
                MessageBox.Show("Please enter a number first!");
                return;
            }

            // equal pressed
            eq = "=";


            n1 = Convert.ToDouble(this.Display.Text);
            this.Oparate.Clear();
            this.Oparate.Text = "*";
            op = "*";
            this.Display.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            //checking empty text spaces
            if (string.IsNullOrWhiteSpace(Display.Text))   // check if empty
            {
                MessageBox.Show("Please enter a number first!");
                return;
            }


            n1 = Convert.ToDouble(this.Display.Text);
            this.Oparate.Clear();
            this.Oparate.Text = "/";
            op = "/";
            this.Display.Clear();

        }

        //Equal function
        private void btnEq_Click(object sender, EventArgs e)
        {
            //clear oprand diplaying and disp =
            this.Oparate.Clear();
            this.Oparate.Text = "=";

            n2 = Convert.ToDouble(this.Display.Text);

            if (op == "+")
            {
                ans = n1 + n2;
                this.Display.Text = ans.ToString();
            }
            else if (op == "-")
            {
                ans = n1 - n2;
                this.Display.Text = ans.ToString();

            }
            else if (op == "*")
            {
                ans = n1 * n2;
                this.Display.Text = ans.ToString();

            }
            else if (op == "/")
            {
                ans = n1 / n2;
                this.Display.Text = ans.ToString();

            }




        }


    }
}
