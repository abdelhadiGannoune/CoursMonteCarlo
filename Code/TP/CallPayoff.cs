using System;

namespace TP
{
    public class CallPayoff
    {
        private string stockName;
        private double maturity;
        private double strike;

        public CallPayoff(string stockName, double maturity, double strike)
        {
            this.stockName = stockName;
            this.maturity = maturity;
            this.strike = strike;
        }

        public double Maturity { get { return maturity; } }

        public string StockName { get { return stockName; } }

        public double Evaluate(BSSimulator simulator)
        {
            double ST = simulator.Simulate(stockName, maturity);
            return Math.Max(ST - strike, 0);
        }
    }
}