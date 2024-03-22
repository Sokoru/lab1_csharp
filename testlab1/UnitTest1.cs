using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;

namespace testlab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateSumAndProduct()
        {
            // ¬х≥дн≥ дан≥
            int number = 1352;
            int expectedSum = 11;
            int expectedProduct = 30;

            // ќбчислити суму та добуток за допомогою методу CalculateSumAndProduct
            Program.CalculateSumAndProduct(number, out int actualSum, out int actualProduct);

            // ѕерев≥рка результат≥в
            Assert.AreEqual(expectedSum, actualSum);
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}
