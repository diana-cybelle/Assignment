        Console.Write("Enter principal amount: ");
        int principalAmount = int.Parse(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        int rate = int.Parse(Console.ReadLine());

        Console.Write("Enter time in years: ");
        int years = int.Parse(Console.ReadLine());

        int interest = ((principalAmount * rate * years)/100);

        Console.Write("Simple Interest " + interest);
