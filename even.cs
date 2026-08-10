using System;
    class Progam{
        static void Main(){
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if ( num % 2 == 0)
            {
                Console.Write($"The number {num} is Even");
            }
        }
    }