using System;
using CodeChallenge1Lib;

namespace CodeChallenge1Main
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeChallenge1 codeChall = new CodeChallenge1();

            string str1 = "nurses run";

            Console.WriteLine(codeChall.IsPalindrome(str1));
        }
    }
}
