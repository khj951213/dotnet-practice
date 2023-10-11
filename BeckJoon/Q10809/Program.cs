var s = Console.ReadLine();

var charList = new List<char>();
for (int i = 97; i < 123; i++)
{
    charList.Add((char)i);
}

var resList = new List<int>();

foreach (var c in charList)
{
    if (s.Contains(c))
    {
        resList.Add(s.IndexOf(c));
    }
    else
    {
        resList.Add(-1);
    }
}

foreach (var r in resList)
{
    Console.Write(r + " ");
}