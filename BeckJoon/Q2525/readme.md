### Question 2525
Calculate oven timer.

### Example 1
Input
```
14 30
20
```
Output
```
14 50
```

### Example 2
Input
```
17 40
80
```
Output
```
19 0
```

### Example 3
Input
```
23 48
25
```
Output
```
0 13
```


### Code
```c#
var time = Console.ReadLine();
var add = Console.ReadLine();

if (!string.IsNullOrEmpty(time) && !string.IsNullOrEmpty(add))
{
    var hour = int.Parse(time.Split(" ")[0]);
    var minute = int.Parse(time.Split(" ")[1]);

    minute += int.Parse(add);

    while (minute > 59)
    {
        minute -= 60;
        hour += 1;
    }

    while (hour > 23)
    {
        hour -= 24;
    }

    Console.WriteLine(hour + " " + minute);

}
```
