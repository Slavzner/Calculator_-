using Calc.Mechanism;
using System;

namespace Calc.Main
{
    internal class MainProgram
    {
        private static void Main(string[] args)
        {
            //CalculationMechanism myCalc = new CalculationMechanism();
            while (true)
            {
                Console.WriteLine("Plesea enter: operator(+,*) num num: ");
                Console.WriteLine("Result: " + CalculationMechanism.Calculate(Console.ReadLine()));
            }
        }
    }
}