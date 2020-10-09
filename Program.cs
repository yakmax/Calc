using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 200;
            int b = 200;
            int operation = Console.Read();
            if (operation == 43) Console.WriteLine(a + b);
            if (operation == 45) Console.WriteLine(a - b);
            //Console.WriteLine(operation);
            Console.Read();
        }
    }
}
