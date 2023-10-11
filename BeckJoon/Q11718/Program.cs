var sList = new List<string>();

while (true)
{
    var s = Console.ReadLine();
    if (!string.IsNullOrEmpty(s))
    {
        sList.Add(s);
    }
    else
    {
        break;
    }
}

foreach (var s in sList)
{
    Console.WriteLine(s);
}