using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide number of rows");
            int NoRows = int.Parse(Console.ReadLine());
            for (int row = NoRows; row >=1 ; row--) 
            {
                for (int column = row; column >= 1; column--)
                {
                    Console.Write(column + " ");   
                }
                Console.WriteLine();
            }
        }
    }
}
