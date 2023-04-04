using ChallengeApp;

Console.WriteLine("Program do oceny pracowników");
Console.WriteLine("============================");
Console.WriteLine();
Console.WriteLine("Podaj liczbę z zakresu 1 - 100 lub A-E");
Console.WriteLine("q - zakończenie wpowadzania ocen");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.Write("Podaj kolejną ocenę: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try 
    {
        employee.AddGrade(input);
    }
    catch (Exception e) 
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");