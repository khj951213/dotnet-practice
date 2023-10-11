var n = int.Parse(Console.ReadLine());
var nList = Console.ReadLine();
var total = 0;
for (int i = 0; i < n; i++)
{
    total += int.Parse(nList[i].ToString());
}

Console.WriteLine(total);