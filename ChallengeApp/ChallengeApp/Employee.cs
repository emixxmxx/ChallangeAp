namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>(); //lista zbierająca punkty

        public Employee(string name, string surname, int age) // kontruktor z paramentrem pozwala tworzyć osobnych uzytkownków
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
       
        
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
      
    }
}