using ChallengeApp;

Employee worker1 = new Employee("Adrian", "Puchacki", 21);
Employee worker2 = new Employee("Wojciech", "Puczyk", 20);
Employee worker3 = new Employee("Waldemar", "Walasik", 22);

worker1.AddScore1(1);
worker1.AddScore1(2);
worker1.AddScore1(2);
worker1.AddScore1(1);
worker1.AddScore1(3);
worker2.AddScore2(4);
worker2.AddScore2(5);
worker2.AddScore2(5);
worker2.AddScore2(6);
worker2.AddScore2(3);
worker3.AddScore3(7);
worker3.AddScore3(9);
worker3.AddScore3(8);
worker3.AddScore3(7);
worker3.AddScore3(10);
var R1 = worker1.R1;
var R2 = worker2.R2;
var R3 = worker3.R3;
var name1 = worker1.Name;
var name2 = worker2.Name;
var name3 = worker3.Name;
var surname1 = worker1.Surname;
var surname2 = worker2.Surname;
var surname3 = worker3.Surname;
var age1 = worker1.Age;
var age2 = worker2.Age;
var age3 = worker3.Age;

if ((R1 >= R2) && (R1 >= R3))
    Console.WriteLine("Pracownik z najwyższą oceną to: "+name1+" "+surname1+", wiek: "+age1+" ocena - "+R1);
else if ((R2 >= R1) && (R2 >= R3))
    Console.WriteLine("Pracownik z najwyższą oceną to: "+name2+" "+surname2+", wiek: "+age2+" ocena - "+R2);
else if ((R3 >= R1) && (R3 >= R2))
    Console.WriteLine("Pracownik z najwyższą oceną to: "+name3+" "+surname3+", wiek: "+age3+" ocena - "+R3);