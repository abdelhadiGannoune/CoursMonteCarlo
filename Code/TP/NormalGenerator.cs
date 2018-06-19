using System;

namespace TP
{
    public class NormalGenerator
    {
        private UniformGenerator u1 = new UniformGenerator();
        private UniformGenerator u2 = new UniformGenerator();
        public double Generate()
        {
            var u1 = new Random().NextDouble();
            var u2 = new Random().NextDouble();

            double sqrt = Math.Sqrt(-2 * Math.Log(u1));
            double cos = Math.Cos(2 * Math.PI * u2);
            return sqrt * cos;
        }
    }
}