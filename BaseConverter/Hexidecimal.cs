using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    internal class Hexidecimal
    {
        public Dictionary<int, string> GetHexValues = new Dictionary<int, string>()
        {
            {0,"0" },{1,"1" }, {2,"2" }, {3,"3" }, {4,"4" }, {5,"5" },
            {6,"6" }, {7,"7" }, {8,"8" }, {9,"9" }, {10,"A" }, {11,"B" },
            {12,"C" }, {13,"D" }, {14,"E" }, {15,"F" }
        };
        public Hexidecimal() { }
        public string Convert(double x)
        {
            int wholePart = (int)x;
            double decimalPart = x % 1;
            string w_string = GetWhole(wholePart);
            if (decimalPart > 0)
            {
                string d_string = GetFraction(decimalPart, 0, "");
                return w_string + "." + d_string;
            }
            return w_string;

        }
        private string GetWhole(int a)
        {
            if (a == 0)
                return "0";

            string result = "";
            double current = a;
            double remainder;
            while (!(current < 16))
            {
                
                remainder = current % 16;

                result += GetHexValues[(int)remainder].ToString();

                current = (int)(current / 16);

            }
            result += GetHexValues[(int)current].ToString();

            char[] array = result.ToCharArray();
            Array.Reverse(array);
            return new String(array);


        }
        private string GetFraction(double b, int depth, string result)
        {
            if (b == 0 || depth == 6)
                return result;

            double current = b * 16;

            result += GetHexValues[(int)current].ToString();

            double remainder = current % 1;

            return GetFraction(remainder, ++depth, result);

        }

    }
}
