var input = Console.ReadLine();
if (!string.IsNullOrEmpty(input))
{
    var num = int.Parse(input);
    for (var i = 1; i < 10; i++)
    {
        Console.WriteLine(num * i);
    }
}