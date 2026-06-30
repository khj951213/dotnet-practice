
// JumpSearch
using System.Diagnostics;

namespace JumpSearch
{
    internal class Program
    {
        /* JumpSearch
         * Time complexity:(O(sqrt{n})).
         * Worst case: (O(sqrt{n})).
         * Use case: this is helpful on older systems or physical media where moving the "read head" backward is physically slower or more "expensive" than moving forward.
         */
        public static int JumpSearch(int[] arr, int target)
        {
            int n = arr.Length;

            // 1. Determine the optimal step size (Square Root of n)
            int step = (int)Math.Floor(Math.Sqrt(n));

            // 2. Finding the block where element is present (if it is)
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < target)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));

                // If we've reached the end of the array without finding a block
                if (prev >= n)
                    return -1;
            }

            // 3. Perform a Linear Search within the identified block
            while (arr[prev] < target)
            {
                prev++;

                // If we reached the next block or end of array, element is not present
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // 4. Check if the element at 'prev' is the target
            if (arr[prev] == target)
                return prev;

            return -1;
        }
        static void Main()
        {
            int[] data = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
            int target = 55;

            var timer = new Stopwatch();
            timer.Start();

            int index = JumpSearch(data, target);

            Console.WriteLine($"Excuted: {timer.Elapsed.TotalMilliseconds}ms");

            if (index != -1)
                Console.WriteLine($"Element {target} found at index: {index}");
            else
                Console.WriteLine($"Element {target} not found.");
        }
    }
}
