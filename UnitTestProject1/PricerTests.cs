using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP;

namespace UnitTestProject1
{
    [TestClass]
    public class PricerTests
    {
        // Valeur de référence obtenue depuis : http://www.danielsoper.com/fincalc/calc.aspx?id=37
        [TestMethod] public void TestPricer()
        {
            // Le test était en erreur à cause de deux problèmes :
            // Le premier est juste une erreur de saisie, le prix de
            // référence (12.8405) correspond à une maturité de 90 jours = 0.246 année
            // c'est corrigé en utilisant la bonne maturité dans le test
            // Le deuxième venait de la loi normale. On a utilisé involontairement
            // la même loi uniforme deux fois (u1=u2), pour plus de détails, voir
            // les commentaires de la classe UniformGenerator
            Pricer pricer = new Pricer();
            CallPayoff payoff = new CallPayoff("s", 0.246, 95);
            BSSimulator simulator = new BSSimulator();
            double price = pricer.Price(payoff, simulator, 10e5);
            Assert.AreEqual(12.8405, price, 0.1);
        }
    }
}