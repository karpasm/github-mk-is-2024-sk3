using System;

namespace program003b_pravouhly_trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte velikost pravoúhlého trojúhelníku: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}