﻿using System;

namespace Subtration
{
    public class Sub
    {
        static void Main(string[] args)
        {
         
        }

        public static double Operation(double num1, double num2, string opp)
        {
          
            double result = double.NaN;
            switch (opp)
            {
                case "2":
                    result = num1 - num2;
                    break;
            }
            return result;
        }
    }
}
