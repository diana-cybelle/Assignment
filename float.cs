using System;
class Progam{
       static void Main(){
       Console.WriteLine("***Average***");
        Console.Write("Enter 1st Score: ");
        float a = int.Parse(Console.ReadLine());

        Console.Write("Enter 2nd Score: ");
        float b = int.Parse(Console.ReadLine());

        Console.Write("Enter 3rd Score: ");
        float c = int.Parse(Console.ReadLine());

        float total = (a + b + c);

        Console.Write("Average: " + (total / 3));
}
}