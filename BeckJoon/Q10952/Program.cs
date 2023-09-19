using System.Text;

int a, b;
a = 1;
b = 1;

var builder = new StringBuilder();
while (true)
{
    var strArr = Console.ReadLine().Split(" ");
    a = int.Parse(strArr[0]);
    b = int.Parse(strArr[1]);
    if (a == 0 && b == 0) break;
    builder.AppendLine((a + b).ToString());
}

Console.WriteLine(builder.ToString());