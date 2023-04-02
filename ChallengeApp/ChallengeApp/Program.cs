using ChallengeApp;

Console.WriteLine("Program do oceny pracowników");
Console.WriteLine("============================");
Console.WriteLine();


var employee = new Employee();

while (true)
{
    Console.Write("Podaj kolejną ocenę z zakresu 1 - 100 /q = Quit/:  ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");