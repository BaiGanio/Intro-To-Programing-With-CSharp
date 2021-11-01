using System;

namespace GroupingDigits
{
    internal class Program
    {
        static void Main()
        {
            /* Case 0 */
            //int[] arr = { 1, 1, 1, 1, 0, 0, 0, 0 };

            /* Case 1 */
            //int[] arr = { 1, 1, 1, 1, 0, 1, 0, 1 };

            /* Case 3 */
            int[] arr = { 1, 0, 1, 0, 0, 0, 0, 1 };

            /* Test Case */
            //int[] arr = { 88, 46, 90, 11, 100 };

            Console.Write("Original array: ");
            Print(arr);

            int temp;
            int counter = 0;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;

                        counter++;

                        Console.WriteLine($"Move: {counter}");
                        Print(arr);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total moves: {counter}");
        }

        private static void Print(int[] arr)
        {
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.WriteLine();
            Console.WriteLine("-------");
        }
    }
}
