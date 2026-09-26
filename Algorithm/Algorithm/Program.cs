using Algorithm.Problems;

namespace Algorithm;

public class Program
{
    public static void Main(string[] args)
    {
        LC0003_LongestSubstringWithoutRepeatingCharactersSolution();
    }

    public static void LC0002_AddTwoNumbersSolution()
    {
        LC0002_AddTwoNumbers.ListNode l1 = new(2, new(4, new(9)));

        LC0002_AddTwoNumbers.ListNode l2 = new(5, new(6, new(4, new(9))));

        var result = LC0002_AddTwoNumbers.Solve(l1, l2);

        LC0002_AddTwoNumbers.PrintList(result);
    }

    public static void LC0003_LongestSubstringWithoutRepeatingCharactersSolution()
    {
        Console.WriteLine(LC0003_LongestSubstringWithoutRepeatingCharacters.Solve("abcabcdd"));
        //Console.WriteLine(LC0003_LongestSubstringWithoutRepeatingCharacters.Solve("bbbbb"));
    }
}