namespace ChallangeApp1_2._0.test
{
    public class GetStatisticsTests
    {
        [Test]
        public void AverageLetterValueTests()
        {
            //Arrange
            Employee worker1 = new Employee("Johny", "Test1");
            worker1.AddScore(10);
            worker1.AddScore(70);
            worker1.AddScore(22);
            
            //Act
            var result = worker1.GetStatistics();

            //Assert
            Assert.AreEqual('D', result.AverageLetter);
        }

    }
}