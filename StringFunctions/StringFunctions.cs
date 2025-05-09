using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class StringFunctions
    {
        static void Main(string[] args)
        {
            

            //Length	It is a string property that returns length of string.
            string s1 = "abcd";
            Console.WriteLine(s1.Length); // outputs 4

            //Contains()	The C# Contains method checks whether specified character or string is exists or not in the string value.
            s1 = "abcd";
            if (s1.Contains("bc")) // outputs true
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

            //EndsWith()	This EndsWith Method checks whether specified string is the last charcters of string or not.
            s1 = "abcd";
            if (s1.EndsWith("d")) //outputs true
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

            //StartsWith()	This StartsWith Method checks whether specified string is the first charcters of string or not.
            s1 = "abcd";
            if (s1.StartsWith("a")) //outputs true
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }


            // IndexOf()	Returns the index position of first occurrence of specified character.
            s1 = "abccd";
            Console.WriteLine("The first c occusrs at position " + s1.IndexOf("c")); // outputs 2

            //Insert()	Insert the string or character in the string at the specified position.
            s1 = "abccd";
            s1 = s1.Insert(2, "xx");
            Console.WriteLine(s1); // s1 now "abxxccd"

            // Remove()	This method deletes all the characters from beginning to specified index position, or by using a second argument a number of chars
            s1 = "abccd";
            s1 = s1.Remove(2, 2);
            Console.WriteLine(s1); // s1 now "abd"

            // Replace()	This method replaces the character.
            s1 = "abccd";
            s1 = s1.Replace("c", "x");
            Console.WriteLine(s1); // s1 now "abxxd"

            //Split() This method splits the string based on specified value.
            s1 = "a,b,c,d";
            string[] splitArray = s1.Split(','); // note single quotes as must be a char not a string 
            Console.WriteLine(splitArray[3]); // outputs "d"

            // SubString() Get parts from existing strings. Pass start and length arguments.
            s1 = "abcd";
            string s2 = s1.Substring(1);
            Console.WriteLine(s2); // outputs "bcd"
            s2 = s1.Substring(2, 1);
            s2 = s1[2].ToString();
            Console.WriteLine(s2); // outputs "c"

            // Replacing individual chars in a string

            s1 = "abcd";
            //s1[1] = x; // you cannot do this as a string is immutable
            s1 = s1.Remove(1, 1); // s1 now acd
            s1 = s1.Insert(1, "x"); // s1 now axcd
            Console.WriteLine(s1); // outputs axcd

            // converting a string to an array useful if you want to modify individual chars can then be converted back to a string
            s1 = "abcd";
            char[] charArray = s1.ToArray(); // converts string to charArray
            charArray[1] = 'x'; // change pos 1 in the array
            s1 = new string(charArray); // s1 = the charArray
            Console.WriteLine(s1);

            Console.ReadLine();

        }
    }
}
