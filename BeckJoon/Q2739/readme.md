### Question 2739
Multiplication table

### Example
Input
```
9
```
Output
```
9
18
27
36
45
54
63
72
81
```
### Code
```c#
var input = Console.ReadLine();
if (!string.IsNullOrEmpty(input))
{
    var num = int.Parse(input);
    for (var i = 1; i < 10; i++)
    {
        Console.WriteLine(num * i);
    }
}
```
