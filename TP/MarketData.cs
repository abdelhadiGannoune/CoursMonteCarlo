namespace TP
{
    class MarketData
    {
        // La méthode GetRate prenait un paramètre stockName
        // je l'ai supprimé car le rate ne dépend pas du stockName
        public double GetRate()
        {
            return 0.04;
        }
        public double GetVolatility(string stockName)
        {
            return 0.5;
        }
        public double GetStock(string stockName)
        {
            return 100;
        }
    }
}