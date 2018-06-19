using Microsoft.VisualStudio.TestTools.UnitTesting;
using static APO.Substitution;

namespace UnitTestsExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Machine1 machine1 = new Machine1();
            Machine1 machine2 = new Machine2();

            Assert.AreNotEqual(machine1, machine2);
        }
    }
}
