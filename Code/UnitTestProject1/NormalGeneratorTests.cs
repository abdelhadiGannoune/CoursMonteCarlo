using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP;

namespace UnitTestProject1
{
    [TestClass]
    public class NormalGeneratorTests
    {
        [TestMethod] public void normal_average_should_be_0()
        {
            NormalGenerator normal = new NormalGenerator();
            double sum = 0.0;
            double nbValues = 10e6;
            for (int i = 0; i < nbValues; i++)
                sum += normal.Generate();
            double avg = sum / nbValues;
            Assert.AreEqual(0, avg, 0.1);
        }
    }
}