using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.Assignments
{
    internal class StringOperations
    {
        public static string ReverseAndUppercase(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray).ToUpper();
        }
    }
}
