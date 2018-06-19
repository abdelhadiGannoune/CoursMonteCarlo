namespace APO
{
    public class Produit
    {
        public double Maturity { get; set; }

        public double Strike { get; set; }

        public Produit(double maturity, double strike)
        {
            Maturity = maturity;
            Strike = strike;
        }

    }
}
