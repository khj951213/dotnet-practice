using System.Text;

var uselessInput = Console.ReadLine().Split(" ").Select(e => int.Parse(e)).ToList();
var num = uselessInput[1];
var inputs = Console.ReadLine().Split(" ").Select(e => int.Parse(e)).ToList();
var nList = new List<int>();

foreach (var input in inputs)
{
    if (input < num) nList.Add(input);
}

var builder = new StringBuilder();
foreach (var n in nList)
{
    builder.Append(n + " ");
}

Console.WriteLine(builder.ToString());