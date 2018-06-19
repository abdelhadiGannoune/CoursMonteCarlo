using System;

namespace APO
{
    public class Pricer
    {
        public Produit Produit { get; set; }

        public MarketData Data { get; set; }

        public Pricer()
        {
            Produit = new Produit(1.0, 50);
            Data = new MarketData(60, 0.01, 0.2);
        }

        public double Price()
        {
            double prix = (Data.Spot - Produit.Strike) * Math.Exp(-Data.Rate * Produit.Maturity);
            return prix;
        }
    }
}
