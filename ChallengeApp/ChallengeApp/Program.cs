using System.ComponentModel.Design;

var name = "Ewa";
var age = 28;
var sex = "Kobieta";



if (age < 30 && sex == "Kobieta")
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" &&  age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni Meżczyzna");
}