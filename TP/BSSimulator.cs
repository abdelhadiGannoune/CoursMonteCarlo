using System;

namespace TP
{
    public class BSSimulator
    {
        private MarketData marketData = new MarketData();
        private NormalGenerator normalGenerator = new NormalGenerator();
        public double Simulate(string stockName, double maturity)
        {
            double spot = marketData.GetStock(stockName);
            double rate = marketData.GetRate();
            double volatility = marketData.GetVolatility(stockName);

            double exp = Math.Exp((rate - volatility * volatility / 2) * maturity + volatility * Math.Sqrt(maturity) * normalGenerator.Generate());
            return spot * exp;
        }
    }
}