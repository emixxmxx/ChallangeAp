using ChallengeApp;

var employee = new Employee("emixx", "Mxx");
employee.AddGrade(6.65); //double
employee.AddGrade("14"); // string
employee.AddGrade('7'); //char
employee.AddGrade(15); // float
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");