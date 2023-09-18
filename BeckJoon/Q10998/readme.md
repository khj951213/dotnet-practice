### Question 10998
A x B

### Example 1
Input
```
1 2
```
Output
```
2
```

### Example 2
Input 
```
3 4
```
Output
```
12
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
