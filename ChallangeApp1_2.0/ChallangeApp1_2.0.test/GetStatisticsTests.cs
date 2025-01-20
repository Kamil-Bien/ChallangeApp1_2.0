namespace ChallangeApp1_2._0.test
{
    public class GetStatisticsTests
    {
        [Test]
        public void MinValueTests()
        {
            //Arrange
            Employee worker1 = new Employee("Johny", "Test1");
            worker1.AddScore(-1.5f);
            worker1.AddScore(2);
            worker1.AddScore(3);
            
            //Act
  //         var result = worker1.GetStatistics();

            //Assert
  //         Assert.AreEqual(-1.5f, result.Min);
        }

        [Test]
        public void MaxValueTests()
        {
            //Arrange
            Employee worker1 = new Employee("Johny", "Test1");
            worker1.AddScore(-1);
            worker1.AddScore(0);
            worker1.AddScore(3);

            //Act
      //      var result = worker1.GetStatistics();

            //Assert
      //      Assert.AreEqual(3, result.Max);
        }

        [Test]
        public void AvarageValueTests()
        {
            //Arrange
            Employee worker1 = new Employee("Johny", "Test1");
            worker1.AddScore(1);
            worker1.AddScore(0);
            worker1.AddScore(0);

      //      var result = worker1.GetStatistics();

            //Assert
      //      Assert.AreEqual(0.33f, result.Avarage, 0.0099f);
        }

    }
}