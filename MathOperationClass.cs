using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class MathOperationClass
    {
        public double a{ get; set; }
        public double b { get; set; }
        public double o { get; set; }

        
        public static double MathOperation(double a, double b, int o)
        {
            double result;
            switch (o)
            {
                case 1:
                    //Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                
                default:
                    result = a / b;
                    break;
            }
            return result;
        }
    }
}
