using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDGruppe60Interpreter.Interpreter.Expressions
{
    class Teaspoons : Expression
    {
        public override string gallons(double quantity)
        {
            return (quantity * 0.001302).ToString();
        }

        public override string liter(double quantity)
        {
            return (quantity * 0.004929).ToString();
        }

        public override string quarts(double quantity)
        {
            return (quantity * 0.005208).ToString();
        }

        public override string pints(double quantity)
        {
            return (quantity * 0.01042).ToString();
        }

        public override string cups(double quantity)
        {
            return (quantity * 0.02083).ToString();
        }

        public override string tablespoons(double quantity)
        {
            return (quantity * 0.3333).ToString();
        }

        public override string teaspoons(double quantity)
        {
            return (quantity).ToString();
        }
    }
}
