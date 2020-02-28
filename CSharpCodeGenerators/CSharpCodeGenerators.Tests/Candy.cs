using System.Dynamic;

namespace CSharpCodeGenerators
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

        public static Builder Build()
        {
            return new Builder();
        }

        public class Builder
        {
            private int _chocolate;
            private double _marshmallow;

            public int Chocolate
            {
                get => _chocolate;
                set => _chocolate = value;
            }

            public double Marshmallow
            {
                get => _marshmallow;
                set => _marshmallow = value;
            }

            public Builder(int chocolate, double marshmallow)
            {
                _chocolate = chocolate;
                _marshmallow = marshmallow;
            }

            public Builder()
            {

            }

            public Builder WithChocolate(int value)
            {
                _chocolate = value;
                return this;
            }

            public Builder WithMarshmallow(double value)
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
    public class CandyBuilder
    {
        public int Chocolate { get; set; }

        public double Marshmallow{ get; set; }

        public Candy Build()
        {
            return new Candy(Chocolate, Marshmallow);
        }
    }
}
