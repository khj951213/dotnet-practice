namespace SieveOfEratosthenes
{
    internal class Program
    {
        static List<int> FindAllPrimes(int limit)
        {
            var isPrime = new bool[limit + 1];

            for (int i = 2; i <= limit; i++)
            {
                // initially, all numbers from 2 to limit are assumed prime to true
                isPrime[i] = true; 
            }

            for (int i = 2; i * i <= limit; i++)
            {
                if (isPrime[i])
                {
                    // Remove multiples of i 
                    // e.g. 2 -> 4, 6, 8, 10, ...
                    // e.g. 3 -> 3, 9, 12, 15, ...
                    // We start from i squared because all smaller multiples should have already been removed.
                    for (int j = i * i; j <= limit; j += i)
                    {
                        // for each prime number i, we mark its multiples as non-prime 
                        isPrime[j] = false;
                    }
                }
            }

            List<int> primes = [];

            for (int i = 2; i <= limit; i++)
            {
                if (isPrime[i]) primes.Add(i);
            }

            return primes;
        }

        static void Main(string[] args)
        {
            var primes = FindAllPrimes(20);
            primes.ForEach(prime => Console.Write($"{prime}, "));
        }
    }
}
