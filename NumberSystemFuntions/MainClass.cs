using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemFuntions
{
    public class MainClass
    {

        public Int64 DecimaltoBinary(int num)
        {
            string binary = "";

            while (num > 0)
            {
                binary = (num % 2).ToString() + binary;
                num /= 2;
            }
            return Convert.ToInt64(binary);
        }
        public int DecimaltoOctal(int num)
        {
            string octal = "";

            while (num > 0)
            {
                octal = (num % 8).ToString() + octal;
                num /= 8;
            }
            return Convert.ToInt32(octal);
        }
        public string DecimalToHexadecimal(int num)
        {
            string hexadicimal = "";
            string alp = "0123456789ABCDEF";

            while (num > 0)
            {
                hexadicimal = alp[num % 16] + hexadicimal;
                num /= 16;
            }
            return hexadicimal;
        }
    }
}
