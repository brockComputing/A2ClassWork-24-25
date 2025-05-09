using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_CreateAProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //string compressedText = "";
            //int countOfLetter = 1;
            //string currentLetter = "";
            //Console.WriteLine("Enter the text to compress");
            //string originalText = Console.ReadLine();
            //int pos = 0;
            //currentLetter = originalText[0].ToString();
            //while (pos < originalText.Length - 1)
            //{
            //    if (currentLetter == originalText[pos + 1].ToString())
            //    {
            //        countOfLetter++;
            //        pos++;
            //    }
            //    else
            //    {
            //        compressedText = compressedText + currentLetter + countOfLetter;
            //        currentLetter = originalText[pos +1].ToString();
            //        countOfLetter = 1;
            //        pos++;
            //    }
            //}
            //compressedText = compressedText + currentLetter + countOfLetter;
            //Console.WriteLine(compressedText);


            //Q9
            // bouncy numbers


            //int num = 0;
            //do
            //{
            //    Console.WriteLine("enter a number");
            //    num = Convert.ToInt32(Console.ReadLine());

            //} while (num <= 0);
            //string strNum = num.ToString();
            //int increaseCount = 0, decreaseCount = 0;
            //bool increaseing = true; bool decreaseing = true;
            //for (int i = 0; i < strNum.Length - 1; i++)
            //{
            //    if (strNum[i] < strNum[i + 1])
            //    {
            //        decreaseing = false;
            //        decreaseCount++;
            //    }
            //    else if (strNum[i] > strNum[i + 1])
            //    {
            //        increaseing = false;
            //        increaseCount++;
            //    }
            //}
            //if (decreaseing == false && increaseing == false)
            //{
            //    if (decreaseCount == increaseCount)
            //    {
            //        Console.WriteLine("perfectly bouncy");
            //    }
            //    else
            //    {
            //        Console.WriteLine("bouncy number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not a bouncy number");
            //}
            // Q8 - valid string tester

            //string test = "hello";
            //int aCode = test[1]; // aCode is the Ascii code for the letter e

            //Console.WriteLine("enter a string");
            //string theWord = Console.ReadLine();

            //if (CheckLen(theWord) && CheckCase(theWord) && CheckUnique(theWord) && CheckAscii(theWord))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("invlaid string");
            //}
            //Q7
            //string vowels = "aeiou";
            //Console.WriteLine("Enter a word");
            //string enteredText = Console.ReadLine();
            //int startpos = 0;
            //int endpos = enteredText.Length - 1;
            //while (startpos < endpos)
            //{
            //    if (vowels.Contains(enteredText[startpos]))
            //    {
            //        // find the vowel at the other end of the string at endpos
            //        while (startpos < endpos)
            //        {
            //            if (vowels.Contains(enteredText[endpos]))
            //            {
            //                //swap the vowels 
            //                string first = enteredText[startpos].ToString();
            //                string second = enteredText[endpos].ToString();
            //                enteredText = enteredText.Remove(startpos, 1);
            //                enteredText = enteredText.Insert(startpos, second);
            //                enteredText = enteredText.Remove(endpos, 1);
            //                enteredText = enteredText.Insert(endpos, first);
            //                endpos--;
            //                break;
            //            }
            //            endpos --; 
            //        }
            //    }


            //    startpos++;
            //}
            //Console.WriteLine(enteredText);
            //Q5
            //int[] frequency = new int[10];
            //Console.WriteLine("Enter how many digits");
            //int numberOFDigits = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < numberOFDigits; i++)
            //{
            //    Console.WriteLine("Enter a digit");
            //    int digit = Convert.ToInt32(Console.ReadLine());
            //    frequency[digit] = frequency[digit] + 1;
            //}
            //int largest = 0;
            //int posLargest = -1;
            //for (int i = 0;i < frequency.Length;i++)
            //{
            //    if (frequency[i] > largest)
            //    {
            //        largest = frequency[i];
            //        posLargest = i;
            //    }
            //}
            //int count = 0;
            //for (int i = 0; i < numberOFDigits; i++)
            //{
            //    if (frequency[i] == largest)
            //    {
            //        count++;
            //    }
            //}
            //if (count > 1)
            //{
            //    Console.WriteLine("multimodel");
            //}
            //else
            //{
            //    Console.WriteLine($"the most occuring number is {posLargest} appearing {frequency[posLargest]} times");
            //}

            //Q4
            Console.WriteLine("Enter the first string");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string second = Console.ReadLine();
            bool isOk = true;
            for (int i = 0; i < first.Length; i++)
            {
                //string letterFromFirst = first[i].ToString();
                string letterFromFirst = first.Substring(i, 1);
                isOk = false;
                for (int j = 0; j < second.Length; j++)
                {
                    if (letterFromFirst == second[j].ToString() )
                    {
                        second = second.Remove(j, 1);
                        isOk = true;
                    }
                }
                if (!isOk)
                {
                    break;
                }
            }
            if (isOk)
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }













            Console.ReadLine();
        }

        private static bool CheckAscii(string theWord)
        {
            int total = 0;
            for (int i = 0; i < theWord.Length; i++)
            {
                total = total + theWord[i];
            }
            if (total >= 420 && total <= 600)
            {
                return true;
            }
            Console.WriteLine("ascii total not in range");
            return false;

        }

        private static bool CheckUnique(string theWord)
        {
            string tempString = theWord;
            for (int i = 0;i < theWord.Length ;i++)
            {
                string currentChar = theWord[i].ToString();
                tempString = theWord.Remove(i, 1);
                if (tempString.Contains(currentChar))
                {
                    Console.WriteLine("duplicate found");
                    return false;
                }
            }
            return true;
        }

        private static bool CheckCase(string theWord)
        {
            string temp = theWord;
            if (temp.ToUpper() == theWord)
            {
                return true;
            }
            Console.WriteLine("not upper");
            return false;
        }

        private static bool CheckLen(string theWord)
        {
            if (theWord.Length >= 5 && theWord.Length <= 7)
            {
                return true;
            }
            Console.WriteLine("not required LENGTH");
            return false;
        }
    }
}
