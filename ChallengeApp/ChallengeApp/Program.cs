using ChallengeApp;

var employee = new Employee("emixx", "Mxx");
employee.AddGrade(15);
employee.AddGrade(2);
employee.AddGrade(3);
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}"); //N2 - tj. wyświelta 2 miejsca po przecinku 
