### Question 2480
Calculate the numbers on three dice.

1. If three dice have the same number when rolled, then 10000 won + (number) x 1000 won*
2. If two dice have the same number when rolled, then 1000 won + (number) x 100 won
3. If there is no same number when rolled, then (the highest number) x 100 won.


*won: Korean currency.
### Example 1
Input
```
3 3 6
```
Output
```
1300 
```

### Example 2
Input
```
2 2 2
```
Output
```
12000
```

### Example 3
Input
```
6 2 5
```
Output
```
600
```


### Code
```c#
var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var n1 = int.Parse(inputs.Split(" ")[0]);
    var n2 = int.Parse(inputs.Split(" ")[1]);
    var n3 = int.Parse(inputs.Split(" ")[2]);
    var total = 0;
    if (n1 == n2 && n2 == n3)
    {
        total = 10000 + n1 * 1000;
    }
    else if (n1 == n2)
    {
        total = 1000 + n1 * 100;
    }
    else if (n2 == n3)
    {
        total = 1000 + n2 * 100;
    }
    else if (n1 == n3)
    {
        total = 1000 + n1 * 100;
    }
    else
    {
        var maxNum = Math.Max(n1, n2);
        maxNum = Math.Max(maxNum, n3);
        total = maxNum * 100;
    }

    Console.WriteLine(total);
}
```
