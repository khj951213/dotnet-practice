/**
    Leetcode 8. String to Integer (atoi)

    Implement the `myAtoi(string s) function, which converts a string to a 32-bit signed integer

    The algorithm for myAtoi(string s) is as follows:

    1. Whitespace: Ignore any leading whitespaces (" ")
    2. Signedness: Determine the sign by checking if the next character is '-' or '+' assuming positivity if neither present.
    3. Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached. If no digits were read, then the result is 0
    4. Rounding: If the integer is out of the 32-bit signed integer range [-2^31, 2^31 - 1] then round the integer to remain in the range.
                Specifically, integers less than -2^31 should be rounded to -2^31 and integers greater than 2^31-1 should be rounded to 2^31-1
    
    Example 1:
    Input s = "42"
    Output: 42

    Example 2:
    Input s = " -042"
    Output: -42
    
    Example 3:
    Input s = "1337c0d3"
    Output: 1337

    Example 4:
    Input s = "0-1"
    Output: 0
*/

Console.WriteLine(MyAtoi("42"));
Console.WriteLine(MyAtoi(" -042"));
Console.WriteLine(MyAtoi("1337c0d3"));
Console.WriteLine(MyAtoi("0-1"));
Console.WriteLine(MyAtoi("words and 987"));

int MyAtoi(string s)
{
    int i = 0;

    // Skip leading spaces only.
    while (i < s.Length && s[i] == ' ') i++;

    int sign = 1;
    if (i < s.Length && (s[i] == '-' || s[i] == '+'))
    {
        if (s[i] == '-')
            sign = -1;

        i++;
    }

    long result = 0;

    // char has a numeric Unicode value, so characters can be compared with '<' and '>'
    // the digit characters are in order [0, 1, 2, 3, 4, ...]
    // so in this condition asks whether s[i] falls within that range.
    while (i < s.Length && s[i] >= '0' && s[i] <= '9')
    {
        int digit = s[i] - '0';
        result = result * 10 + digit;

        if (sign == 1 && result > int.MaxValue)
            return int.MaxValue;

        if (sign == -1 && result > 2147483648L)
            return int.MinValue;

        i++;
    }

    return (int)(sign * result);
}

int MyAtoi_Improved(string s)
{
    int i = 0;

    while (i < s.Length && s[i] == ' ')
        i++;

    bool negative = false;

    if (i < s.Length && (s[i] == '+' || s[i] == '-'))
    {
        negative = s[i] == '-';
        i++;
    }

    // Keep the result negative so int.MinValue can be represented.
    int result = 0;
    int limit = negative ? int.MinValue : -int.MaxValue;

    while (i < s.Length && s[i] >= '0' && s[i] <= '9')
    {
        int digit = s[i] - '0';

        // Check before computing result * 10 - digit.
        if (result < limit / 10 || (result == limit / 10 && digit > -(limit % 10)))
        {
            return negative ? int.MinValue : int.MaxValue;
        }

        result = result * 10 - digit;
        i++;
    }

    return negative ? result : -result;
}