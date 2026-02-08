using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 10,11,12,20,31,5,6};
            Console.Write($"Even Numbers : {string.Join(' ',Numbers.Where(n =>IsEven(n)))}");
            Console.WriteLine();
            Console.Write($"OOd Numbers : {string.Join(' ',Numbers.Where(n =>IsOod(n)))}");
            Console.WriteLine();
        }

        static bool IsEven(int value)
        {
            if (value % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        static bool IsOod(int value)
        {
            if (value % 2 != 0)
            {
                return true;
            }
            else return false;
        }

    }
}