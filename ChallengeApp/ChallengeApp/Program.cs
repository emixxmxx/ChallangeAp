using ChallengeApp;

Employee worker1 = new Employee("Adrian", "Puchacki", 21);
Employee worker2 = new Employee("Wojciech", "Puczyk", 20);
Employee worker3 = new Employee("Waldemar", "Walasik", 22);

worker1.AddScore(1);
worker1.AddScore(2);
worker1.AddScore(2);
worker1.AddScore(1);
worker1.AddScore(3);
worker2.AddScore(4);
worker2.AddScore(5);
worker2.AddScore(5);
worker2.AddScore(6);
worker2.AddScore(3);
worker3.AddScore(7);
worker3.AddScore(9);
worker3.AddScore(8);
worker3.AddScore(7);
worker3.AddScore(10);


List<Employee> employees = new List<Employee>()
{
    worker1, worker2, worker3
};
int maxResult = -1;
Employee workerWithMaxResult = null;

foreach (Employee worker in employees)
{
    if (worker.Result > maxResult)
    {
        workerWithMaxResult = worker;
    }
}

Console.WriteLine
    ("Pracownik z najwyższą oceną to: "+ 
    workerWithMaxResult.Name+" "+ workerWithMaxResult.Surname
    + ", wiek: "+ workerWithMaxResult.Age+", ocena: " + workerWithMaxResult.Result);
   