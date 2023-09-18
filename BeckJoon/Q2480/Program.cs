var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var n1 = int.Parse(inputs.Split(" ")[0]);
    var n2 = int.Parse(inputs.Split(" ")[1]);
    var n3 = int.Parse(inputs.Split(" ")[2]);
    var total = 0;
    if (n1 == n2 && n2 == n3)
    {
        total = 10000 + n1 * 1000;
    }
    else if (n1 == n2)
    {
        total = 1000 + n1 * 100;
    }
    else if (n2 == n3)
    {
        total = 1000 + n2 * 100;
    }
    else if (n1 == n3)
    {
        total = 1000 + n1 * 100;
    }
    else
    {
        var maxNum = Math.Max(n1, n2);
        maxNum = Math.Max(maxNum, n3);
        total = maxNum * 100;
    }

    Console.WriteLine(total);
}