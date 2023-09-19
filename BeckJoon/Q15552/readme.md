### Question 15552
Find the fasteset way to input

First input is the number of test cases.
From the second input, two integer A and B will be given. (0 < A, B <= 1000)

### Example
Input
```
5
1 1
12 34
5 500
40 60
1000 1000
```
Output
```
2
46
505
100
2000
```
### Code
```c#
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
```
