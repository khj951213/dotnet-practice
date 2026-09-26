
var result = Solve("abcabcbb");
Console.Write(result);

static int Solve(string s)
{
    HashSet<char> seen = new();

    int left = 0;
    int maxLength = 0;

    for (int right = 0; right < s.Length; right++)
    {
        while (seen.Contains(s[right]))
        {
            seen.Remove(s[left]);
            left++;
        }

        seen.Add(s[right]);

        int length = right - left + 1;
        maxLength = Math.Max(maxLength, length);
    }

    return maxLength;
}