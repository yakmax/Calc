using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string inputstring;
            inputstring = Console.ReadLine();
            double a;
            
            for (; ; )
            {
                if (Double.TryParse(inputstring, out a)) break;
                else
                {
                    Console.WriteLine("Не сработало! Еще раз:");
                    inputstring = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите второе число:");
            inputstring = Console.ReadLine();
            double b;
            for (; ; )
            {
                if (Double.TryParse(inputstring, out b)) break;
                else
                {
                    Console.WriteLine("Не сработало! Еще раз:");
                    inputstring = Console.ReadLine();
                }
            }

            Console.WriteLine("Выберите действие(1 - Сложить, 2 - Вычесть, 3 - Умножить, 4 - Поделить):");
            inputstring  = Console.ReadLine();
            int operation;
            for (; ; )
            {
                if (int.TryParse(inputstring, out operation) && (operation > 0 && operation <= 4)) break;
                else
                {
                    Console.WriteLine("Не сработало! Еще раз:");
                    inputstring= Console.ReadLine();
                }
            }

            if (operation == 1) Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            if (operation == 2) Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            if (operation == 3) Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            if (operation == 4) Console.WriteLine("{0}/{1}={2}", a, b, a / b);
        }
    }
}
