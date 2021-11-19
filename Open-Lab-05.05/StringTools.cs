using System;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            string newString = "";
            int nexPos = 0;
            for (int i = 0; i < original.Length; i++)
            {
                
                if (String.IsNullOrWhiteSpace(original[i].ToString()))
                {
                    nexPos--;
                }

                if (nexPos == 0)
                {
                    newString += original[i].ToString().ToUpper();
                }
                else if (nexPos % 2 == 0)
                {
                    newString += original[i].ToString().ToUpper();
                }
                else
                {
                    newString += original[i].ToString().ToLower();
                }
                nexPos++;
            }
            return newString;
        }
    }
}
