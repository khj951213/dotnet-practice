### Question 10950
get input from user number 1 and number 2 and calculate

Number 1 + Number 2

### Example
Input
```
1 2
```
Output
```
3
```
### Code
```c#
var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var num1 = int.Parse(inputs.Split(" ")[0]);
    var num2 = int.Parse(inputs.Split(" ")[1]);
    Console.WriteLine(num1 + num2);
}
```
