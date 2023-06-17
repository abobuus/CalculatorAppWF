using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CalculatorAppWF
{
    public partial class Form1 : Form
    {
        Calculator C;

        public Form1()
        {
            InitializeComponent();

            C = new Calculator();

            label1.Text = "0";
        }

        private void CorrectNumber()
        {
            if (label1.Text[0] == '0' && (label1.Text.IndexOf(",") != 1))
                label1.Text = label1.Text.Remove(0, 1);

            if (label1.Text[0] == '-')
                if (label1.Text[1] == '0' && (label1.Text.IndexOf(",") != 2))
                    label1.Text = label1.Text.Remove(1, 1);
        }

        private bool CanPress()
        {   
            if (!buttonSum.Enabled)
                return false;

            if (!buttonSubtraction.Enabled)
                return false;

            if (!buttonMultiplication.Enabled)
                return false;

            if (!buttonDivision.Enabled)
                return false;
            
            if (!buttonSqrt.Enabled)
                return false;

            if (!buttonReverse.Enabled)
                return false;

            if (!buttonMC.Enabled)
                return false;

            if (!buttonMR.Enabled)
                return false;

            if (!buttonMS.Enabled)
                return false;

            if (!buttonMPlus.Enabled)
                return false;

            if (!buttonMMinus.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {   
            buttonSum.Enabled = true;
            buttonSubtraction.Enabled = true;
            buttonMultiplication.Enabled = true;
            buttonDivision.Enabled = true;
            buttonSqrt.Enabled = true;
            buttonPercent.Enabled = true;
            buttonReverse.Enabled = true;
        }

        private void buttonStepBack_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length != 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);

                if (label1.Text.Length == 0)
                    label1.Text += "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            label1.Text = "0";

            C.Clear_A();
            FreeButtons();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";

            C.Clear_A();
            FreeButtons();
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (label1.Text.Split(',').Length - 1 == 0)
                label1.Text += ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";

            CorrectNumber();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonSum.Enabled = false;

                label1.Text = "0";
            }
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonSubtraction.Enabled = false;

                label1.Text = "0";
            }
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonMultiplication.Enabled = false;

                label1.Text = "0";
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonDivision.Enabled = false;

                label1.Text = "0";
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonSqrt.Enabled = false;

                label1.Text = "0";
            }
        }

        private void buttonOpposite_Click(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
                label1.Text = label1.Text.Remove(0, 1);
            else
                label1.Text = "-" + label1.Text;
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonReverse.Enabled = false;

                label1.Text = "0";
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonPercent.Enabled = false;

                label1.Text = "0";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!buttonSum.Enabled)
                label1.Text = C.Sum(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonSubtraction.Enabled)
                label1.Text = C.Subtraction(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonMultiplication.Enabled)
                label1.Text = C.Multiplication(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonDivision.Enabled)
                label1.Text = C.Division(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonSqrt.Enabled)
                label1.Text = C.Sqrt().ToString();

            if (!buttonPercent.Enabled)
                label1.Text = C.Persent(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonReverse.Enabled)
                label1.Text = C.Reverse().ToString();

            C.Clear_A();
            FreeButtons();
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(label1.Text));
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(label1.Text));

        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            if (CanPress())
                C.Memory_Get(Convert.ToDouble(label1.Text));
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            if (CanPress())
                label1.Text = C.Memory_Show().ToString();
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            if (CanPress())
                C.Memory_Clear();
        }
    }
}
