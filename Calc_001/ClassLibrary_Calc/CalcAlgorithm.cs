using System;
using System.Collections.Generic;

namespace LibraryCalcAlgorithm
{
    /// <summary>
    /// Library Class of calculation algorithm
    /// </summary>
    public class CalcAlgorithm 
    {
        //-------the main methods---------------------------

        ///the main method that runs the algorithm
        /// <summary>
        /// the main method that runs the algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double Calculate(string input)
        {
            string output = getConvertion(input);
            return getResult(output);
        }

        /// <summary>
        /// method processing of input data
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string getConvertion(string input)
        {
            string output = null;
            Stack<char> opStack = new Stack<char>();

            //loop for checking all chars in input 
            for (int i = 0; i < input.Length; i++)
            {
                if (IsSpace(input[i]))//ignore a spaces
                     continue;//continue checking
                    
            }

        }

        /// <summary>
        /// method return result of calculation
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        private double getResult(string output)
        {
        }

        //-------the secondary methods---------------------------

        /// <summary>
        /// method check if char is space
        /// </summary>
        /// <returns></returns>
        private bool IsSpace(char ch)
        {
            if (" ".IndexOf(ch) != -1)
                return true;
            return false;
        }

        private bool IsOperator(char ch)
        {
            if ("+*".IndexOf(ch) != -1)
                return true;
            return false;
        }
    }
}