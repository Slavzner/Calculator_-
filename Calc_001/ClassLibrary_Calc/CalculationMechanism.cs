using System;
using System.Collections.Generic;

namespace Calc.Mechanism
{
    /// <summary>
    /// Library Class of calculation algorithm
    /// </summary>
    public class CalculationMechanism
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
            char opStack = ' ';
            Stack<double> numStack = new Stack<double>();
            double result = 0;
            string [] tempStr = null;                    
            char[] delimiter = { ' ' };
            //use Split method
            tempStr = _input.Split(delimiter);

            if (!checkInput(tempStr))
            {
                Console.WriteLine("Invalid input");
                return -1;
            }
               

            opStack = char.Parse(tempStr[0]);
            numStack.Push(double.Parse(tempStr[1]));
            numStack.Push(double.Parse(tempStr[2]));
            tempStr = null;

            double firstOperand = numStack.Pop();
            double secondOperand = numStack.Pop();


            switch (opStack)
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
        /// this method checks if input is correct
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static private bool checkInput(string[] str)
        {
            int count = 0;
            bool firtsOp = false;

            for(int i = 0; i <str.Length; i++)
            {
                if ((i == 0) && IsOperator(char.Parse(str[0])))
                    firtsOp = true;
                if (IsOperator(char.Parse(str[i])))
                    count++;                   
            }
            if ((firtsOp && count != 1) || !firtsOp )
                return false;
            else return true;

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