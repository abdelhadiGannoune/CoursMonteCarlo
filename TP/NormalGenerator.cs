using System;

namespace TP
{
    public class NormalGenerator
    {
        private UniformGenerator u1 = new UniformGenerator();
        private UniformGenerator u2 = new UniformGenerator();
        public double Generate()
        {
            double sqrt = Math.Sqrt(-2 * Math.Log(u1.Generate()));
            double cos = Math.Cos(2 * Math.PI * u2.Generate());
            return sqrt * cos;
        }
    }
}