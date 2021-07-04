using System;

namespace PalindromeChecker
{
    class checker
    {
        static void StringChecker(string string1)
        {

            string rev;
            char[] ch = string1.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("String " + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine("String " + string1 + " is not a Palindrome!");
            }
        }
    }
}
