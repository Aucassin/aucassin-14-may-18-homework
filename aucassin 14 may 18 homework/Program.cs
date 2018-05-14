using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aucassin_14_may_18_homework
{
    class Program
    {
        public delegate int Operation(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Hey you. Please enter the first operand");
            int x = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Great! Now enter the second operand");
            int y = (Convert.ToInt32(Console.ReadLine()));
            Operation operation = Sum;
            operation += Substract;
            operation += (a, b) =>
            {
                Console.WriteLine($"{a} multiply {b} equals {a * b}");
                return a * b;
            };
            operation += (a, b) =>
            {
                if (b != 0)
                {
                    Console.WriteLine($"{a} divide {b} equals {a / b}");
                    return a / b;
                }
                else
                {
                    Console.WriteLine("Don't be so naive, U can't divide by zero");
                    return 0;
                }
            };
            operation?.Invoke(x, y);
            Console.ReadLine();
        }
        private static int Sum(int a, int b)
        {
            int res = a + b;
            Console.WriteLine($"{a} plus {b} equals {res}");
            return res;
        }
        private static int Substract(int a, int b)
        {
            int res = a - b;
            Console.WriteLine($"{a} minus {b} equals {res}");
            return res;
        }
    }
}
