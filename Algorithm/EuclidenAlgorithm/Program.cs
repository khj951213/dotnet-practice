namespace EuclidenAlgorithm
{
    internal class Program
    {
        // Get the greatest common divisor
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                var tmp = b;
                b = a % b;
                a = tmp;
                
            }
            return a;
        }
        static void Main(string[] args)
        {
            var result = GCD(30, 18);
            Console.WriteLine(result);
        }
    }
}
