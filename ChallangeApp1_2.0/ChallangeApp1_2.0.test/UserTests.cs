namespace ChallangeApp1_2._0.test
{
    public class UserTests
    {
        [Test]
        public void AddNSubtractWorkersPoints()
        {
            //Arrange
            Employee worker1 = new Employee("Johny", "Test1", 24);
            Employee worker2 = new Employee("Tony", "Test2", 24);
            worker1.AddScore(-1);
            worker1.AddScore(2);
            worker1.AddScore(3);
            worker2.AddScore(1);
            worker2.AddScore(2);
            worker2.SubtractScore(-3);

            //Act
            int result1 = worker1.Result;
            int result2 = worker2.Result;

            //Assert
            Assert.AreEqual(6, result1);
            Assert.AreEqual(0, result2);
        }
    }
}