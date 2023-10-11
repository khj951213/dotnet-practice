### Question 11720
Add all the numers sequentially.

### Example 1
Input
```
1
1
```
Output
```
1
``` 

### Example 2
Input
```
5
54321
```
Output
```
15
```

### Example 3
Input
```
25
7000000000000000000000000
```
Output
```
7
```

### Code
```c#
var n = int.Parse(Console.ReadLine());
var nList = Console.ReadLine();
var total = 0;
for (int i = 0; i < n; i++)
{
    total += int.Parse(nList[i].ToString());
}

Console.WriteLine(total);
```
