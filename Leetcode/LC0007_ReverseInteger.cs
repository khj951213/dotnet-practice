Console.WriteLine(Solution(-2147483412));

static int Solution(int x)
{
    int result = 0;

    while (x != 0)
    {
        int digit = x % 10;
        x /= 10;

        if (result > int.MaxValue / 10 || 
            (result == int.MaxValue / 10 && digit > 7) ||
            result < int.MinValue / 10 ||
            (result == int.MinValue / 10 && digit < -8))
        {
            return 0;
        }

        result = result * 10 + digit;
    }

    return result;
}