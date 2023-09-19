### Question 10952
Sum A and B until you reach A = 0, B = 0

### Example
Input
```
1 1
2 3
3 4
9 8
5 2
0 0
```
Output
```
2
5
7
17
7
```
### Code
```c#
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
```
