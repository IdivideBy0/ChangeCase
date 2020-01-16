using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCase
{
    class Program
    {
        static void Main(string[] args)
        {

            string strTemp = "murray";

            string result1 = StringHelper.ChangeFirstLetterCase(strTemp);

            string result2 = StringHelper.ChangeLetterCaseByPosition(strTemp, 3);

            Console.WriteLine(result1 + " " + result2);
        }
    }



    public class StringHelper
    {

        public static string ChangeFirstLetterCase(string inputStr)
        {
            char[] charArray = inputStr.ToCharArray();
            char targetChar = charArray[0];

            targetChar = char.IsUpper(targetChar) ? char.ToLower(targetChar) : char.ToUpper(targetChar);


            char[] buffer = charArray;

            buffer.SetValue(targetChar, 0);

            string result = new string(buffer);


            return result;
        }

        public static string ChangeLetterCaseByPosition(string inputStr, int position)
        {
            char[] charArray = inputStr.ToCharArray();
            char targetChar = charArray[position];

            targetChar = char.IsUpper(targetChar) ? char.ToLower(targetChar) : char.ToUpper(targetChar);

            char[] buffer = charArray;

            buffer.SetValue(targetChar, position);

            string result = new string(buffer);

            return result;
        }

    }
}
