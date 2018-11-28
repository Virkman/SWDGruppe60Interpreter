using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDGruppe60Interpreter.Interpreter
{
    public class ConversionContext
    {
        private string conversionQues;
        private string conversionResponse;
        private string fromConversion;
        private string toConversion;

        private double quantity;

        private string[] partsOfQues;

        public ConversionContext(string input)
        {
        conversionQues = "";
        conversionResponse = "";
        fromConversion = "";
        toConversion = "";

        conversionQues = input;

            partsOfQues = getInput().Split(' ');

            fromConversion = getCapitalized(partsOfQues[1]);

            //1 liter to gallons

            toConversion = getLowercase(partsOfQues[3]);

            quantity = Double.Parse(partsOfQues[0]);

            conversionResponse = partsOfQues[0] + " " + partsOfQues[1] + " eqauls ";

        }

        public string getInput()
        {
            return conversionQues;
        }

        public string getFromConversion()
        {
            return fromConversion;
        }
        public string getToConversion()
        {
            return toConversion;
        }
        public string getRepose()
        {
            return conversionResponse;
        }

        public double getQuantity()
        {
            return quantity;
        }


        public string getLowercase(string wordToLowercase)
        {
            return wordToLowercase.ToLower();
        }

        public string getCapitalized(string wordToCapitalize)
        {
            wordToCapitalize = wordToCapitalize.ToLower();

            wordToCapitalize = FirstLetterToUpperCase(wordToCapitalize);

            int lenghtOfWord = wordToCapitalize.Length;

            if ((wordToCapitalize.ToCharArray()[lenghtOfWord - 1]) != 's')
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(wordToCapitalize);
                sb.Append("s");
                wordToCapitalize = sb.ToString();
            }

            return wordToCapitalize;

        }

        public string FirstLetterToUpperCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
