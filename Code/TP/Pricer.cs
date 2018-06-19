using System;

namespace TP
{
    public class Pricer
    {
        MarketData marketData = new MarketData();
        public double Price(CallPayoff payoff, BSSimulator simulator, double nbPaths)
        {
            double sum = 0.0;
            double rate = marketData.GetRate();

            double exp = Math.Exp(-rate * payoff.Maturity);

            for (int i = 0; i < nbPaths; i++)
            {
                sum += payoff.Evaluate(simulator);
            }
            return exp * (sum / nbPaths);
        }
    }
}