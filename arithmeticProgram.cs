/*
 * FILE NAME: arithmeticProgram.cs
 * PROJECT NAME: Arithmetic Project
 * DATE INITIATLIZED: 18 July 2018
 * DESCRIPTION: A C# program designed to calculate an arithmetic operaiton between two variables
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arimtheticProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = 50;
            double secondNum = 25;

            double answer = firstNum + secondNum;

            Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " is " + answer);
            Console.ReadKey();
        }

    }
}
