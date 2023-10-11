var given = Console.ReadLine();

var sList = given.Trim().Split(" ").ToList();
var max = 0;
foreach (var s in sList)
{
    var reversed = s.ToCharArray().Reverse();
    var n = int.Parse(new string(reversed.ToArray()));
    if (max < n)
    {
        max = n;
    }
}

Console.WriteLine(max);