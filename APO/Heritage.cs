namespace APO
{
    public class Heritage
    {
        public class B
        {
            private double x;
            protected double y;

        }

        public class C : B
        {
            public double Y
            {
                get
                {
                    return y;
                    //return x;
                }
            }
        }

        public void Test()
        {
            B b = new B();
            //var test3 = b.y;

            C c = new C();
            var test4 = c.Y;

            B bis = new C();
            //var test5 = bis.Y;
        }
    }
}
