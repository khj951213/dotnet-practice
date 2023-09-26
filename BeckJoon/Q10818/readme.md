### Question 10818
Find min and max

### Example 
Input
```
5
20 10 35 30 7
```
Output
```
7 35
```


### Code
```c#
var n = Console.ReadLine();
var numStr = Console.ReadLine();

if (numStr != null) {
    var nums = numStr.Split(" ").Select(e => int.Parse(e)).ToList();
    Console.WriteLine(nums.Min());
    Console.WriteLine(nums.Max());
}
```
