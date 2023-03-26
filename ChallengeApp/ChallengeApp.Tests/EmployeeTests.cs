namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenGradesAreGiven_ShouldReturnMaxGrade()
        {
            var employee = new Employee("emixx", "Mxx");
            employee.AddGrade(6); employee.AddGrade(2); employee.AddGrade(1);

            var statistics = employee.GetStatistics();
                       
            Assert.AreEqual(6, statistics.Max);
        }
        [Test]
        public void WhenGradesAreGiven_ShouldReturnMinGrade()
        {
            var employee = new Employee("emixx", "Mxx");
            employee.AddGrade(6); employee.AddGrade(2); employee.AddGrade(1);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void WhenGradesAreGiven_ShouldReturnAverage()
        {
            var employee = new Employee("emixx", "Mxx");
            employee.AddGrade(6); employee.AddGrade(2); employee.AddGrade(1);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(3, statistics.Average);
        }

    }
}