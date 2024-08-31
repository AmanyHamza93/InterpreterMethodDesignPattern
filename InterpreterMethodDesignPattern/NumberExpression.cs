using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMethodDesignPattern
{
    public class NumberExpression : Expression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public override int Interpret()
        {
            return number;
        }
    }
}
