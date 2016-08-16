using System;
using System.Collections.Generic;

namespace LibraryCalcAlgorithm
{
    public class CalcAlgorithm
    {
//-------the main methods---------------------------

		//the main method that runs the algorithm
		public double Calculate(string input)
		{
			string output = getConvertion (input);
			double result = getResult (output);
			return result;
		}

		private string getConvertion(string input)
		{
			string output = null;
			Stack <char> opStack = new Stack <char> ();


		}


//-------the secondary methods---------------------------		
    }
}
