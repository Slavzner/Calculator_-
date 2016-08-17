using System;
using System.Collections.Generic;

namespace ClassLibrary_Calc
{
    public interface ICalcAlgorithm
    {
        //-------the main methods---------------------------

        //the main method that runs the algorithm
        
         ///   
         double Calculate(string input);
        
        /// <summary>
        /// method processing of input data 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        string getConvertion(string input);

    }
}
