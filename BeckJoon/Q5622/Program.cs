var dialDict = new Dictionary<string, object>()
{
    { "a", 2 },
    { "b", 2 },
    { "c", 2 },
    { "d", 3 },
    { "e", 3 },
    { "f", 3 },
    { "g", 4 },
    { "h", 4 },
    { "i", 4 },
    { "j", 5 },
    { "k", 5 },
    { "l", 5 },
    { "m", 6 },
    { "n", 6 },
    { "o", 6 },
    { "p", 7 },
    { "q", 7 },
    { "r", 7 },
    { "s", 7 },
    { "t", 8 },
    { "u", 8 },
    { "v", 8 },
    { "w", 9 },
    { "x", 9 },
    { "y", 9 },
    { "z", 9 },
};

var s = Console.ReadLine().ToLower();
var total = 0;
for (int i = 0; i< s.Length; i++)
{
    total += 2;
    total += (int)dialDict[s[i].ToString()]-1;
}
Console.WriteLine(total);