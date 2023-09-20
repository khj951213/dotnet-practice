### Question 10951
get input from user number 1 and number 2 and calculate <br />

Number 1 + Number 2 <br />

Finish at EOL <br/>

### Example
Input
```
1 1
2 3
3 4
9 8
5 2
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

var builder = new StringBuilder();

while (true)
{
    var inputs = Console.ReadLine();
    if (string.IsNullOrEmpty(inputs)) break;
    var inputStr = inputs.Split(" ");
    builder.AppendLine((int.Parse(inputStr[0]) + int.Parse(inputStr[1])).ToString());
}

Console.WriteLine(builder.ToString());
```
