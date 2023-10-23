var cp = new List<int>() { 1, 1, 2, 2, 2, 8 };
var input = Console.ReadLine();
var nList = input.Split(" ").Select(int.Parse).ToList();
for (int i = 0; i < nList.Count; i++)
{
    cp[i] = cp[i] - nList[i];
}

foreach (var item in cp)
{
    Console.Write(item + " ");
}