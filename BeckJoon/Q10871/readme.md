### Question 10871
Find the numbers from N that are lower than the given number X.

- First input: N (total number of numbers), X (given number)
- From second input: X1, X2 .... XN

### Example
Input
```
10 5
1 10 4 9 2 3 8 5 7 6
```
Output
```
1 4 2 3
```
### Code
```c#
using System.Text;

var uselessInput = Console.ReadLine().Split(" ").Select(e => int.Parse(e)).ToList();
var num = uselessInput[1];
var inputs = Console.ReadLine().Split(" ").Select(e => int.Parse(e)).ToList();
var nList = new List<int>();

foreach (var input in inputs)
{
    if (input < num) nList.Add(input);
}

var builder = new StringBuilder();
foreach (var n in nList)
{
    builder.Append(n + " ");
}

Console.WriteLine(builder.ToString());
```
