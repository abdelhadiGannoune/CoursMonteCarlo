using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP;

namespace UnitTestProject1
{
    [TestClass]
    public class UniformGeneratorTests
    {
        [TestMethod] public void uniform_value_should_be_between_0_and_1()
        {
            UniformGenerator uniform = new UniformGenerator();
            double value = uniform.Generate();
            Assert.IsTrue(value >= 0 && value <= 1);
        }
        [TestMethod] public void uniform_average_should_be_0_5()
        {
            UniformGenerator uniform = new UniformGenerator();
            double nbValues = 10e5;
            double sum = 0.0;
            for (int i = 0; i < nbValues; i++)
                sum = sum + uniform.Generate();
            double avg = sum / nbValues;
            Assert.AreEqual(0.5, avg, 0.001);
        }
        [TestMethod] public void uniform_variance_should_be_1_12()
        {
            UniformGenerator uniform = new UniformGenerator();
            double sum = 0.0;
            double nbValues = 10e6;
            for (int i = 0; i < nbValues; i++)
            {
                sum += Math.Pow(uniform.Generate() - 0.5, 2);
            }
            double variance = sum / nbValues;
            Assert.AreEqual(1.0 / 12, variance, 0.01);
        }
        [TestMethod] public void uniform_instances_should_be_independants()
        {
            UniformGenerator uniform1 = new UniformGenerator();
            UniformGenerator uniform2 = new UniformGenerator();
            double nbValues = 10e4;
            List<double> listValuesUniform1 = new List<double>();
            List<double> listValuesUniform2 = new List<double>();
            for (int i = 0; i < nbValues; i++)
            {
                listValuesUniform1.Add(uniform1.Generate());
                listValuesUniform2.Add(uniform2.Generate());
            }
            CollectionAssert.AreNotEqual(listValuesUniform1, listValuesUniform2);
        }
    }
}