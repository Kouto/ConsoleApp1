using System;

namespace ConsoleApp1
{
    class Program
    {
        static void show(string txt)
        {
            Console.WriteLine(txt);
        }
        static int factorial(int m)
        {
            int s = 1;
            for (int k=1; k<=m; k++)
            {
                s *= m;
                k++;
            }
            return s;
        }

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            show("test");
            string result = Convert.ToString(factorial(5));
            show(result);
            Console.ReadKey();
        }
    }
}
