using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    internal class BaseTwo
    {
        public BaseTwo() { }
        public string Convert(double x)
        {
            int wholePart = (int)x;
            double decimalPart = x % 1;
            string w_string = GetWhole(wholePart);
            if (decimalPart > 0)
            {
                string d_string = GetFraction(decimalPart,0,"");
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
            double remainder ;
            while (!(current < 2))
            {
                Console.WriteLine(current);

                remainder = current % 2;

                result += remainder.ToString();

               
                current = (int) (current / 2);

            }
            result += (current).ToString();

            char[] array = result.ToCharArray();
            Array.Reverse(array);
            return new String(array);


        }
        private string GetFraction(double b, int depth, string result)
        {
            if(b == 0 || depth == 6)
            return result;

            double current = b * 2;

            result = result + ((int)current).ToString();

            double remainder = current % 1;
            
            return GetFraction(remainder, ++depth, result);

        }
    }
}
