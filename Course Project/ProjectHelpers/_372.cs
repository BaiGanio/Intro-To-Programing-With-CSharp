using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectHelpers
{
    public class _372
    {
        public void DecryptEncryptNames(string[] towns)
        {
            int counter = 0;
            List<string> encryptedTowns = new List<string>();
            Console.WriteLine("Encrypt town names: ");
            foreach (string town in towns)
            {
                char[] townInChars = town.ToCharArray();
                string tonz = "";
                for (int i = 0; i < townInChars.Length; i++)
                {
                    int letterValue = (int)townInChars[i];
                    letterValue += 5;
                    townInChars[i] = (char)letterValue;
                }
                tonz = new string(townInChars);
                encryptedTowns.Add(tonz);
            }

            foreach (string town in encryptedTowns)
            {
                Console.WriteLine("Encrypted to => " + town);
            }
            //Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void NamesLessThanAverageLengthOfAllNames(string[] towns)
        {
            int counter = 0;
            int totalChars = 0;
            Console.WriteLine("Town names who have maximum length less than avarage for all names: ");
            foreach (string town in towns)
            {
                for (int i = 0; i < town.Length; i++)
                {
                    totalChars++;
                }
            }
            Console.WriteLine("Total chars: " + totalChars );
            double averageLength = (double)totalChars/towns.Length;
            Console.WriteLine("Average length: " + averageLength);
            foreach (string town in towns)
            {
                if (town.Length <= averageLength)
                {
                    Console.WriteLine(town);
                    counter++;
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void MaximumNameLength(string[] towns)
        {
            int counter = 0;
            int maximumLength = 0;
            Console.WriteLine("Town names who have maximum length: ");
            foreach (string town in towns)
            {
                if (town.Length > maximumLength)
                {
                    maximumLength = town.Length;
                }
            }
            Console.WriteLine("Max chars " + maximumLength);
            foreach (string town in towns)
            {
                if (town.Length == maximumLength)
                {
                    Console.WriteLine(town);
                    counter++;
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void NamesWhoContainsSpecificLetterAndDoesNotAnotherLetter(string[] towns)
        {
            int counter = 0;
            Console.WriteLine("Town name who contains specific letter more than 'n' times & doesn't contain another specific letter: ");
            foreach (string town in towns)
            {
                int countSpecificLetter = 0;
                if (!town.Contains('р'))
                {
                    for (int i = 0; i < town.Length; i++)
                    {
                        if (town[i] == 'е' || town[i] == 'Е')
                        {
                            countSpecificLetter++;
                        }
                    }
                }
                if (countSpecificLetter >= 2)
                {
                    Console.WriteLine(town);
                    counter++;
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void NamesWhoContainsSpecificLetter(string[] towns)
        {
            int counter = 0;
            Console.WriteLine("Town name who contains specific letter more than 'n' times: ");
            foreach (string town in towns)
            {
                int countSpecificLetter = 0;
                for (int i = 0; i < town.Length; i++)
                {
                    if (town[i] == 'о' || town[i] == 'О')
                    {
                        countSpecificLetter++;
                    }
                }
                if (countSpecificLetter >= 3)
                {
                    Console.WriteLine(town);
                    counter++;
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void NameEndsWithSpecificWord(string[] towns)
        {
            int counter = 0;
            Console.WriteLine("Town name who ends with specific word': ");
            foreach (string town in towns)
            {
                string match = "ово";
                if (town.Contains(match))
                {
                    Console.WriteLine(town);
                    counter++;
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void NameConsistTwoWords(string[] towns)
        {
            int counter = 0;
            Console.WriteLine("Town name who consist two words': ");
            foreach (string town in towns)
            {
                string[] words = town.Split(' ');
                if (words.Length > 1)
                {
                    foreach (var word in words)
                    {
                        Console.Write(word + " ");
                    }
                    counter++;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void NameBeginsWithSpecificWord(string[] towns)
        {
            int counter = 0;
            Console.WriteLine("Town name who begins with 'Долни' or 'Долен': ");
            foreach (string town in towns)
            {
                if (town.Contains("Долни") || town.Contains("Долен"))
                {
                    Console.WriteLine(town);
                    counter++;
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public void ContainsSpecificWordInTheName(string[] towns)
        {
            int counter = 0;
            Console.WriteLine("Towns with 'град' or 'Град'  in the name: ");
            foreach (string town in towns)
            {
                if (town.Contains("град") || town.Contains("Град"))
                {
                    Console.WriteLine(town);
                    counter++;
                }
            }
            Console.WriteLine("Total matches: [{0}]", counter);
        }
        public string[] FillArrayWithTownNames(string outputPath)
        {
            List<string> names = new List<string>();
            using (StreamReader reader = new StreamReader(outputPath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string town = line.Substring(0, line.Length-1);
                    //Console.WriteLine(town);
                    names.Add(town);
                    line = reader.ReadLine();
                }
            }
            return names.ToArray();
        }
    }
}
