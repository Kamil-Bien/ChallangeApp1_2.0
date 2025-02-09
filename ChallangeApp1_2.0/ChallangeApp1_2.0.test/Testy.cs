namespace ChallangeApp1_2._0.test
{
    public class Testy
    {
        [Test]
        public void AddScoreStringSwitchTest()
        {
            //Arrange
            EmployeeInMemory worker1 = new EmployeeInMemory("Johny", "Test1");
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