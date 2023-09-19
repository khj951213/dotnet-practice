### Question 11021
Type A and B and calculate A + B

- First input is the number of the test cases.
- From the second input, enter integer A and B.

### Example 
Input
```
5
1 1
2 3
3 4
9 8
5 2
```
Output
```
Case #1: 2
Case #2: 5
Case #3: 7
Case #4: 17
Case #5: 7
```

### Code
```c#
using System.Text;

var cnt = int.Parse(Console.ReadLine());

var builder = new StringBuilder();

for (int i = 0; i < cnt; i++)
{
    var strArray = Console.ReadLine().Split(" ");
    builder.AppendLine($"Case #:{i+1} " + (int.Parse(strArray[0]) + int.Parse(strArray[1])).ToString());
}

Console.WriteLine(builder.ToString());
```
