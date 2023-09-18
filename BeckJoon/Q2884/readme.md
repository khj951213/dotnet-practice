### Question 2884
Set alarm before 45 minutes.

### Example 1
Input
```
10 10
```
Output
```
9 25
```

### Example 2
Input
```
0 30
```
Output
```
23 45
```

### Example 3
Input
```
23 40
```
Output
```
22  55
```


### Code
```c#
var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var hour = int.Parse(inputs.Split(" ")[0]);
    var minute = int.Parse(inputs.Split(" ")[1]);

    minute -= 45;

    if (minute < 0)
    {
        hour -= 1;
        minute += 60;
    }

    if (hour < 0)
    {
        hour = 23;
    }

    Console.WriteLine(hour + " " + minute);
}
```
