var total = int.Parse(Console.ReadLine());
var cnt = 0;
var nList = Console.ReadLine().Split(" ").Select(e => int.Parse(e));
var findNum = int.Parse(Console.ReadLine());
foreach (var n in nList)
{
    if (findNum == n) cnt++;
}

Console.WriteLine(cnt);