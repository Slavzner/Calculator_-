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
        static public double Calculate(string input)
        {
            return getResult(input);
        }

        /// <summary>
        /// method return result of calculation
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        static private double getResult(string _input)
        {
            Stack<char> opStack = new Stack<char>();
            Stack<double> numStack = new Stack<double>();
            double result = 0;
            string tempStr = null;

            for (int i = 0; i < _input.Length; i++)
            {
                if (IsSpace(_input[i]))//ignore a spaces
                    continue;//continue checking

                if (IsOperator(_input[i]))
                    opStack.Push(_input[i]);

                if (Char.IsDigit(_input[i]))
                {
                    do
                    {
                        tempStr += _input[i];
                        i++;
                        if (i == _input.Length)
                            break;
                    } while (!IsSpace(_input[i]) && !IsOperator(_input[i]));

                    numStack.Push(double.Parse(tempStr));
                    tempStr = null;
                    i--;
                }
            }
            double firstOperand = numStack.Pop();
            double secondOperand = numStack.Pop();

            switch (opStack.Pop())
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;

                case '*':
                    result = firstOperand * secondOperand;
                    break;
            }

            numStack.Push(result);
            return numStack.Peek();
        }

        //-------the secondary methods---------------------------

        /// <summary>
        /// method check if char is space
        /// </summary>
        /// <returns></returns>
        static private bool IsSpace(char ch)
        {
            if (" ".IndexOf(ch) != -1)
                return true;
            return false;
        }

        /// <summary>
        /// method check if char is operator
        /// </summary>
        /// <returns></returns>
        static private bool IsOperator(char ch)
        {
            if ("+*".IndexOf(ch) != -1)
                return true;
            return false;
        }
    }
}