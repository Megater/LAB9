using System;

namespace LAB9
{
    class Lab9
    {

        public static void Main(string[] args)
        {
            int l = 0;
            Console.WriteLine("Choose Task:");
            Console.WriteLine("1: Task1");
            Console.WriteLine("2: Task2");
            Console.WriteLine("3: Task3");
            Console.WriteLine("4: Task4");
            Console.WriteLine("5: Task5");
            Console.WriteLine("6: Task6");
            Console.WriteLine("7: Task7");
            Console.WriteLine("");
            int x = int.Parse(Console.ReadLine());
            while (l != 1)                                      
            {
                if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5 || x == 6 || x == 7)
                {
                    l++;
                }
                else
                {
                    Console.WriteLine("You chose wrong task");
                    int y = int.Parse(Console.ReadLine());
                    x = y;

                }
            }

            if (x == 1)
            {
                Console.WriteLine("You chose Task1");
                Console.WriteLine("");
                Task1.TasK1();
            }

            if (x == 2)
            {
                Console.WriteLine("You chose Task2");
                Console.WriteLine("");
                Task2.TasK2();

            }

            if (x == 3)
            {
                Console.WriteLine("You chose Task3");
                Console.WriteLine("");

            }

            if (x == 4)
            {
                Console.WriteLine("You chose Task4");
                Console.WriteLine("");

            }

            if (x == 5)
            {
                Console.WriteLine("You chose Task5");
                Console.WriteLine("");

            }

            if (x == 6)
            {
                Console.WriteLine("You chose Task6");
                Console.WriteLine("");

            }

            if (x == 7)
            {
                Console.WriteLine("You chose Task7");
                Console.WriteLine("");
            }
        }
    }
}


