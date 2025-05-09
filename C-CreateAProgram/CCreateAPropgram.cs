using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CreateAProgram
{
    internal class CCreateAPropgram
    {
        static void Main(string[] args)
        {
            //no1
            //string compressedText = "";
            //int countOfLetter = 1;
            //string currentLetter = "";
            //Console.WriteLine("Enter the text to compress");
            //string originalText = Console.ReadLine();
            //int pos = 0;
            //currentLetter = originalText[0].ToString();
            //while (pos < originalText.Length - 1)
            //{
            //    if (currentLetter == originalText[pos+1].ToString())
            //    {
            //        pos++;
            //        countOfLetter++;
            //    }
            //    else
            //    {
            //        compressedText = compressedText + currentLetter + countOfLetter;
            //        currentLetter = originalText[pos + 1].ToString();
            //        pos++;
            //        countOfLetter = 1;
            //    }
            //}
            //compressedText = compressedText + currentLetter + countOfLetter;
            //Console.WriteLine(compressedText);


            // bouncy numbers
            // no 9
            //int num = 0;
            //do
            //{
            //    Console.WriteLine("enter a number");
            //    num = Convert.ToInt32(Console.ReadLine());

            //} while (num <= 0);
            //string strNum = num.ToString();
            //int countOfIncreasing = 0;
            //int countOfDecreasing = 0;

            //for (int i = 0; i < strNum.Length - 1; i++)
            //{
            //    if (strNum[i] < strNum[i + 1])
            //    {
            //        countOfIncreasing++;
            //    }
            //    else if (strNum[i] > strNum[i + 1])
            //    {
            //        countOfDecreasing++;
            //    }
            //}
            //if (countOfDecreasing == countOfIncreasing && countOfDecreasing != 0)
            //{
            //    Console.WriteLine("perfectly bouncy");
            //}
            //else if(countOfDecreasing != 0 && countOfIncreasing != 0)
            //{
            //    Console.WriteLine("bouncy");
            //}
            //else
            //{
            //    Console.WriteLine("Not a bouncy number");
            //}
            //No8
            Console.WriteLine("enter a string");
            string theWord = Console.ReadLine();
            if (CheckLEn(theWord) && CheckCase(theWord) && CheckUnique(theWord)
                && CheckAscii(theWord))
            {
                Console.WriteLine("all good");
            }
            else
            {
                Console.WriteLine("all bad");
            }

            Console.ReadLine();
        }

        private static bool CheckAscii(string theWord)
        {
            int asciiCode = 0;
            for (int i = 0; i < theWord.Length; i++)
            {
                asciiCode = asciiCode + theWord[i]; // chars are converted to ascii code
            }
            if (asciiCode >= 420 && asciiCode <= 600)
            {
                return true;
            }
            Console.WriteLine("ascii codes not in range");
            return false;
        }

        private static bool CheckUnique(string theWord)
        {
            for (int i = 0; i < theWord.Length; i++)
            {
                for (int j = i+1; j < theWord.Length - 1; j++)
                {
                    if (theWord[i].ToString() == theWord[j].ToString())
                    {
                        Console.WriteLine("NOT UNIQUE");
                        return false;
                    }
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
            Console.WriteLine("NOT UPPERCASE");
            return false;
        }

        private static bool CheckLEn(string theWord)
        {
            if (theWord.Length >= 5 && theWord.Length <= 7)
            {
                return true;
            }
            Console.WriteLine("NOT 5 TO 7 CHARS");
            return false;
        }
    }
}






