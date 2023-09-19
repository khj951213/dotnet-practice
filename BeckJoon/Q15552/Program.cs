using System.Text;

var cnt = Console.ReadLine();

var builder = new StringBuilder();

if (!string.IsNullOrEmpty(cnt))
{
    for (var i = 0; i < int.Parse(cnt); i++)
    {
        var strArray = Console.ReadLine()?.Split(' ');
        if (strArray != null)
            builder.AppendLine((int.Parse(strArray[0]) + int.Parse(strArray[1])).ToString());
    }

    Console.WriteLine(builder.ToString());
}