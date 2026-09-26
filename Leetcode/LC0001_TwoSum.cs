Console.WriteLine(string.Join(",", Solve([2,7,11,15], 9))); // expected: [0,1]
Console.WriteLine(string.Join(",", Solve([3,2,4], 6))); // expected: [1,2]
Console.WriteLine(string.Join(",", Solve([3,3], 6))); // expected: [0,1]

static int[] Solve(int[] nums, int target)
{
    Dictionary<int, int> seen = [];

    for (int i = 0; i < nums.Length; i++)
    {
        int needed = target - nums[i];

        if (seen.TryGetValue(needed, out int index))
        {
            return [index, i];
        }

        // store index for the current value
        // for example [2,7,11,15]=>2->0, 7->1, 11->2, 15->3
        seen[nums[i]] = i;
    }

    return [];
}
