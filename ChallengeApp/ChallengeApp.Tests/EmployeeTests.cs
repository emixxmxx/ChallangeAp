namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenGradesAreGeted_ShouldReturnMaxGrade()
        {
            // arragne - przygotowanie testu
            var employee = new Employee("emixx", "Mxx");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(1);

            // act - cz�� uruchamiaj�ca test
            var statistics = employee.GetStatistics();


            // assert - sprawdzenie warunk�w 
            Assert.AreEqual(6, statistics.Max); 
        }
        [Test]
        public void WhenGradesAreGeted_ShouldReturnMinGrade()
        {
            // arragne - przygotowanie testu
            var employee = new Employee("emixx", "Mxx");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(1);

            // act - cz�� uruchamiaj�ca test
            var statistics = employee.GetStatistics();


            // assert - sprawdzenie warunk�w 
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void WhenGradesAreGeted_ShouldReturnAverage()
        {
            // arragne - przygotowanie testu
            var employee = new Employee("emixx", "Mxx");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(1);

            // act - cz�� uruchamiaj�ca test
            var statistics = employee.GetStatistics();


            // assert - sprawdzenie warunk�w 
            Assert.AreEqual(3, statistics.Average);
        }

    }
}