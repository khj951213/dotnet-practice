### Question 11718
Print whatever is given.

### Example 
Input
```
Hello
Baekjoon
Online Judge
```
Output
```
Hello
Baekjoon
Online Judge
``` 



### Code
```c#
var sList = new List<string>();

while (true)
{
    var s = Console.ReadLine();
    if (!string.IsNullOrEmpty(s))
    {
        sList.Add(s);
    }
    else
    {
        break;
    }
}

foreach (var s in sList)
{
    Console.WriteLine(s);
}
```
