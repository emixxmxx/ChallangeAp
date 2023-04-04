namespace ChallengeApp.tests
{
    public class Tests
    {
        [Test]
        public void WhenAverageBetween20And40_ShouldReturnAverageLetterD()
        {
            // arragne 
            var employee = new Employee();
            employee.AddGrade(25);
            employee.AddGrade('C'); //60
            employee.AddGrade(7);

            // act 
            var statistics = employee.GetStatistics();

            // assert 
            Assert.AreEqual('D', statistics.AverageLetter); //average = 30.67
        }
        [Test]
        public void WhenAverageBetween80And100_ShouldReturnAverageLetterA()
        {
            // arragne 
            var employee = new Employee();
            employee.AddGrade(90);
            employee.AddGrade('b'); //80
            employee.AddGrade(88);

            // act 
            var statistics = employee.GetStatistics();

            // assert 
            Assert.AreEqual('A', statistics.AverageLetter); //average = 86
        }
    }
}