using System;

namespace CodeChallenge1Lib
{
    public class CodeChallenge1
    {
        public bool IsPalindrome(string str)
        {
            string allLowerCase = str.ToLower();
            string checkStr = allLowerCase.Replace(" ", "");

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
