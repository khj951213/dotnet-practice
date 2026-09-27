/*
 Given a non-negative integer `x` return the square root of `x` rounded down to the nearest integer.
 The returned integer should be non-negative as well.
 You must not use any built-in exponent function or operator
*/

/*
    Example 1:
    Input: x = 4
    Output: 2
    Explanation: The square root of 4 is 2, so we return 2
*/

/*
    Example 2:
    Input: x = 8
    Output: 2
    Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer,
    2 is returned 
*/

/*
    Constraints: 0 <= x <= 2^31 - 1
*/

static int MySqrt(int x)
{
    if (x < 2) return x;

    var left = 1;
    var right = x / 2;
    var answer = 0;

    while (left <= right)
    {
        var mid = left + (right - left) / 2;
        var square = (long)mid * mid;

        if (square == x)
        {
            return mid;
        }
        else if (square < x)
        {
            answer = mid;
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return answer;
}