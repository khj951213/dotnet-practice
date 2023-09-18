var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    var total = 0;
    var num = int.Parse(input); 

    for (int i = 1; i <= num; i++)
    {
        total += i;
    }

    Console.WriteLine(total);
}