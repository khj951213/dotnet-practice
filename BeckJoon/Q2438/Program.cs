using System.Text;

var cnt = Console.ReadLine();

var builder = new StringBuilder();
var starBuilder = new StringBuilder(); 
for (int i = 0; i < int.Parse(cnt); i++)
{
    starBuilder.Append("*");
    builder.AppendLine(starBuilder.ToString());
}

Console.WriteLine(builder.ToString());