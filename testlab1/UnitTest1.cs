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
            // ����� ���
            int number = 1352;
            int expectedSum = 11;
            int expectedProduct = 30;

            // ��������� ���� �� ������� �� ��������� ������ CalculateSumAndProduct
            Program.CalculateSumAndProduct(number, out int actualSum, out int actualProduct);

            // �������� ����������
            Assert.AreEqual(expectedSum, actualSum);
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}
