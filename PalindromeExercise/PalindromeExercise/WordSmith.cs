using System;
namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string word)
        {

            string reverseWord = "";

            Char[] wordArray = word.ToCharArray();

            Char[] newArray = new char[word.Length];

            for( var i =0; i < word.Length; i++)
            {
                    newArray[word.Length -1 - i] = wordArray[i]; 
            }

            reverseWord =  string.Join("",newArray);

            if(reverseWord == word)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
