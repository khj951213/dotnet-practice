using System.Text;

var builder = new StringBuilder();

while (true)
{
    var inputs = Console.ReadLine();
    if (string.IsNullOrEmpty(inputs)) break;
    var inputStr = inputs.Split(" ");
    builder.AppendLine((int.Parse(inputStr[0]) + int.Parse(inputStr[1])).ToString());
}

Console.WriteLine(builder.ToString());