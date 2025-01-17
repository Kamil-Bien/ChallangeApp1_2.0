

namespace ChallangeApp1_2._0.test
{
    public class TypeTests
    {
        [Test]
        public void valueTypesTest()
        {
            //Arrange
            int intiger1 = 2;
            int intiger2 = 3;
            float float1 = 1.5f;
            float float2 = 1f;
            string string1 = "hello";
            string string2 = "o";

            //Act
            intiger2 = intiger2 - intiger1 + 1;
            float2 = float1;
            string2 = "hell" + string2;

            //Assert
            Assert.AreEqual(intiger1, intiger2);
            Assert.AreEqual(float1, float2);
            Assert.AreEqual(string1, string2);

        }

        [Test]
        public void referenceTypeTests()
        {
            //Arrange
            var user1 = GetUser("Kamil");
            var user2 = GetUser("Kamil");

            //Act
            //test bez dodatkowych dzaiałań

            //Assert
            Assert.AreNotEqual(user1, user2);

        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
