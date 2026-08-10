Console.Write("Enter grade: ");
int grade = int.Parse(Console.ReadLine());

string result = (grade > 50) ? "Passed" : "Failed";
Console.WriteLine(result);