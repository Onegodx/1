using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{

        abstract class Pair_complex
        {
            private double a;
            private double b;
            public double A
            {
                get { return a; }
                set { a = value; }
            }
            public double B
            {
                get { return b; }
                set { b = value; }
            }
            public Pair_complex(double a, double b)
            {
                A = a;
                B = b;
            }
            abstract public Pair_complex Add(Pair_complex p);
            abstract public Pair_complex Sub(Pair_complex p);
            abstract public Pair_complex Mult(Pair_complex p);
            abstract public Pair_complex Div(Pair_complex p);
            abstract public bool Equ(Pair_complex p);
            abstract public Pair_complex Conj();
    }
}
