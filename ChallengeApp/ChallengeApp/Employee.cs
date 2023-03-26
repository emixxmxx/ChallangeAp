namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>(); //lista zbierająca punkty

        public Employee(string name, string surname) // kontruktor z paramentrem pozwala tworzyć osobnych uzytkownków
        {
            this.Name = name;
            this.Surname = surname;
        }
   
        public string Name { get; private set; }
        public string Surname { get; private set; }
      
      
        public void AddGrade(float grade) //metoda dodająca stopnie(grades)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;    


            foreach(var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade); // Math.Max( wartość 1, wartość 2) - ten math porównuje dwie wartości najpierw tą która już mamy potem ta którą zobaczy jako następną
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade; // tj. statistics.Average = statistics.Average + grade 
            }

            statistics.Average = statistics.Average / this.grades.Count; // suma podzielona przez ilość wartości 


            return statistics;

        }



    }
}