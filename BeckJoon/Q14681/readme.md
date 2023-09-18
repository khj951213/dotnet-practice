### Question 14681
Find quadrant

### Example 1
Input
```
12 5
```
Output
```
1
```

### Example 2
Input
```
9 -13
```
Output
```
4
```

### Code
```c#
var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var quadrant = 1;
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    if (a > 0 && b > 0) quadrant = 1;
    else if (a < 0 && b > 0) quadrant = 2;
    else if (a < 0 && b > 0) quadrant = 3;
    else quadrant = 4;
    Console.WriteLine(quadrant);
}
```
