﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>(); 

        public Employee()
        {
        }

        public void AddGrade(float grade) 
        {
            if (grade >= 0 && grade <= 100) 
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("błędny zakres liczb (podaj z zakresu 1-100");
            }
        }

        public void AddGrade(string grade) 
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char res))
            {
                this.AddGrade(res);
            }
            else
            {
                throw new Exception("błędna wartość (podaj z zakresu float lub char)");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("błędna litera (podaj z zakresu A-E)");    
            }
        }


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
           
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade); 
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade; 
            }
            statistics.Average = statistics.Average / this.grades.Count;
            switch (statistics.Average) 
            {
                case var average when average >= 80: 
                    statistics.AverageLetter = 'A'; 
                    break;                          
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }        
    }
}