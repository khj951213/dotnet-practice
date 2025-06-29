namespace ExpoBySquare
{
    internal class Program
    {
        // Caculate a^b using Exponentitation by Squaring
        static long Power (long baseValue, long exponent)
        {
            long result = 1;
            while (exponent > 0)
            {
                if ((exponent & 1) == 1) // if exponent is odd
                {
                    result *= baseValue;
                }

                baseValue *= baseValue;

                // bitwiste operation >>: Shift all bits of x one position to the right, which is equivalent to dividing x by 2 and discarding any remainders.
                // e.g. x = 8 (1000) -> x >> 1 (0100) => 4
                exponent >>= 1; // Divide exponent by 2
            }

            return result;
        }

        static void Main(string[] args)
        {
            long a = 2, b = 10;
            Console.WriteLine($"{a}^{b} = {Power(a, b)}");
        }
    }
}
