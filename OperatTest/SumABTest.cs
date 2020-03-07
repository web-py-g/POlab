using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperatTest
{
    [TestClass]
    public class SumABTest
    {
        [TestMethod]
        public void SumAB_2and3_5return()
        {
            int x = 2;
            int y = 3;
            int expected = 5;

            OP.Operat operat = new OP.Operat();
             long actual = OP.Operat.SumAB(x, y);

            Assert.AreEqual(x, 2);
            Assert.AreEqual(y, 3);
            Assert.AreEqual(expected, actual);



        }
    }
}
