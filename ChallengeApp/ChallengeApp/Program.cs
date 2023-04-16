using ChallengeApp;

Console.WriteLine("Program do oceny pracowników");
Console.WriteLine("============================");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Wybierz czyje oceny chcesz dodać:");
    Console.WriteLine("E - Employee; S - Supervisor");
    Console.WriteLine();
    var inp = Console.ReadLine();

    if (inp == "E" || inp == "e")
    {
        Console.WriteLine("Podaj liczbę z zakresu 1 - 100 lub A-E");
        Console.WriteLine("q lub Q - zakończenie wpowadzania ocen");
        Console.WriteLine();
        Employee employee = new Employee("emixx", "emixxmxx");
        while (true)
        {
            Console.Write("Podaj kolejną ocenę: ");
            var input = Console.ReadLine();
            if (input == "q" || input == "Q")
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
        break;
    }
    else if (inp == "S" || inp == "s")
    {
        Console.WriteLine("Podaj ocenę z zakresu 1 - 6");
        Console.WriteLine("q lub Q - zakończenie wpowadzania ocen");
        Console.WriteLine();
        Supervisor employee1 = new Supervisor("emixx", "emixxmxx");
        while (true)
        {
            Console.Write("Podaj kolejną ocenę: ");
            var input = Console.ReadLine() ;
            if (input == "q" || input == "Q")
            {
                break;
            }
            try
            {
                employee1.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
        var statistics = employee1.GetStatistics();
        Console.WriteLine($"Najniższa ilość punktów: {statistics.Min}");
        Console.WriteLine($"Najwyższa ilość punktów: {statistics.Max}");
        Console.WriteLine($"Średnia: {statistics.Average}");
        Console.WriteLine($"Średnia wyrażona w literach: {statistics.AverageLetter}");
        break;
    }
    else 
    {
        Console.WriteLine("Błędne dane. Wprowadź ponownie");
    }  
}