/// Palindrome Number
/// Given an integer x, return true if x is a panlindrome and false otherwise
/// 
/// Example 1:
/// Input x = 121
/// output: true
/// Explanation: 121 reads as 121 from left to right and from right to left
/// 
/// Example 2:
/// Input x = -121
/// Output false
/// Explanation: from left to right it reads -121 from right to left it becomes 121- therefore,  it is not a palindrome.
/// 
/// 

Console.WriteLine(IsPalindrome(121));
Console.WriteLine(IsPalindrome(1221));
Console.WriteLine(IsPalindrome(1211));
Console.WriteLine(IsPalindrome(-121));
Console.WriteLine(IsPalindrome(10));
bool IsPalindrome(int x) 
{
    if (x < 0) return false;
    
    var t = x.ToString();
    var left = (t.Length-1) / 2;
    var right = t.Length % 2 == 0 ? left+1 : left;

    while (left >= 0 && right < t.Length)
    {
        if (t[left] == t[right])
        {
            left--;
            right++;
        }
        else
        {
            return false;
        }
    }

    return true;
}