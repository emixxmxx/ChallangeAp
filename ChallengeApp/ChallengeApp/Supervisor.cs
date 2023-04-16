﻿
namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
        }
        public void AddGrade(char grade)
        { 
            char valueChar = (char)grade;
            this.grades.Add(grade); 
        }
        public void AddGrade(double grade)
        {
            float valueDouble = (float)grade;
            this.AddGrade(valueDouble);
        }
        public void AddGrade(string grade)
        {    
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "6-" or "-6":
                    this.grades.Add(95);
                    break;
                case "5+" or "+5":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "5-" or "-5":
                    this.grades.Add(75);
                    break;
                case "4+" or "+4":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "4-" or "-4":
                    this.grades.Add(55);
                    break;
                case "3+" or "+3":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "3-" or "-3":
                    this.grades.Add(35);
                    break;
                case "2+" or "+2":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "2-" or "-2":
                    this.grades.Add(15);
                    break;
                case "1+" or "+1":
                    this.grades.Add(5);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;             
                default:
                    throw new Exception("błędna ocena (podaj z zakresu 1-6)");
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
    

