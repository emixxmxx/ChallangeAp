namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenScoresAreAddded_ShouldReturnCorrectResult()
        {
            // arragne - przygotowanie testu
            var worker1 = new Employee("Adrian", "Puchacki", 21);
            worker1.AddScore(15);
            worker1.AddScore(-100);

            // act - czêœæ uruchamiaj¹ca test
            var result = worker1.Result;

            // assert - sprawdzenie warunków 
            Assert.AreEqual(-85, result);
        }
    }
}