using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public abstract class pair_money
    {
        public abstract pair_money Add_money(pair_money value);
        public abstract pair_money Subtract(pair_money value);
        public abstract pair_money Multiply(double value);
        public abstract pair_money Divide(double value);
        public abstract int CompareTo(object obj);
    }
}