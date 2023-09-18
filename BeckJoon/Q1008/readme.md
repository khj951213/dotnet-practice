### Question 1008
A / B

### Example 1
Input
```
1 3
```
Output
```
0.33333333333333333333333333333333
```

### Example 2
Input 
```
4 5
```
Output
```
0.8
```

### Code
```c#
var inputs = Console.ReadLine();
if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    Console.WriteLine(a / (double)b);
}
```
