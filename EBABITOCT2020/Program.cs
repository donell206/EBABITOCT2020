using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBABITOCT2020
{
    class Program
    {


        static double[] FindMinMax(double[] values)
        {
            return new[] { values.Min(), values.Max() };
        }
    }
}


//Create a function that repeats each character in a string n times.

//Examples
//Repeat("mice", 5) ➞ "mmmmmiiiiiccccceeeee"

//Repeat("hello", 3) ➞ "hhheeellllllooo"

//Repeat("stop", 1) ➞ "stop"
//public class Program
//{
//    public static string Repeat(string str, int num)
//    {
//        string s = "";
//        for (int i = 0; i < str.Length; i++)
//        {
//            for (int j = 0; j < num; j++)
//            {
//                s = s + str[i];
//            }
//        }
//        return s;
//    }
//}

//-------------------------------------------------------------------------------------------------

//Create a function that takes a string and returns the number (count) of vowels contained within it.

//Examples
//CountVowels("Celebration") ➞ 5

//CountVowels("Palm") ➞ 1

//CountVowels("Prediction") ➞ 4
//Notes
//a, e, i, o, u are considered vowels (not y).
//All test cases are one word and only contain letters.



//public class Program
//{
//    public static int CountVowels(string str)
//    {
//        int result = 0;
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (str[i] == 'a' || str[i] == 'i' || str[i] == 'e' || str[i] == 'u' || str[i] == 'o')
//                result++;
//        }

//        return result;
//    }
//}

//public class Program
//{
//    public static int CountVowels(string str)
//    {
//        char[] vowelArr = { 'A', 'E', 'I', 'O', 'U' };
//        char[] strCharArr = str.ToUpper().ToCharArray();
//        int vowelCount = 0;
//        foreach (char strChar in strCharArr)
//            foreach (char vowel in vowelArr)
//                if (vowel == strChar)
//                    vowelCount++;

//        return vowelCount;
//    }
//}