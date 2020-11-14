using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Amanda Pace
//Bill Hughes - CST 117
//11/14/2020
//This program is my own work 
//(some source code from class lecture)


namespace InClassAssignment7
{
    class Methods
    {
        /// <summary>
        /// Method that adds two ints, displays sum
        /// </summary>
        /// <param name="firstInt"></param>
        /// <param name="secondInt"></param>
        /// <returns></returns>
        public int sumInt(int firstInt, int secondInt)
        {
            //int total = 0;
            //total = firstInt + secondInt;
            //return total;

            //Shorthand Version

            //Returns sum of two variables
            return firstInt + secondInt;

        }


        /// <summary>
        /// Method that displays the average of five doubles
        /// </summary>
        /// <param name="firstDoub"></param>
        /// <param name="secondDoub"></param>
        /// <param name="thirdDoub"></param>
        /// <param name="fourthDoub"></param>
        /// <param name="fifthDoub"></param>
        /// <returns></returns>
        public double avgDoub(double firstDoub, double secondDoub, double thirdDoub, double fourthDoub, double fifthDoub)
        {
            //Adds all variables, divides by 5 (number of variables), returns answer (which is the average)
            return (firstDoub + secondDoub + thirdDoub + fourthDoub + fifthDoub) / 5;
        }



        /// <summary>
        /// Method that generates two random numbers and returns sum
        /// </summary>
        /// <param name="firstInt"></param>
        /// <param name="secondInt"></param>
        /// <returns></returns>
       
                        //Imported random class so following method can generate random numbers
                        internal class random   { }

        public int randomSum(int firstInt, int secondInt)
        {
            //Calls random class
            Random rnd = new Random();

            //Assigns two random numbers to two different variables
            //Number is paranthesis serve as parameters for the variable
            //Numbers generated will be between 1 and 20
            firstInt = rnd.Next(1,20);
            secondInt = rnd.Next(1,20);

            //Returns the sum of the two numbers
            return firstInt + secondInt;


        }


        /// <summary>
        /// Method that adds three ints and decides if it can be divided by 3 
        /// </summary>
        /// <param name="firstInt"></param>
        /// <param name="secondInt"></param>
        /// <param name="thirdInt"></param>
        /// <returns></returns>
        public Boolean divSum(int firstInt, int secondInt, int thirdInt)
        {

            //Adds three ints, assigns sum as variable
            int sum = firstInt + secondInt + thirdInt;

            //If statement testing if sum is divisible by 3, returns result
            if (sum % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
   
        }


        /// <summary>
        /// Method that counts characters in two strings and displays the shortest
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        
        public string countString(string firstString, string secondString)
        {
            //Declaring variable for shortest string, so it can be returned
            string shortestString = "";

            //If statement compares character count of both strings
            //Assigns shortest string to variable
            if (firstString.Length < secondString.Length)
            {
                shortestString = firstString;
            }
            else if (secondString.Length < firstString.Length)
            {
                shortestString = secondString;
            }

            return shortestString;
        }


        //Method that compares two booleans to see if they have the same value
        public Boolean testTrue(bool firstVar, bool secondVar)
        {
            //Compares two bool variables, returns true if same
            if (firstVar == secondVar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Method that multiplies an int and a double, returns product
        /// </summary>
        /// <param name="intVar"></param>
        /// <param name="doubVar"></param>
        /// <returns></returns>
        public double multID(int intVar, double doubVar)
        {
            //Converts int  to double and multiplies two variables, returns
            return Convert.ToDouble(intVar) * doubVar;
        }
    }


}
