// See https://aka.ms/new-console-template for more information

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();
Console.WriteLine("Please enter your last name: ");
lastName = Console.ReadLine();
Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"i am {firstName} {lastName} aged {age} years.");
int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"I have {workingYearsRemaining} working years remaining");