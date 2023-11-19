### Question 10988
Reverse string. If reverse string equals the original string then return 1, else return 0.

### Example 1
Input
```
level
```
Output
```
1
```

### Example 2
Input 
```
apple
```
Output
```
0
```
### Code
```c#
var input = Console.ReadLine();
var reverse = new string(input.Reverse().ToArray());

if (!string.IsNullOrEmpty(input) && input.Equals(reverse))
    Console.WriteLine(1);
else
    Console.WriteLine(0);
```
