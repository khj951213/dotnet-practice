namespace Algorithm.Problems;

public class LC0001_TwoSum
{
    public static int[] Solve(int[] nums, int target)
    {
        Dictionary<int, int> seen = new();

        for (int i = 0 ; i < nums.Length; i++)
        {
            int needed = target - nums[i];
            if (seen.ContainsKey(needed))
            {
                return [seen[needed], i];
            }

            seen[nums[i]] = i;
        }

        return [];
    }
}