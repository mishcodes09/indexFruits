using indexFruits;

namespace FruitTesting
{
    [TestClass]
    public class FruitTest
    {
        [TestMethod]
        public void TestIndexerByIndex()
        {
            // Arrange
            Fruits fruit = new Fruits("Apple", "Red Apple", "Pome");


            // Assert
            Assert.AreEqual(fruit[0], "Apple");
            Assert.AreEqual(fruit[1], "Red Apple");
            Assert.AreEqual(fruit[2], "Pome");
        }
    }
}
