using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    class RomanNumeralsEncoder
    {

        //Based on https://www.codewars.com/kata/51b62bf6a9c58071c600001b/train/csharp

        public static String Solution(int n)
        {

            String yearAsString = n + "";
            String roman = "";

            if (yearAsString.Length == 1)
            {
                yearAsString = "000" + yearAsString;
            }
            else if (yearAsString.Length == 2)
            {
                yearAsString = "00" + yearAsString;
            }
            else if (yearAsString.Length == 3)
            {
                yearAsString = "0" + yearAsString;
            }

            switch (yearAsString[0])
            {
                case '0':
                    roman += "";
                    break;
                case '1':
                    roman += "M";
                    break;
                case '2':
                    roman += "MM";
                    break;
                case '3':
                    roman += "MMM";
                    break;
            }

            switch (yearAsString[1])
            {
                case '0':
                    roman += "";
                    break;
                case '1':
                    roman += "C";
                    break;
                case '2':
                    roman += "CC";
                    break;
                case '3':
                    roman += "CCC";
                    break;
                case '4':
                    roman += "CD";
                    break;
                case '5':
                    roman += "D";
                    break;
                case '6':
                    roman += "DC";
                    break;
                case '7':
                    roman += "DCC";
                    break;
                case '8':
                    roman += "DCCC";
                    break;
                case '9':
                    roman += "CM";
                    break;
            }

            switch (yearAsString[2])
            {
                case '0':
                    roman += "";
                    break;
                case '1':
                    roman += "X";
                    break;
                case '2':
                    roman += "XX";
                    break;
                case '3':
                    roman += "XXX";
                    break;
                case '4':
                    roman += "XL";
                    break;
                case '5':
                    roman += "L";
                    break;
                case '6':
                    roman += "LX";
                    break;
                case '7':
                    roman += "LXX";
                    break;
                case '8':
                    roman += "LXXX";
                    break;
                case '9': roman += "XC";
                    break;
            }

            switch (yearAsString[3])
            {
                case '0':
                    roman += "";
                    break;
                case '1':
                    roman += "I";
                    break;
                case '2':
                    roman += "II";
                    break;
                case '3':
                    roman += "III";
                    break;
                case '4':
                    roman += "IV";
                    break;
                case '5':
                    roman += "V";
                    break;
                case '6':
                    roman += "VI";
                    break;
                case '7':
                    roman += "VII";
                    break;
                case '8':
                    roman += "VIII";
                    break;
                case '9': roman += "IX";
                    break;

            }

            return roman;
        }
    }
}
