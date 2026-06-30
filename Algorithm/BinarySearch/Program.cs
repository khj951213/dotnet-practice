namespace BinarySearch
{
    internal class Program
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                // Calculate the middle index
                // (low + high) / 2 can cause overflow for very large arrays, 
                // so this version is safer:
                int mid = low + (high - low) / 2;

                // 1. Check if the target is exactly at the middle
                if (arr[mid] == target)
                    return mid;

                // 2. If target is greater, ignore the left half
                if (arr[mid] < target)
                    low = mid + 1;

                // 3. If target is smaller, ignore the right half
                else
                    high = mid - 1;
            }

            // Target not found
            return -1;
        }

        static void Main()
        {
            int[] data = { 10, 22, 35, 40, 45, 50, 60, 70, 82, 90 };
            int target = 70;

            int result = BinarySearch(data, target);

            if (result != -1)
                Console.WriteLine($"Element found at index: {result}");
            else
                Console.WriteLine("Element not found.");
        }
    }
}
