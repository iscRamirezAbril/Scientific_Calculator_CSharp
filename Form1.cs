using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cientific_Calculator
{
    public partial class Scientific_Calculator : Form
    {
        public Scientific_Calculator()
        {
            InitializeComponent();
        }

        // Variable declaration
        double num1, num2, Memory;
        string operation;

        // Declaration of some objects...
        Operations.sin ObjSin = new Operations.sin();
        Operations.cos ObjCos = new Operations.cos();
        Operations.sinh ObjSinh = new Operations.sinh();
        Operations.cosh ObjCosh = new Operations.cosh();

        // "1" Button
        private void Button_1_Click(object sender, EventArgs e)
        {
            Principal.Text += "1";
        }

        // "2" Button
        private void Button_2_Click(object sender, EventArgs e)
        {
            Principal.Text += "2";
        }

        // "3" Button
        private void Button_3_Click(object sender, EventArgs e)
        {
            Principal.Text += "3";
        }

        // "4" Button
        private void Button_4_Click(object sender, EventArgs e)
        {
            Principal.Text += "4";
        }

        // "5" Button
        private void Button_5_Click(object sender, EventArgs e)
        {
            Principal.Text += "5";
        }

        // "6" Button
        private void Button_6_Click(object sender, EventArgs e)
        {
            Principal.Text += "6";
        }

        // "7" Button
        private void Button_7_Click(object sender, EventArgs e)
        {
            Principal.Text += "7";
        }

        // "8" Button
        private void Button_8_Click(object sender, EventArgs e)
        {
            Principal.Text += "8";
        }

        // "9" Button
        private void Button_9_Click(object sender, EventArgs e)
        {
            Principal.Text += "9";
        }

        // "dot" Button
        private void dot_Button_Click(object sender, EventArgs e)
        {
            Principal.Text += ".";
        }

        // "+" Button
        private void Sum_Button_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "-" Button
        private void Sust_Button_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "x" Button
        private void Mult_Button_Click(object sender, EventArgs e)
        {
            operation = "x";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "÷" Button
        private void Div_Button_Click(object sender, EventArgs e)
        {
            operation = "÷";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "√" Button
        private void SqurRoot_Button_Click(object sender, EventArgs e)
        {
            operation = "√";
            num1 = Convert.ToDouble(Principal.Text);

            // if condition
            if (num1 >= 0)
            {
                Operations.SquR ObjSqu = new Operations.SquR(); // Creation of an object
                double SquR = ObjSqu.Square(num1);
                Principal.Text = SquR.ToString();
            }

            // else
            else
            {
                Principal.Text = "Invalid Input"; // Error Message
            }
        }

        // "=" Button
        private void Equals_Button_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(Principal.Text);

            // switch - case
            switch(operation)
            {
                // Case 1 - Sum
                case "+":
                    Operations.SumOp Objsum = new Operations.SumOp(); // Creation of an object
                    double Sum = Objsum.Sum(num1, num2); // Method call
                    Principal.Text = Sum.ToString();
                    break;

                // Case 2 - Substraction
                case "-":
                    Operations.SustOp Objsust = new Operations.SustOp(); // Creation of an object
                    double Sustraction = Objsust.Sust(num1, num2); // Method call
                    Principal.Text = Sustraction.ToString();
                    break;

                // Case 3 - Multiplication
                case "x":
                    Operations.MultOp Objmult = new Operations.MultOp(); // Creation of an object
                    double Multiplication = Objmult.Mult(num1, num2); // Method call
                    Principal.Text = Multiplication.ToString();
                    break;

                // Case 4 - Division
                case "÷":

                    // if condition
                    if (num2 == 0)
                    {
                        Principal.Text = "Math Error"; // Error Message
                    }

                    // else
                    else
                    {
                        Operations.DivOp ObjDiv = new Operations.DivOp(); // Creation of an object
                        double Division = ObjDiv.Div(num1, num2); // Method call
                        Principal.Text = Division.ToString();
                    }
                    break;

                // Case 5 - Exp
                case "Exp":
                    Operations.Exp ObjExp = new Operations.Exp(); // Creation of an object
                    double Exponent = ObjExp.NumExp(num1, num2); // Method call
                    Principal.Text = Exponent.ToString();
                    break;

                // Case 6 - 10 Raised to x
                case "10x":
                    num1 = Convert.ToDouble(Principal.Text);
                    Operations.Raised10 ObjeRaised10 = new Operations.Raised10(); // Creation of an object
                    double TenR = ObjeRaised10.TenRx(num1); // Method call
                    Principal.Text = TenR.ToString();
                    break;
            }
        }

        // "-/+" Button
        private void NegPos_Button_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Principal.Text);
            num1 *= -1; // Multiply the current number by "-1"
            Principal.Text = num1.ToString();
        }

        // "CE" Button
        private void CE_Button_Click(object sender, EventArgs e)
        {
            Principal.Text = string.Empty; // Clear / Empty the TextBox
        }

        // "M-" Button
        // Subtracts the displayed number in the TextBox from another number in memory 
        // but doesn´t show the subtraction of the numbers.
        private void MSust_Button_Click(object sender, EventArgs e)
        {
            Memory = Memory - Convert.ToDouble(Principal.Text);
        }

        // "M+" Button
        // Add the displayed number in the TextBox to another number in memory 
        // but doesn´t display the sum of the numbers.
        private void MPlus_Button_Click(object sender, EventArgs e)
        {
            Memory = Memory + Convert.ToDouble(Principal.Text);
        }

        // "MS" Button
        // Stores in memory the displayed number in the TextBox
        private void MS_Button_Click(object sender, EventArgs e)
        {
            Memory = Convert.ToDouble(Principal.Text); // Converts the number of the TextBox to Double
        }

        // "MR" Button
        // Recalls the number stored in memory.The number remains in memory.
        private void MR_Button_Click(object sender, EventArgs e)
        {
            Principal.Text = Memory.ToString(); // Displays the memory number in the TextBox
        }

        // "MC" Button
        // This button have the work of clear the memory
        private void MC_Button_Click(object sender, EventArgs e)
        {
            Memory = 0; // Assigning the value of "0" to "Memory" variable
        }

        // "%" Button
        private void Percentage_Button_Click(object sender, EventArgs e)
        {
            operation = "%";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.Percentage ObjPerct = new Operations.Percentage(); // Creation of an object
            double Percentage = ObjPerct.Percent(num1); // Method call
            Principal.Text = Percentage.ToString();
        }

        // "π" Button
        private void pi_Button_Click(object sender, EventArgs e)
        {
            operation = "π";
            Principal.Text = Principal.Text + "3.141592654";
        }

        // "x³" Button
        private void xCubed_Button_Click(object sender, EventArgs e)
        {
            operation = "x³";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.xCubed ObjCubed = new Operations.xCubed(); // Creation of an object
            double xCub = ObjCubed.xCub(num1); // Method call
            Principal.Text = xCub.ToString();
        }

        // "x²" Button
        private void xSquared_Button_Click(object sender, EventArgs e)
        {
            operation = "x²";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.xSqurd ObjSqurd = new Operations.xSqurd(); // Creation of an object
            double xSqur = ObjSqurd.xSqr(num1); // Method call
            Principal.Text = xSqur.ToString();
        }

        // "x⁻¹" Button
        private void xRaisedNeg1_Button_Click(object sender, EventArgs e)
        {
            operation = "x⁻¹";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.xRNeg1 ObjxRNeg1 = new Operations.xRNeg1(); // Creation of an object
            double xRNeg1 = ObjxRNeg1.xNeg1(num1); // Method call
            Principal.Text = xRNeg1.ToString();
        }

        // "10x" Button
        private void Tentox_Button_Click(object sender, EventArgs e)
        {
            operation = "10x";
            Principal.Clear();
        }

        // "e (Euler)" Button
        private void Euler_Button_Click(object sender, EventArgs e)
        {
            operation = "e";
            Principal.Text = Principal.Text + "2.718281828";
        }

        // "x!" Button
        private void Factorial_Button_Click(object sender, EventArgs e)
        {
            operation = "x!";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.Factorial ObjFac = new Operations.Factorial(); // Creation of an object
            double Factorial = ObjFac.FactOp(num1); // Method call
            Principal.Text = Factorial.ToString();
        }

        // "Exp" Button
        private void Exp_Button_Click(object sender, EventArgs e)
        {
            operation = "Exp";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "log" Button
        private void log_Button_Click(object sender, EventArgs e)
        {
            operation = "log";
            num1 = Convert.ToDouble(Principal.Text);
        
            Operations.Logarithm ObjLog = new Operations.Logarithm(); // Creation of an object
            double Log = ObjLog.Log(num1); // Method call
            Principal.Text = Log.ToString();
        }

        // "ln" Button
        private void NatLog_Button_Click(object sender, EventArgs e)
        {
            operation = "ln";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.NatLog ObjNatLog = new Operations.NatLog(); // Creation of an object
            double NaturalLog = ObjNatLog.NaturalLog(num1); // Method call
            Principal.Text = NaturalLog.ToString();
        }

        // "tan" Button
        private void tan_Button_Click(object sender, EventArgs e)
        {
            operation = "tan";
            num1 = Convert.ToDouble(Principal.Text);

            double Tan = ObjSin.Sin(num1) / ObjCos.Cos(num1); // Calling the necesary Methods
            Principal.Text = Tan.ToString();
        }

        // "sin" Button
        private void sin_Button_Click(object sender, EventArgs e)
        {
            operation = "sin";
            num1 = Convert.ToDouble(Principal.Text);

            double Sin = ObjSin.Sin(num1); // Method call
            Principal.Text = Sin.ToString();
        }

        // "cos" Button
        private void cos_Button_Click(object sender, EventArgs e)
        {
            operation = "cos";
            num1 = Convert.ToDouble(Principal.Text);

            double Cos = ObjCos.Cos(num1); // Method call
            Principal.Text = Cos.ToString();
        }

        // "sec" Button
        private void sec_Button_Click(object sender, EventArgs e)
        {
            operation = "sec";
            num1 = Convert.ToDouble(Principal.Text);

            // Calling the necesary Methods
            double Tan = ObjSin.Sin(num1) / ObjCos.Cos(num1);
            double Sec = Tan / ObjSin.Sin(num1); 

            Principal.Text = Sec.ToString();
        }

        // "csc" Button
        private void csc_Button_Click(object sender, EventArgs e)
        {
            operation = "csc";
            num1 = Convert.ToDouble(Principal.Text);

            // Calling the necesary methods
            double Cot = ObjCos.Cos(num1) / ObjSin.Sin(num1);
            double Csc = Cot / ObjCos.Cos(num1);

            Principal.Text = Csc.ToString();
        }

        // "cot" Button
        private void cot_Button_Click(object sender, EventArgs e)
        {
            operation = "sec";
            num1 = Convert.ToDouble(Principal.Text);

            double Cot = ObjCos.Cos(num1) / ObjSin.Sin(num1); // Calling the necesary Methods
            Principal.Text = Cot.ToString();
        }

        // "sinh" Button
        private void sinh_Button_Click(object sender, EventArgs e)
        {
            operation = "sinh";
            num1 = Convert.ToDouble(Principal.Text);

            double Sinh = ObjSinh.Sinh(num1); // Method call
            Principal.Text = Sinh.ToString();
        }

        // "cosh" Button
        private void cosh_Button_Click(object sender, EventArgs e)
        {
            operation = "cosh";
            num1 = Convert.ToDouble(Principal.Text);

            double Cosh = ObjCosh.Cosh(num1); // Method call
            Principal.Text = Cosh.ToString();
        }

        // "tanh" Button
        private void tanh_Button_Click(object sender, EventArgs e)
        {
            operation = "cosh";
            num1 = Convert.ToDouble(Principal.Text);

            double Tanh = ObjSinh.Sinh(num1) / ObjCosh.Cosh(num1); // Calling the necesary methods
            Principal.Text = Tanh.ToString();
        }

        // "DEL" Button
        private void C_Button_Click(object sender, EventArgs e)
        {
            // if condition
            if (Principal.Text.Length > 1)
            {
                Principal.Text = Principal.Text.Remove(Principal.Text.Length - 1, 1);
            }

            // else
            else
            {
                Principal.Clear(); // Empty / Clear the TextBox
            }
        }

        // "0" Button
        private void Button_0_Click(object sender, EventArgs e)
        {
            Principal.Text = Principal.Text + "0";
        }
    }
}
