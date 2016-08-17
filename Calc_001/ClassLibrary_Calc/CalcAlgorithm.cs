using System;

namespace LibraryCalcAlgorithm
{
    /// <summary>
    /// Library Class of calculation algorithm
    /// </summary>
    public class CalcAlgorithm: ICalcAlgorithm;
    {
//-------the main methods---------------------------

		///the main method that runs the algorithm
        
		public double Calculate(string input)
		{
			string output = getConvertion (input);
			return getResult (output);
		}

/// <summary>
/// 
/// </summary>
/// <param name="input"></param>
/// <returns></returns>
		private string getConvertion(string input)
		{
			string output = null;
			Stack <char> opStack = new Stack <char> ();


		}


//-------the secondary methods---------------------------		
    }
}
