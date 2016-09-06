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

                
    }
}