### Question 1000
A + B
### Example
Input
```
1 2
```
Output
```
3
```
### Answer
```c#
var inputs = Console.ReadLine();
if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    Console.WriteLine(a + b);
}
```
