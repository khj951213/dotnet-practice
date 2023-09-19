using System.Text;

var cnt = int.Parse(Console.ReadLine());

var builder = new StringBuilder();

for (int i = 0; i < cnt; i++)
{
    var strArray = Console.ReadLine().Split(" ");
    builder.AppendLine($"Case #:{i+1} " + (int.Parse(strArray[0]) + int.Parse(strArray[1])).ToString());
}

Console.WriteLine(builder.ToString());