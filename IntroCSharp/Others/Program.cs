using System;
using System.Collections;
using System.Linq;

namespace Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(TrailingZeroes(12));

            int num, baseNum;
            Console.Write("Enter a decimal number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(num + " converts to ");
            MulBase(num, baseNum);
            Console.WriteLine(" Base " + baseNum);
            Console.Read();
        }
        static int TrailingZeroes(int n)
        {
            int cnt = 0;

            while (n > 0)
            {
                n /= 5;
                cnt += n;
            }

            return cnt;
        }

        static void MulBase(int n, int b)
        {
            Stack Digits = new Stack();
            do
            {
                Digits.Push(n % b);
                n /= b;
            } while (n != 0);
            while (Digits.Count > 0)
                Console.Write(Digits.Pop());
        }

        static int maxConsecutiveOnes(int x)
        {
            // Initialize result
            int count = 0;

            // Count the number of iterations to
            // reach x = 0.
            while (x != 0)
            {
                // This operation reduces length
                // of every sequence of 1s by one
                x &= (x << 1);

                count++;
            }
            return count;
        }

        // Function to return the count of
        // maximum consecutive 1s in the
        // binary represntation among all
        // the elements of arr[]
        static int maxOnes(int[] arr, int n)
        {
            // To store the answer
            int ans = 0;

            // For every element of the array
            for (int i = 0; i < n; i++)
            {

                // Count of maximum consecutive 1s in
                // the binary representation of
                // the current element
                int currMax = maxConsecutiveOnes(arr[i]);

                // Update the maximum count so far
                ans = Math.Max(ans, currMax);
            }
            return ans;
        }

        //Print_Number_From_1_To_100_Without_Loop
        private static void Print_Number_From_1_To_100_Without_Loop()
        {
            //Print_Number_From_1_To_100_Without_Loop(1);
            //Console.WriteLine("----------");
            //int start = 5;
            //int end = 100;
            //Print_Number_From_1_To_100_Without_Loop(start, end);

            Print_Number_From_1_To_100_Without_Loop_Linq();
        }

        private static void Print_Number_From_1_To_100_Without_Loop_Linq()
        {
            var items = Enumerable.Range(1, 100)
                                .Select(i => new StringBuilder().AppendFormat($"{i}"));

            Console.WriteLine(string.Join("\n", items));
        }


        //Print_Number_From_1_To_100_Without_Loop - Recursion
        private static void Print_Number_From_1_To_100_Without_Loop(int start)
        {
            if (start <= 100)
            {
                Console.WriteLine(start);
                start++;
                Print_Number_From_1_To_100_Without_Loop(start);
            }
        }
        private static void Print_Number_From_1_To_100_Without_Loop(int start, int end)
        {
            if (start <= end)
            {
                Console.WriteLine(start);
                start++;
                Print_Number_From_1_To_100_Without_Loop(start, end);
            }
        }
    }
}
