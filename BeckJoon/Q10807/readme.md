### Question 10807
Count how many numbers

### Example 
Input
```
11
1 4 1 2 4 2 4 2 3 4 4
2
```
Output
```
3
```


### Code
```c#
var total = int.Parse(Console.ReadLine());
var cnt = 0;
var nList = Console.ReadLine().Split(" ").Select(e => int.Parse(e));
var findNum = int.Parse(Console.ReadLine());
foreach (var n in nList)
{
    if (findNum == n) cnt++;
}

Console.WriteLine(cnt);
```
