using System;
    class Program{
            static void Main(){
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.Write($"The number {num} is Positive");
        }
        else
        {
            Console.Write($"The number {num} is Negative");
        }
    }
}

