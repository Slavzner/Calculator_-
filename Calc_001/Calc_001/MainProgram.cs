using LibraryCalcAlgorithm;
using System;

namespace Calc_001
{
    internal class MainProgram
    {
        private static void Main(string[] args)
        {
            //CalcAlgorithm myCalc = new CalcAlgorithm();
            while (true)
            {
                Console.WriteLine("Plesea enter: operator(+,*) num num: ");
                Console.WriteLine("Result: " + CalcAlgorithm.Calculate(Console.ReadLine()));
            }
        }
    }
}