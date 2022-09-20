using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SolverTestIndex()
        {
            int[] test1 = { -6, 0, 2, 40 };
            
            Assert.AreEqual(2, Class1.Solver(test1));
        }
        [TestMethod]
        public void SolverTestFalse()
        {
            int[] test1 = { 1, 5, 7, 8 };

            Assert.IsFalse(Class1.Solver(test1));
        }
    }
}