using ChallengeApp;

Employee worker1 = new Employee("Adrian", "Puchacki", 21);
Employee worker2 = new Employee("Wojciech", "Puczyk", 20);
Employee worker3 = new Employee("Wardemar", "Walasik", 22);


worker1.AddScore(1);
worker1.AddScore(7);
worker1.AddScore(2);
worker1.AddScore(1);
worker1.AddScore(3);
worker2.AddScore(0);
worker2.AddScore(9);
worker2.AddScore(9);
worker2.AddScore(9);
worker2.AddScore(8);
worker3.AddScore(7);
worker3.AddScore(2);
worker3.AddScore(3);
worker3.AddScore(1);
worker3.AddScore(0);


List<Employee> employees = new List<Employee>()
{
    worker1, worker2
};

int maxResult = -1;
Employee workerWithMaxResult = null;

foreach (var worker in employees)
{
    if (worker.Result > maxResult)
    {
        maxResult = worker.Result;
        workerWithMaxResult = worker;
    }
}


Console.WriteLine("Pracownik "+workerWithMaxResult.Name+ " " + workerWithMaxResult.Surname);

Console.WriteLine("wiek: "+workerWithMaxResult.Age);
Console.WriteLine("otrzymał: " + workerWithMaxResult.Result+" punktów");