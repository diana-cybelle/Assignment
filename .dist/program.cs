//Console.Write("hello");

//int x =6;
//Console.WriteLine($"The  value of x is {x}");
//Console.Write("enter num: ");
//int num =  int.Parse(Console.ReadLine);
//Console.Write($"the number is: {num}");

/* string name = "Diana Cybelle A. Osano";
 int age = 18;
 double height = 1.57;
 char middleI = 'A';
 bool isStudent = true;

 Console.WriteLine("Full name: " + name);
 Console.WriteLine("Age: "+ age);
 Console.WriteLine("Your Height: " + height);
 Console.WriteLine("Middle Initial: " + middleI);
 Console.WriteLine("Is Student: " + isStudent);


 Console.WriteLine("****Addition****");
 Console.Write("Enter first whole number: ");
 int x = int.Parse(Console.ReadLine());

 Console.Write("Enter second whole number: ");
 int y = int.Parse(Console.ReadLine());

 Console.Write("Sum: " + (x+y));


Console.Write("Enter principal amount: ");
int principalAmount = int.Parse(Console.ReadLine());

Console.Write("Enter rate of interest: ");
int rate = int.Parse(Console.ReadLine());

Console.Write("Enter time in years: ");
int years = int.Parse(Console.ReadLine());

int interest = ((principalAmount * rate * years)/100);

Console.Write("Simple Interest " + interest);

//even or odd
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

if ( num % 2 == 0)
{
    Console.Write($"The number {num} is Even");
}

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


Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your monthly income: ");
int income = Convert.ToInt32(Console.ReadLine());

if (age >= 25 && income >= 50000)
{
    Console.Write("Young Proffesional");
}

else if (age >= 36 && income >= 70000)
{
    Console.Write("Middle-Aged Professional");    
}

else if(age >= 56 && income <= 30000)
{
    Console.Write("Senior Citezen");
}

else
{
    Console.Write("other");
}

for(int i =1; i <= 5; i++)
{
    Console.WriteLine(i);
}

int x = 5;
while(x<5);
{
    Console.WriteLine(x);
    x++;
}


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= exponent; i++)
        {
            result *= baseNum;
        }
        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
}

using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i * i;
        }
        Console.WriteLine("Sum of squares = " + sum);
    }
}
*/

int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += i * i;
}
Console.WriteLine($"Sum of squares = {sum}");
