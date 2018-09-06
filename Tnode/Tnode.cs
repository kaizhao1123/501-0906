using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tnode
{
    class Tnode
    {
        double value;
        char theOperator;

        Tnode left;
        Tnode right;

        double evaluate()
        {
            switch (theOperator)
            {
                case '#': return value;
                case '+': return left.evaluate() + right.evaluate();
                case '*': return left.evaluate() * right.evaluate();
                default: return -1;
            }
        }

    }

    
}
