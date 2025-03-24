namespace Q2738
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);

            var nArr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                var input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    nArr[i, j] = input2[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                var input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    nArr[i, j] += input2[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(nArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
