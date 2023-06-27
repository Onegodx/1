using ConsoleApp18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Complex : Pair_complex
    {
        public Complex(double a, double b) : base(a, b)
        {
        }

        public override Pair_complex Add(Pair_complex p)
        {
            return new Complex(this.A + p.A, this.B + p.B);
        }

        public override Pair_complex Conj()
        {
            return new Complex(A, -B);
        }

        public override Pair_complex Div(Pair_complex p)
        {
            return new Complex((this.A * p.A + this.B * p.B) / (p.A * p.A + p.B * p.B),
                (this.A * p.B + this.B * p.A) / (p.A * p.A + p.B * p.B));
        }

        public override bool Equ(Pair_complex p)
        {
            return (this.A == p.A) && (this.B == p.B);
        }

        public override Pair_complex Mult(Pair_complex p)
        {
            return new Complex(this.A * p.A - this.B * p.B, this.A * p.B + p.A * this.B);
        }

        public override Pair_complex Sub(Pair_complex p)
        {
            return new Complex(this.A - p.A, this.B - p.B);
        }

        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
    }
}