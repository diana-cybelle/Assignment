using System;
    class Program{
        static void Main(){
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your monthly income: ");
            int income = Convert.ToInt32(Console.ReadLine());


            if (age >= 25 && age <= 35 && income > 50000)
            {
                Console.Write("Young Professional");
            }

            else if (age >= 36 && age <= 55 && income > 70000)
            {
                Console.Write("Middle-Aged Professional");    
            }

            else if (age >= 56 && income < 30000)
            {
                Console.Write("Senior Citizen");
            }

            else
            {
                Console.Write("Other");
            }
        }
    }