namespace ChallengeApp.tests
{
    public class Tests
    {
        [Test]
        public void WhenAverageBetween20And40_ShouldReturnAverageLetterD()
        {
            // arragne 
            var employee1 = new Supervisor("emixx", "emixxmxx");
            employee1.AddGrade("2+"); 
            employee1.AddGrade("-3");
            employee1.AddGrade("4");

            // act 
            var statistics = employee1.GetStatistics();

            // assert 
            Assert.AreEqual(40, statistics.Average) ;
        }
        
    }
}