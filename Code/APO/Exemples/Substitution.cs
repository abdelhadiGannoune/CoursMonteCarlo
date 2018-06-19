using System;

namespace APO
{
    public class Substitution
    {
        public class Machine1
        {
            public void Executer()
            {
                Console.WriteLine("niveau 1");
            }
        }

        public class Machine2 : Machine1
        {
            public new void Executer()
            {
                Console.WriteLine("niveau 2");
            }
        }
    }
}
