using System;
using System.Text.RegularExpressions;

namespace CodeChallenge1Lib
{
    public class CodeChallenge1
    {
        //The method decides if the given string STR is a palindrome.
        public bool IsPalindrome(string str)
        {
            string allLowerCase = str.ToLower();
            string checkStr = Regex.Replace(allLowerCase, @"[^0-9a-zA-Z]+", "");

            int strLength = checkStr.Length;


            for (int i = 0; i < strLength / 2; i++)
            { 
                    if (checkStr[i] != checkStr[(strLength - 1) - i])
                    {
                        return false;
                    }
            }

            return true;
        }
    }
}
