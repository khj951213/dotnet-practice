### Question 11382
A + B + C

### Example
Input
```
77 77 7777
```
Output
```
7931
```
### Code
```c#
var inputs = Console.ReadLine();
if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    var c = int.Parse(inputs.Split(" ")[2]);
    Console.WriteLine(a + b + c);
}
```
