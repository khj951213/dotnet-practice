### Question 10869
Arithmetic

### Example 1
Input
```
7 3
```
Output
```
10 (Addition)
4 (Subtraction)
21 (Multiplication)
2 (Division)
1 (Remainder)
```


### Code
```c#
var inputs = Console.ReadLine();
if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    Console.WriteLine(a * b);
}

```
