using System;
using System.Text;

namespace FastSummary
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int smiley =  9786;
            //int smiley = int.Parse(Console.ReadLine());
            Console.WriteLine("The number 'smiley' is: " + smiley);
            Console.WriteLine("-------------------------------------");
            char smileyToChar = (char)smiley;
            Console.WriteLine("The character 'smiley' is: {0}", smileyToChar);
            Console.WriteLine("-------------------------------------");
            string smileyToBits = Convert.ToString(smiley, 2);
            Console.WriteLine("'smiley' in bits: {0}", smileyToBits);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("{0} bits used to represent the number {1}" + "  !!!", smileyToBits.Length, smiley);
            Console.WriteLine("-------------------------------------");
            Console.Write("END OF PROGRAM? y/n : ");
            char input = char.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            if (input == 'y')
            {
                Console.WriteLine("Bye Bye!");
            }
            else if (input == 'n')
            {
                Console.WriteLine("You need to be authorized to continue... \nEnter Username: ");
                string username = Console.ReadLine();
                if (username == "Bugs Bunny")
                {
                    Console.WriteLine("You should be a rabbit!");
                }
                else if (username == "John Jay Rambo")
                {
                    string message = "You are \"Expandable\"!";
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("Wrong Answer!");
            }


        }
    }
}
