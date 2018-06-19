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
            Produit produit = new Produit(1.0, 50);

            double forward = GetForward();
            double discountFactor = GetDiscountFactor(produit.Maturity);
                                
            return discountFactor * (forward - produit.Strike);
        }

        private double GetForward()
        {
            return 60.0;
        }

        private double GetDiscountFactor(double maturity)
        {
            double rate = GetRate();
            return 1 / (1 + rate * maturity);
        }

        private double GetRate()
        {
            return 0.01;
        }

        
    }
}