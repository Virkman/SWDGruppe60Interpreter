using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDGruppe60Interpreter.Interpreter.Expressions
{
    public class Cups : Expression
    {
        public override string gallons(double quantity)
        {
            return (quantity / 16).ToString();
        }

        public override string liter(double quantity)
        {
            return (quantity * 0.2366).ToString();
        }

        public override string quarts(double quantity)
        {
            return (quantity / 4).ToString();
        }

        public override string pints(double quantity)
        {
            return (quantity / 2).ToString();
        }

        public override string cups(double quantity)
        {
            return (quantity).ToString();
        }

        public override string tablespoons(double quantity)
        {
            return (quantity * 16).ToString();
        }

        public override string teaspoons(double quantity)
        {
            return (quantity * 48).ToString();
        }
    }
}

