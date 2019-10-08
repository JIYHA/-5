using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  целочисленные катеты a и b");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            double S = a * b / 2;
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double P = a + b + c;
            Console.WriteLine("S=" + S);
            Console.WriteLine("P=" + P);
        }
    }
}
