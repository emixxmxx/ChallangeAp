namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>(); 

        public Employee(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddGrade(float grade) 
        {
            if (grade >= 0 && grade <= 100) 
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grades void");
            }
        }

        public void AddGrade(string grade) 
        {
            if (float.TryParse(grade, out float result)) 
            {
                this.AddGrade(result); 
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(double grade)
        {
            float valueDouble = (float)grade;
            this.AddGrade(valueDouble);
        }
        public void AddGrade(char grade)
        {
            char valueChar = grade;
            float i;
            i = (float)valueChar;
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;
           
            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade); 
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average += grade; 
            }
            statistics1.Average = statistics1.Average / this.grades.Count;
            return statistics1;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            
            for (var i=0; i<this.grades.Count; i++)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[i]);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[i]);
                statistics2.Average += this.grades[i]; 
            }
            statistics2.Average = statistics2.Average / this.grades.Count;
            return statistics2;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            var index = 0;
            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]); 
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Average += this.grades[index]; 
                index++;
            }
            while (index < this.grades.Count);
            statistics3.Average = statistics3.Average / this.grades.Count;
            return statistics3;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Average = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;
            var index = 0;
            while (index < this.grades.Count)
            {
                statistics4.Max = Math.Max(statistics4.Max, this.grades[index]);
                statistics4.Min = Math.Min(statistics4.Min, this.grades[index]);
                statistics4.Average += this.grades[index];
                index++;
            }
            statistics4.Average = statistics4.Average / this.grades.Count;
            return statistics4;
        }
    }
}