using System;

namespace TP
{
    public class UniformGenerator
    {
        // le champ random était initialisé avec le constructeur par défaut: new Random()
        // Ce dernier utilise un grain basé sur l'heure. Si deux UniformGenerators sont
        // instanciés quasiement en même temps, ils utiliseront le même grain.
        // Deux random avec le même grain donnent exactement la même séquence de chiffre
        // et donc représente la même variable de loi uniforme.
        // Pour corriger, il suffit de spécifier un grain différent à chaque instanciation
        // j'ai utilisé Guid.NewGuid().GetHashCode() qui garantit un aléatoire raisonnable
        // j'ai également ajouté un test unitaire pour vérifier celà : uniform_instances_should_be_independants
        private Random random = new Random(Guid.NewGuid().GetHashCode());

        public double Generate()
        {
            return random.NextDouble();
        }
    }
}