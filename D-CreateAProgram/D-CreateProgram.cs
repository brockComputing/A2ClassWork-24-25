using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_CreateAProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NO 1
            //string compressedText = "";
            //int countOfLetter = 1;
            //string currentLetter = "";
            //Console.WriteLine("Enter the text to compress");
            //string originalText = Console.ReadLine();
            //int pos = 0;
            //currentLetter = originalText[0].ToString();
            //while (pos < originalText.Length - 1)
            //{
            //    if (currentLetter == originalText[pos +1].ToString())
            //    {
            //        pos++;
            //        countOfLetter++;
            //    }
            //    else
            //    {
            //        compressedText = compressedText + currentLetter + countOfLetter;
            //        currentLetter= originalText[pos +1].ToString();
            //        pos++;
            //        countOfLetter = 1;
            //    }
            //}
            //compressedText = compressedText + currentLetter + countOfLetter;
            //Console.WriteLine(compressedText);

            //int num = 0;
            //do
            //{
            //    Console.WriteLine("enter a number");
            //    num = Convert.ToInt32(Console.ReadLine());

            //no 9
            //} while (num <= 0);
            //string strNum = num.ToString();
            //int countOfIncreasing = 0;
            //int countOfDecreasing = 0;
            //bool increasing = true;
            //bool decreasing = true;
            //for (int i = 0; i < strNum.Length - 1; i++)
            //{
            //    if (strNum[i] < strNum[i + 1])
            //    {
            //        decreasing = false;
            //        countOfIncreasing++;
            //    }
            //    else if (strNum[i] > strNum[i + 1])
            //    {
            //        increasing = false;
            //        countOfDecreasing++;
            //    }
            //}
            //if (increasing == false && decreasing == false)
            //{
            //    if (countOfIncreasing == countOfDecreasing)
            //    {
            //        Console.WriteLine("perfectly bouncy");
            //    }
            //    else
            //    {
            //        Console.WriteLine("bouncy");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not bouncy");
            //}
            //Console.ReadLine();

            // No8

            //    string test = "hello";
            //    int asciiValue = test[1]; // ascii code of e

            //    Console.WriteLine("enter a string");
            //    string theWord = Console.ReadLine();
            //    if (CheckLen(theWord) && CheckCase(theWord) && CheckUnique(theWord) 
            //        && CheckAscii(theWord))
            //    {
            //        Console.WriteLine("Valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid");
            //    }


            //    Console.ReadLine();
            //}
            // NO 7
            //string vowels = "aeiou";
            //string enteredText = "";
            //Console.WriteLine("enter word");
            //enteredText = Console.ReadLine();
            //int startPos = 0;
            //int endPos = enteredText.Length - 1;
            //while (endPos > startPos)
            //{
            //    if (vowels.Contains(enteredText[startPos]))
            //    {
            //        while (endPos > startPos)
            //        {
            //            if (vowels.Contains(enteredText[endPos]))
            //            {
            //                // swap
            //                string first = enteredText[startPos].ToString();
            //                string second = enteredText[endPos].ToString();
            //                enteredText = enteredText.Remove(startPos, 1);
            //                enteredText = enteredText.Insert(startPos, second);
            //                enteredText = enteredText.Remove(endPos, 1);
            //                enteredText = enteredText.Insert(endPos, first);
            //                endPos--;
            //                break;
            //            }
            //            endPos--;
            //        }
            //    }
            //    startPos++;
            //}
            //Console.WriteLine(enteredText);
            // No 5
            //int[] frequency = new int[10];
            //Console.WriteLine("Enter how many digits");
            //int numberOFDigits = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < numberOFDigits; i++)
            //{
            //    Console.WriteLine("Enter a digit");
            //    int digit = Convert.ToInt32(Console.ReadLine());
            //    frequency[digit] = frequency[digit] + 1;
            //}
            //// find the highest freqeuncy
            //int highest = frequency[0];
            //int posHighest = 0;
            //for (int i = 0; i < frequency.Length; i++)
            //{
            //    if (frequency[i] > highest)
            //    {
            //        highest = frequency[i];
            //        posHighest = i;
            //    }
            //}
            //// check if multimodel
            //int counter = 0;
            //for (int i = 0; i < frequency.Length; i++)
            //{
            //    if (frequency[i] == highest)
            //    {
            //        counter++;
            //    }
            //}
            //if (counter > 1)
            //{
            //    Console.WriteLine("multimodel");
            //}
            //else
            //{
            //    Console.WriteLine($"the most common number is {posHighest} with a freqency os {frequency[posHighest]}");
            //}

            // no 4
            Console.WriteLine("Enter the first word");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string second = Console.ReadLine();
            bool isOk = true;

            // loop through first
            for (int i = 0; i < first.Length; i++)
            {
                // string letterFromFirst = first[i].ToString();
                string letterFromFirst = first.Substring(i, 1);
                isOk = false;
                for (int j = 0; j < second.Length; j++)
                {
                    if (letterFromFirst == second[j].ToString())
                    {
                        second = second.Remove(j, 1);
                        isOk = true;
                        break;
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
        //private static bool CheckAscii(string theWord)
        //{
        //    int total = 0;
        //    for (int i = 0; i < theWord.Length; i++)
        //    {
        //        total = total + theWord[i];
        //    }
        //    if (total >= 420 && total <= 600)
        //    {
        //        return true;
        //    }
        //    Console.WriteLine("ascii total wrong");
        //    return false;
        //}

        //private static bool CheckUnique(string theWord)
        //{
        //    // remove current from the string and check to see if the remaining contains the removed
        //    string currentChar = "";
        //    string tempString = theWord;
        //    for (int i = 0;i < theWord.Length;i++)
        //    {
        //        currentChar = theWord[i].ToString();
        //        tempString = theWord.Remove(i);
        //        if (tempString.Contains(currentChar))
        //        {
        //            Console.WriteLine("duplicated ");
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //private static bool CheckCase(string theWord)
        //{
        //    string temp= theWord;
        //    if (temp.ToUpper() == theWord)
        //    {
        //        return true;
        //    }
        //    Console.WriteLine("not upper");
        //    return false;
        //}

        //private static bool CheckLen(string theWord)
        //{
        //    if (theWord.Length >=5 && theWord.Length <=7)
        //    {
        //        return true;
        //    }
        //    Console.WriteLine("lenght problem");
        //    return false;
        //}

    }
}
