using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ProjectHelpers;

namespace TownNames
{
    class Program
    {
        private const string OutputPath = @"C:\Users\Republic Of Gamers\OneDrive\Plovdiv University\Intro to programming course\Увод в програмирането C# 2016-2017\Fake files\Town-names.txt";
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Call372(OutputPath);
        }

        private static void Call372(string outputPath)
        {
            // Create object who will solve the task
            _372 solver372 = new _372();
            // A
            string[] towns = solver372.FillArrayWithTownNames(outputPath);
            Console.WriteLine("Total towns in array : [{0}]", towns.Length);
            Console.WriteLine("--------------------------------------------------");
            // B
            solver372.ContainsSpecificWordInTheName(towns);
            Console.WriteLine("--------------------------------------------------");
            // C
            solver372.NameBeginsWithSpecificWord(towns);
            Console.WriteLine("--------------------------------------------------");
            // D
            solver372.NameConsistTwoWords(towns);
            Console.WriteLine("--------------------------------------------------");
            // E
            solver372.NameEndsWithSpecificWord(towns);
            Console.WriteLine("--------------------------------------------------");
            // F
            solver372.NamesWhoContainsSpecificLetter(towns);
            Console.WriteLine("--------------------------------------------------");
            // G
            solver372.NamesWhoContainsSpecificLetterAndDoesNotAnotherLetter(towns);
            Console.WriteLine("--------------------------------------------------");
            // H
            solver372.MaximumNameLength(towns);
            Console.WriteLine("--------------------------------------------------");
            // I
            solver372.NamesLessThanAverageLengthOfAllNames(towns);
            Console.WriteLine("--------------------------------------------------");
            // J
            solver372.DecryptEncryptNames(towns);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
