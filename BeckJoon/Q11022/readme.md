### Question 11022
A + B 

- First input is the total number of the test cases.
- From the second case, type integer A and B

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
Case #1: 1 + 1 = 2
Case #2: 2 + 3 = 5
Case #3: 3 + 4 = 7
Case #4: 9 + 8 = 17
Case #5: 5 + 2 = 7
```

### Code
```c#
using System.Text;

var cnt = int.Parse(Console.ReadLine());

var builder = new StringBuilder();

for (int i = 0; i < cnt; i++)
{
    var strArray = Console.ReadLine().Split(" ");
    builder.AppendLine($"Case #{i + 1}: {strArray[0]} + {strArray[1]} = " + (int.Parse(strArray[0]) + int.Parse(strArray[1])).ToString());
}

Console.WriteLine(builder.ToString());
```
