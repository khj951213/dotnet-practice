### Question 1130
Compare A and B

### Example 1
Input
```
1 2
```
Output
```
<
```

### Example 2
Input
```
3 1 
```
Output
```
>
```

### Example 3
Input
```
4 4
```
Output
```
==
```
### Code
```c#
var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    if (a > b)
    {
        Console.WriteLine(">");
    }
    else if (a < b)
    {
        Console.WriteLine("<");
    }
    else
    {
        Console.WriteLine("==");
    }
}
```
