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
            string compressedText = "";
            int countOfLetter = 1;
            string currentLetter = "";
            Console.WriteLine("Enter the text to compress");
            string originalText = Console.ReadLine();
            int pos = 0;
            currentLetter = originalText[0].ToString();
            while (pos < originalText.Length - 1)
            {
                if (currentLetter == originalText[pos + 1].ToString())
                {
                    countOfLetter++;
                    pos++;
                }
                else
                {
                    compressedText = compressedText + currentLetter + countOfLetter;
                    currentLetter = originalText[pos +1].ToString();
                    countOfLetter = 1;
                    pos++;
                }
            }
            compressedText = compressedText + currentLetter + countOfLetter;
            Console.WriteLine(compressedText);
            Console.ReadLine();
        }
    }
}
