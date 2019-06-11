using System;

namespace Strings_Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "abc";
            string secondString = "xyz";

            Console.WriteLine(GetStringAndSwapTheFirstTwoChar(firstString, secondString));
        }
        //Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
        //Input: 'abc', 'xyz' 
        //Output: 'xyc abz

        public static string GetStringAndSwapTheFirstTwoChar(string input1, string input2)
        {
            string test1 = input2.Substring(0, 2) + input1.Substring(2);
            string test2 = input1.Substring(0, 2) + input2.Substring(2);

            return test1 + " " + test2;
        }
    }
}
