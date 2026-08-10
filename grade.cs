Console.Write("Enter Grade: ");
int grade = int.Parse(Console.ReadLine());

string result = (grade > 50) ? "Passed" : "Failed";
Console.WriteLine(result);
