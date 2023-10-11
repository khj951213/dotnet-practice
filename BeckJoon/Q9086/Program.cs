var n = int.Parse(Console.ReadLine());
var resArr = new List<string>();
for (int i = 0; i < n; i++)
{
    var s = Console.ReadLine();
    resArr.Add($"{s.First()}{s.Last()}");
}
foreach(var res in resArr)
{
    Console.WriteLine(res);
}