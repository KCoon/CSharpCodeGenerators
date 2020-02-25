namespace CSharpCodeGenerators.Builder
{
    public class Candy
    {
        public Candy(int chocolate, double marshmallow)
        {
            Chocolate = chocolate;
            Marshmallow = marshmallow;
        }

        public int Chocolate { get; private set; }

        public double Marshmallow { get; private set; }

        public static CandyBuilder Build()
        {
            return new CandyBuilder();
        }

        public class CandyBuilder
        {
            private int _chocolate;
            private double _marshmallow;

            public CandyBuilder Chocolate(int value)
            {
                _chocolate = value;
                return this;
            }

            public CandyBuilder Marshmallow(double value)
            {
                _marshmallow = value;
                return this;
            }

            public Candy Build()
            {
                return new Candy(_chocolate, _marshmallow);
            }
        }

    }
}
