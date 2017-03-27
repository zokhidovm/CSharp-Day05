using System;

namespace CSharpDay05_Exercise_01
{
    class Program
    {
        Console.WriteLine("Exercise 01: ");
        for (int i = 0; i <= 3; i++)
        {
            for (int j = i + 1; j >= 1; j--)
            {
                Console.Write(" {0}", j);
            }
            Console.WriteLine(" ");
        }
    }
}
