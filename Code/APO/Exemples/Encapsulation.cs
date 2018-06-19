namespace APO
{
    public class Encapsulation
    {
        public class A
        {
            private double x;

            public double X { get; set; } 
        }

        public class B
        {
            protected double y ;
        }

        public class C : B
        {
            public double Y
            {
                get
                {
                    return y;
                }
            }
        }

        public void Test()
        {
            A a = new A();
            var test1 =a.X;
            a.X = 0;
            //var test 2 = a.x;

            B b = new B();
            //var test3 = b.y;

            C c = new C();
            var test4 = c.Y;
            
            B bis = new C();
            //var test5 = bis.Y;
        }
    }
}
