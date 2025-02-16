// See https://aka.ms/new-console-template for more information

string? firstName = string.Empty;
string? lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
string? gender = string.Empty;
bool working = true;
Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salary");
salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("What is your gender: (Male or Female)");
gender = Console.ReadLine();

Console.WriteLine("Are you working (true/false)");
working = Convert.ToBoolean(Console.ReadLine());


Console.WriteLine($"i am {firstName} {lastName} aged {age} years.");
int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"I have {workingYearsRemaining} working years remaining");
Console.WriteLine($"You are a {gender} and its {working} you are working.Your salary is $ {salary}");