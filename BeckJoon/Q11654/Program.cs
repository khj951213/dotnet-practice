using System.Text;

var s = Console.ReadLine();
var sByte = Encoding.ASCII.GetBytes(s);
foreach (var b in sByte)
{
    Console.WriteLine(b);
}