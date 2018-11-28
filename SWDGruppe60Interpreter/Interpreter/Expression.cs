using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDGruppe60Interpreter.Interpreter
{
    public abstract class Expression
    {
        public abstract string gallons(double quantity);
        public abstract string liter(double quantity);
        public abstract string quarts(double quantity);
        public abstract string pints(double quantity);
        public abstract string cups(double quantity);
        public abstract string tablespoons(double quantity);
        public abstract string teaspoons(double quantity);
    }
}
