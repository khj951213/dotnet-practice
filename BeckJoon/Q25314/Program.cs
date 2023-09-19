using System.Text;

var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    var stringBuilder = new StringBuilder();
    var n = int.Parse(input);
    for (int i = 0; i < n/4; i++)
    {
        stringBuilder.Append("long ");
    }
    stringBuilder.Append("int");
    Console.WriteLine(stringBuilder.ToString());
}

