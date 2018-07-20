using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            // The whole program will be a loop, which will break once the
            // user doesn't want to make any more calculations (answer is "no").
            do
            {
                Console.WriteLine("Do you want to make some calculations? yes/no");
                answer = Console.ReadLine();

                // Once the user types "yes" in the console, he will be prompted to start making calculations
                if (answer == "yes")
                {
                    double firstNumber = 0;
                    double secondNumber = 0;

                    bool firstInputIsNumber = false;
                    bool secondInputIsNumber = false;

                    // Check if first and second number are valid
                    while (!firstInputIsNumber)
                    {
                        Console.WriteLine("Enter first number:");
                        firstInputIsNumber = double.TryParse(Console.ReadLine(), out firstNumber);

                        if (!firstInputIsNumber)
                        {
                            Console.WriteLine("Enter a valid number!");
                        }
                    }

                    while (!secondInputIsNumber)
                    {
                        Console.WriteLine("Enter second number:");
                        secondInputIsNumber = double.TryParse(Console.ReadLine(), out secondNumber);

                        if (!secondInputIsNumber)
                        {
                            Console.WriteLine("Enter a valid number!");
                        }
                    }

                    // Enter a Math operator
                    Console.WriteLine("Enter an operation (+, -, * or /).");
                    char calcOperator = char.Parse(Console.ReadLine());
                    double result;

                    // Perform the required tasks for each operator
                    switch (calcOperator)
                    {
                        case '+':
                            double sum = firstNumber + secondNumber;
                            result = sum + sum * 0.1;
                            Console.WriteLine("The sum increased by 10% is: {0:F2}", result);
                            break;
                        case '-':
                            if (firstNumber > secondNumber)
                            {
                                result = firstNumber * firstNumber - secondNumber;
                            }
                            else
                            {
                                result = secondNumber * secondNumber - firstNumber;
                            }
                            Console.WriteLine("(MaxNumber * MaxNumber) - MinNumber is: {0:F2}", result);
                            break;
                        case '*':
                            result = firstNumber * Math.Sqrt(secondNumber);
                            Console.WriteLine("First Number * Sqrt(Second Number) is: {0:F2}", result);
                            break;
                        case '/':
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Division by 0 is forbidden!");
                            }
                            break;
                        // If the operator is not from the mentioned above, display an error.
                        default:
                            Console.WriteLine("Incorrect operation!");
                            break;
                    }
                }
            } while (answer != "no");

            // When the answer is "no" the program will exit.
            Environment.Exit(0);
        }
    }
}
