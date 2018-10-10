using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            int yourNum, i;

            do
            {


                Console.WriteLine("Learn your squares and cubes!");

                Console.Write("Enter an integer:");
                yourNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Number   Squarued   Cubed");
                Console.WriteLine("=====    ======     =====");

                for (i = 1; i <= yourNum; i++)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", i, "\t    ", Math.Pow(i, 2), "\t      ", Math.Pow(i, 3));

                }

                Console.WriteLine("Would you like to continue? y/n");
            }
            while (Console.ReadLine() == "y");
            {
                Console.WriteLine("Goodbye");
            }
     }



    }
}
