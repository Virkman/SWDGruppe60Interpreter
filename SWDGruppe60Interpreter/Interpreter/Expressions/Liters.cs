using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDGruppe60Interpreter.Interpreter.Expressions
{
    public class Liters : Expression
    {
        public override string gallons(double quantity)
        {
            return (quantity * 0.2642).ToString();
        }

        public override string liter(double quantity)
        {
            return (quantity).ToString();
        }

        public override string quarts(double quantity)
        {
            return (quantity * 1.057).ToString();
        }

        public override string pints(double quantity)
        {
            return (quantity * 2.113).ToString();
        }

        public override string cups(double quantity)
        {
            return (quantity * 4.227).ToString();
        }

        public override string tablespoons(double quantity)
        {
            return (quantity * 67.63).ToString();
        }

        public override string teaspoons(double quantity)
        {
            return (quantity * 202.9).ToString();
        }
    }
}
