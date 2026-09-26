// LC0005 Longest Palindromic Substring
// Time complexity: O(n^2)
// Space: O(1)
string s = "abaXYZracecar";
Console.WriteLine(Solution(s));

static string Solution(string s)
{
    if (string.IsNullOrEmpty(s)) return string.Empty;

    int start = 0;
    int maxLength = 1;

    for (int i = 0; i < s.Length; i++)
    {
        // Odd length palindrome
        Expand(s, i, i, ref start, ref maxLength);
            
        // Even length palindrome
        Expand(s, i, i + 1, ref start, ref maxLength);
    }

    return s.Substring(start, maxLength);
}

static void Expand(string s, int left, int right, ref int start, ref int maxLength)
{
    // if left and right is within the text length
    // and if the left text and the right text is the same
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        int length = right - left + 1;
        // it keeps the first longest palindrome because the second one is equal in length, not greater.
        if (length > maxLength)
        {
            start = left;
            maxLength = length;
        }

        left--;
        right++;
    }
}
