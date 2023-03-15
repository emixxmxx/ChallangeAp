namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score1 = new List<int>();
        private List<int> score2 = new List<int>();
        private List<int> score3 = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int R1
        {
            get
            {
                return this.score1.Sum();
            }
        }
        public int R2
        {
            get
            {
                return this.score2.Sum();
            }
        }
        public int R3
        {
            get
            {
                return this.score3.Sum();
            }
        }
        public void AddScore1(int number)
        {
            this.score1.Add(number);
        }
        public void AddScore2(int number1)
        {
            this.score2.Add(number1);
        }
        public void AddScore3(int number2)
        {
            this.score3.Add(number2);
        }
    }
}