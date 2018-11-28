using System;

namespace SWDGruppe60Interpreter.Interpreter.Expressions
{
    public class Gallons : Expression
    {
        public override string gallons(double quantity)
        {
            return (quantity).ToString();
        }

        public override string liter(double quantity)
        {
            return (quantity * 3.785).ToString();
        }

        public override string quarts(double quantity)
        {
            return (quantity*4).ToString();
        }

        public override string pints(double quantity)
        {
            return (quantity*8).ToString();
        }

        public override string cups(double quantity)
        {
            return (quantity*16).ToString();
        }

        public override string tablespoons(double quantity)
        {
            return (quantity*256).ToString();
        }

        public override string teaspoons(double quantity)
        {
            return (quantity * 893.7).ToString();
        }
    }
}
