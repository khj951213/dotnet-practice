### Question 8393
Given n, add all the numbers from 1 to n

### Example
Input
```
3
```
Output
```
6
```


### Code
```c#
var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    var total = 0;
    var num = int.Parse(input); 

    for (int i = 1; i <= num; i++)
    {
        total += i;
    }

    Console.WriteLine(total);
}
```
