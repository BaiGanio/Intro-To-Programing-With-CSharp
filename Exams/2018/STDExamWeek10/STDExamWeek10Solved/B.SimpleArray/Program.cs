using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a string variable, which will store our commands for the program
            string command;

            // Declare and initialize an integer variable, which will store the length of the array
            Console.Write("Enter number of elements: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            /* Declare and intialize the array and using the InputArray() method,
               fill it with user input numbers. */
            int[] simpleArray = new int[numberOfElements];
            InputArray(simpleArray);

            /* The core of the program will be a do-while loop, which will iterate
               until the user command becomes "End". During that time the user will
               perform different operations/commands. */
            do
            {
                Console.WriteLine("Choose a command (swap, increase, decrease or info) or type 'End' if you want to exit:");
                command = Console.ReadLine();

                switch (command)
                {
                    /* Each command is separated in its own method. After the command
                       is finished, OutputArray() is called to display the changes in the array (if there are any). */
                    case "swap":
                        SwapElementsInArray(simpleArray);
                        OutputArray(simpleArray);
                        break;
                    case "increase":
                        IncreaseArrayElementsUsingString(simpleArray);
                        OutputArray(simpleArray);
                        break;
                    case "decrease":
                        DecreaseArrayElementsUsingNumber(simpleArray);
                        OutputArray(simpleArray);
                        break;
                    case "info":
                        ArrayInfo(simpleArray);
                        OutputArray(simpleArray);
                        break;
                }
            } while (command != "End");

            // After the user breaks out of the loop, we'll call OutputArray() one last time.
            OutputArray(simpleArray);
        }

        // Simple methods for input and output of an array
        static void InputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void OutputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + arr[i]);
            }
        }

        /* This method will be responsible for swapping two elements of the array
           using their indexes (which will be given by the user) */
        static void SwapElementsInArray(int[] arr)
        {
            // Declaring and initalizing the variables we need
            int index1 = 0;
            int index2 = 0;
            int numberSwap = 0; // This is a temporary (temp) variable. It will be useful when we swap the numbers

            bool index1IsNumber = false;
            bool index2IsNumber = false;

            string indexes;

            // Check if the user input is correct
            while (!index1IsNumber || !index2IsNumber)
            {
                Console.WriteLine("Enter the indexes of the two elements you want to swap (seperate them with a space): ");
                indexes = Console.ReadLine();
                // First, check if there is only one space. If there is more than one, iterate one more time
                if (!indexes.Contains(" "))
                {
                    Console.WriteLine("Input must contain only one space!!");
                    continue; // Skip the rest of the code below in the while loop 
                }

                /* Second, check if the indexes are actually numbers.
                   Here we use the Substring() and IndexOf() methods from class String
                   to get the values for index1 and index2. If you don't know what they
                   do, it is essential that you familiarise yourself with them and other String methods. */
                index1IsNumber = int.TryParse(indexes.Substring(0, indexes.IndexOf(" ")), out index1);
                index2IsNumber = int.TryParse(indexes.Substring(indexes.IndexOf(" ")), out index2);

                // In the end, check if the numbers are not greater than the length of the array
                if (index1 > arr.Length || index2 > arr.Length)
                {
                    Console.WriteLine("The input numbers were greater than the length of the array!");
                    index1IsNumber = false;
                    index2IsNumber = false;
                }
            }

            // Swap the two numbers with the help of the temp variable
            numberSwap = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = numberSwap;
        }

        /* This command will increase every array element with the total sum of
           the elements in a string (every word/string is comprised of letters/chars) */
        static void IncreaseArrayElementsUsingString(int[] arr)
        {
            int charSum = 0;

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            // Add up the values of every character and display the sum.
            foreach (char c in word)
            {
                Console.WriteLine($"{c} --> {(int)c}");
                charSum += c;
            }

            Console.WriteLine("Total sum: " + charSum);

            // Increase every array element with the given sum
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += charSum;
            }
        }

        // This command will decrease every array element with an user defined number
        static void DecreaseArrayElementsUsingNumber(int[] arr)
        {
            /* Check if the user input is actually a number and if it is, decrease
               each element with it */
            bool inputIsNumber = false;
            int number = 0;
            
            while (!inputIsNumber)
            {
                Console.WriteLine("Enter a number: ");
                inputIsNumber = int.TryParse(Console.ReadLine(), out number);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= number;
            }
        }

        // This is the simplest command. It will give information about the array
        static void ArrayInfo(int[] arr)
        {
            int arraySum = 0;
            int greatestArrayElement = arr[0];
            int leastArrayElement = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                // Find the greatest element of the array
                if (arr[i] > greatestArrayElement)
                {
                    greatestArrayElement = arr[i];
                }

                // Find the least element of the array
                if (arr[i] < leastArrayElement)
                {
                    leastArrayElement = arr[i];
                }

                // Find the sum of the elements of the array
                arraySum += arr[i];
            }

            // Display the gathered information
            Console.WriteLine("Array count --> " + arr.Length);
            Console.WriteLine("Max element --> " + greatestArrayElement);
            Console.WriteLine("Min element --> " + leastArrayElement);
            Console.WriteLine("Total sum --> " + arraySum);
        }
    }
}
