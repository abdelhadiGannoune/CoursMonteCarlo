namespace APO
{
    public class MarketData
    {
        public double Spot { get; set; }

        public double Rate { get; set; }

        public double Volatility { get; set; }

        public MarketData(double spot, double rate, double volatility)
        {
            Spot = spot;
            Rate = rate;
            Volatility = volatility;
        }
    }
}
