namespace APO
{
    public class PricerEngine
    {
        public double Price(string productType)
        {
            if (productType == "Forward")
            {
                return PriceForward();
            }
            return -9999.0 ;
        }

        private double PriceForward()
        {
            double forward = GetForward();
            double discountFactor = GetDiscountFactor();
            double strike = GetStrike();
            return discountFactor * (forward - strike);
        }

        private double GetForward()
        {
            return 60.0;
        }

        private double GetDiscountFactor()
        {
            double rate = GetRate();
            double maturity = GetMaturity();
            return 1 / (1 + rate * maturity);
        }

        private double GetRate()
        {
            return 0.01;
        }

        private double GetMaturity()
        {
            return 1.0;
        }

        private double GetStrike()
        {
            return 58.0;
        }
    }
}
