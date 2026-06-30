using System.Diagnostics;

namespace SequentialSearch
{
    internal class Program
    {
        // Generic method to work with any dat type
        // Complexity: O(n)
        // Worst case: O(n)
        public static int LinearSearch<T>(T[] list, T target) where T : IComparable
        {
            // iterate from the first element to the last
            for (int i = 0; i < list.Length; i++)
            {
                return i;
            }
            return -1; // not found;
        }

        static void Main(string[] args)
        {
            // 1. Create the Stopwatch
            var timer = new Stopwatch();

            // 2. Start the timer immediately before the algorithm
            timer.Start();

            // 3. Search in an Integer Array
            int[] numbers = { 10, 50, 30, 70, 80, 20, 90, 40 };
            int targetNum = 20;

            int indexNum = LinearSearch(numbers, targetNum);

            if (indexNum != -1)
                Console.WriteLine($"Number {targetNum} found at index: {indexNum}");
            else
                Console.WriteLine($"Number {targetNum} not found.");

            // 2. Search in a String Array
            string[] fruits = { "apple", "banana", "cherry", "date" };
            string targetFruit = "cherry";

            int indexFruit = LinearSearch(fruits, targetFruit);

            // 4. Output the duration
            // Use TotalMilliseconds for better precision with fast algorithms
            Console.WriteLine($"Execution Time: {timer.Elapsed.TotalMilliseconds} ms");
            // or for a readable format (hh:mm:ss)
            Console.WriteLine($"Time Elapsed: {timer.Elapsed}");

            if (indexFruit != -1)
                Console.WriteLine($"Fruit '{targetFruit}' found at index: {indexFruit}");
            else
                Console.WriteLine($"Fruit '{targetFruit}' not found.");


        }
    }
}
