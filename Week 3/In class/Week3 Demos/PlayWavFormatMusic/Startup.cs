using System;
using System.Media;
using System.Text;

namespace PlayWavFormatMusic
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("ХаФана бийч, бейби ;)");
            var simpleSound = new SoundPlayer("../../wav-files/nj.wav");
            simpleSound.Play();

            Student peshko = new Student()
            {
                Name = "Пешко",
                University = "ХаФана бийч, бейби ;)",
                FacultyNumber = 9088888,
                IsGraduated = false,
                OverallScore = 99.99
            };

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Greetings from the best party place in the world!");
            Console.WriteLine("Любен Киков");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Press any key to stop the program!");
            Console.ReadKey();
        }
    }
}
