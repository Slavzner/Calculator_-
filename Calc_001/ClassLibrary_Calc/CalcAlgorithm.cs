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
			return getResult(input);
		}

		/// <summary>
		/// method return result of calculation
		/// </summary>
		/// <param name="output"></param>
		/// <returns></returns>
		private double getResult(string input)
		{
			Stack<char> opStack = new Stack<char>();
			Stack<double> numStack = new Stack<double>();
			double result = 0;

			for (int i = 0; i < input.Length; i++)
			{
				if (IsSpace(input[i]))//ignore a spaces
					continue;//continue checking

			}
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

		/// <summary>
		/// method check if char is operator
		/// </summary>
		/// <returns></returns>
		private bool IsOperator(char ch)
		{
			if ("+*".IndexOf(ch) != -1)
				return true;
			return false;
		}
	}
}