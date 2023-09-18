var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    if (a > b)
    {
        Console.WriteLine(">");
    }
    else if (a < b)
    {
        Console.WriteLine("<");
    }
    else
    {
        Console.WriteLine("==");
    }
}