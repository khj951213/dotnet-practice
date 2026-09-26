using System.Text.Json;

namespace Algorithm.Problems;

public class LC0003_LongestSubstringWithoutRepeatingCharacters
{
    public static int Solve(string s)
    {
        HashSet<char> seen = new();

        int left = 0;
        int maxLength = 0;
        Console.Write($"left index: {left} ");
        for (int right = 0; right < s.Length; right++)
        {
            Console.WriteLine($"right - idx:{right} char: {s[right]}");
            // if contains move left window and remove left window character
            // remove while it sees it self
            while(seen.Contains(s[right])) 
            {
                Console.WriteLine("Seen includes the right removing process");
                Console.WriteLine($"Left index has been seen prev left: {left} -> {left+1}");
                Console.Write($"Seen change: {JsonSerializer.Serialize(seen)}");
                seen.Remove(s[left]);
                Console.WriteLine($" -> {JsonSerializer.Serialize(seen)}");
                left ++;
            }
            Console.Write($"Seen added {s[right]}: Current seen: {JsonSerializer.Serialize(seen)}");
            seen.Add(s[right]);
            Console.WriteLine($" -> after added seen: {JsonSerializer.Serialize(seen)}");
            
            int length = right - left + 1;
            maxLength = Math.Max(maxLength, length);
            Console.WriteLine($"length of this loop: {length}. Current most maximum: {maxLength}");
            Console.WriteLine("------------------------");
        }

        return maxLength;
    }
}