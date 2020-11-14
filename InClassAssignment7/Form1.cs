using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnMethods_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------------
            //First Method

                //Declaring Variables
                int firstNumber1 = 12, secondNumber1 = 24;

                //Calling method from method class
                Methods getMethod1 = new Methods();

                //Inputs variables/values into method, assigns result to new variable
                int totalSum = getMethod1.sumInt(firstNumber1, secondNumber1);

                //Displays result in label on form
                lblMethod1Results.Text = totalSum.ToString();



            //Second Method -----------------------------------------

                //Declaring Variables
                double firstNumber2 = 1, secondNumber2 = 2, thirdNumber2 = 3, fourthNumber2 = 4, fifthNumber2 = 5;

                //Calling Method from method class
                Methods getMethod2 = new Methods();

                //Inputs variables/values into method, assigns result to new variable
                double totalAvg = getMethod2.avgDoub(firstNumber2, secondNumber2, thirdNumber2, fourthNumber2, fifthNumber2);

                //Displays result in label on form
                lblMethod2Results.Text = totalAvg.ToString();



            //Third Method --------------------------------

                //Declaring Variables
                int firstNumber3 = 0 ,
                    secondNumber3 = 0;

                //Calling Method from method class
                Methods getMethod3 = new Methods();

                //Inputs variables/values into method, assigns result to new variable
                int numSum = getMethod3.randomSum(firstNumber3,secondNumber3);

                //Displays result in label on form
                lblMethod3Results.Text = numSum.ToString();



            //Fourth Method -------------------------------

                //Declaring Variables
                int firstNumber4 = 2;
                int secondNumber4 = 2;
                int thirdNumber4 = 3;

                //Calling Method from method class
                Methods getMethod4 = new Methods();

                //Inputs variables/values into method, assigns result to new variable
                bool result = getMethod4.divSum(firstNumber4, secondNumber4, thirdNumber4);

                //If statement checks if result is true (divisible by 3), displays correct response in label
                if (result == true)
                {
                    lblMethod4Results.Text = "True"; 
                }
                else
                {
                    lblMethod4Results.Text = "False";
                }



            //Fifth Method-----------------------------

                //Declaring Variables
                string stringOne = "This is the shortest by far.";
                string stringTwo = "This is the shortest string even though it may not be.";

                //Calling Method from method class
                Methods getMethod5 = new Methods();

                //Inputs variables/values into method, assigns result to new variable
                string shortString = getMethod5.countString(stringOne, stringTwo);

                //Displays result in label on form
                lblMethod5Results.Text = shortString;



            //Sixth Method (Number 8) ----------------------------------

                //Declaring Variables
                bool firstBool = true;
                bool secondBool = false;

                //Calling Method from method class
                Methods getMethod6 = new Methods();

                //Inputs variables/values into method, assigns result to new variable
                bool trueFalse = getMethod6.testTrue(firstBool, secondBool);

                //Displays result in label on form
                lblMethod6Results.Text = trueFalse.ToString();



            //Seventh Method (Number 9) -----------------------------------

                //Declaring Variables
                int firstNumber7 = 6;
                double secondNumber7 = 7.5;

                //Calling Method from method class
                Methods getMethod7 = new Methods();

                //Inputs variables/values into method, assigns result to new variable
                double multiNum = getMethod7.multID(firstNumber7, secondNumber7);

                //Displays result in label on form
                lblMethod7Results.Text = multiNum.ToString();
        }

     
    }
}
