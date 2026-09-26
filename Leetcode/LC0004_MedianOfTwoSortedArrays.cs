
int[] nums1 = [1,3];
int[] nums2 = [2];
double simpleResult = SimpleSolution(nums1, nums2);
double optimisedResult = OptimisedSolution(nums1, nums2);

Console.WriteLine($"Simple result: {simpleResult}");
Console.WriteLine($"optimised result: {optimisedResult}");

static double SimpleSolution(int[] nums1, int[] nums2)
{
    int[] merged = nums1.Concat(nums2).OrderBy(x => x).ToArray();
    int n = merged.Length;

    if (n % 2 == 1) return merged[n / 2];
    return merged[n / 2 - 1] + merged[n / 2] / 2.0;
}

static double OptimisedSolution(int[] nums1, int[] nums2)
{
    if (nums1.Length > nums2.Length) 
        return OptimisedSolution(nums2, nums1);

    int m = nums1.Length;
    int n = nums2.Length;

    int low = 0;
    int high = m;

    //
    while (low <= high)
    {
        int partition1 = (low + high) / 2;
        int partition2 = (m + n + 1) / 2 - partition1;

        int left1 = partition1 == 0 ? int.MinValue : nums1[partition1 - 1];
        int right1 = partition1 == m ? int.MaxValue : nums1[partition1];

        int left2 = partition2 == 0 ? int.MinValue : nums2[partition2 - 1];
        int right2 = partition2 == n ? int.MaxValue : nums2[partition2];
        
        if (left1 <= right2 && left2 <= right1)
        {
            // Odd total length
            if ((m + n) % 2 == 1)
            {
                return Math.Max(left1, left2);
            }

            // Even total length
            return (
                Math.Max(left1, left2) +
                Math.Min(right1, right2)
            ) / 2.0;
        }

        if (left1 > right2)
        {
            high = partition1 - 1;
        }
        else
        {
            low = partition1 + 1;
        }
    }

    throw new ArgumentException("Arrays must be sorted.");
}