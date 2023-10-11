### Question 11654
Find the ASCII code of the given string.

### Example 1
Input
```
A
```
Output
```
65
``` 

### Example 2
Input
```
C
```
Output
```
67
```

### Example 3
Input
```
0
```
Output
```
48
```

### Code
```c#
using System.Text;

var s = Console.ReadLine();
var sByte = Encoding.ASCII.GetBytes(s);
foreach (var b in sByte)
{
    Console.WriteLine(b);
}
```
