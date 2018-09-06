using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tnode
{
    abstract class Pnode
    {
        public abstract double evaluate();
    }

    class ValueNode: Pnode
    {
        double value;
        public override double evaluate()
        {
            return value;            
        }

    }

    class OpNode : Pnode
    {
        char op;
        Pnode left;
        Pnode right;

        public override double evaluate()
        {
            switch (op)
            {
                
                case '+': return left.evaluate() + right.evaluate();
                case '*': return left.evaluate() * right.evaluate();
                default: return -1;
            }
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////
    /// </summary>

    abstract class OpAbNode: Pnode
    {
       
       protected Pnode left;
       protected Pnode right;
    }

    class AdditionNode: OpAbNode
    {
        public override double evaluate()
        {
          return left.evaluate() + right.evaluate();
        }
    }

    class NultiNode : OpAbNode
    {
        public override double evaluate()
        {
            return left.evaluate() * right.evaluate();
        }
    }
}
}
