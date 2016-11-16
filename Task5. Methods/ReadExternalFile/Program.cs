using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadExternalFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string pathToFakeNames =
                @"C:\Users\Republic Of Gamers\OneDrive\Plovdiv University\Intro to programming course\Увод в програмирането C# 2016-2017\Fake files/fake-names.txt";
            string pathToSimpleText =
                @"C:\Users\Republic Of Gamers\OneDrive\Plovdiv University\Intro to programming course\Увод в програмирането C# 2016-2017\Fake files/simple-text.txt";

            Console.WriteLine("The data in the fake names file is: ");
            ReadExternalFiles(pathToFakeNames);

            Console.WriteLine("=========================================================");

            Console.Write("Enter char wich will be searched in text: ");
            try
            {
                char searchedChar = char.Parse(Console.ReadLine());
                int counter = CountSpecificLetter(searchedChar, pathToSimpleText);
                Console.WriteLine("The letter {0} was found {1} times in the text.", searchedChar, counter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("If you don't want to play fear - I'll QUIT!!!");
            }
            Console.WriteLine("BYE BYE!");

            Console.WriteLine("=========================================================");

            string[] hacked = FindPrivateData(pathToSimpleText);

            Console.WriteLine("Founded: {0}", hacked[0]);
            Console.WriteLine("Founded: {0}", hacked[1]);
        }

        static void ReadExternalFiles(string filePath)
        {
            StreamReader lineReader = new StreamReader(filePath);
            string currentLine = lineReader.ReadLine();

            while (currentLine != null)
            {
                Console.WriteLine("Student: {0}", currentLine);
                currentLine = lineReader.ReadLine();
            }
        }
        static int CountSpecificLetter(char letter, string filePath)
        {
            StreamReader lineReader = new StreamReader(filePath);
            string currentLine = lineReader.ReadLine();
            int occurences = 0;
            while (currentLine != null)
            {
                for (int i = 0; i < currentLine.Length; i++)
                {
                    if (currentLine[i] == letter)
                    {
                        occurences++;
                    }
                }
                currentLine = lineReader.ReadLine();
            }
            return occurences;
        }
        static string[] FindPrivateData(string filePath)
        {
            string[] foundedData = new string[2];
            StreamReader lineReader = new StreamReader(filePath);
            string currentLine = lineReader.ReadLine();
            while (currentLine != null)
            {
                if (currentLine.Contains("username") || currentLine.Contains("Username"))
                {
                    foundedData[0] = currentLine;
                }
                if (currentLine.Contains("password") || currentLine.Contains("Password"))
                {
                    foundedData[1] = currentLine;
                }
                currentLine = lineReader.ReadLine();
            }

            return foundedData;
        }
    }
}
