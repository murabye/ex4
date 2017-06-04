using System;
using MyLib;

namespace ex4
{
    internal class Program
    {
        private static double epsilon;

        private static void Main()
        {
            while (true)
            {
                epsilon = Ask.RealNum("Введите точность: ");
                Console.WriteLine("Ответ: " + Calculate(0.5, 0.6));
                OC.Stay();
            }

        }

        static double Calculate(double x1, double x2)
        {
            var x3 = x1 - (x2 - x1) * Func(x1) / (Func(x2) - Func(x1));

            return Math.Abs(x3 - x2) > epsilon ? Calculate(x2, x3) : x3;
        }

        static double Func(double arg)
        {
            return arg * arg - Math.Sin(5 * arg);
        }
    }
}
