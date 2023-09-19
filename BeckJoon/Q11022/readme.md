### Question 11022
A + B 

- First input is the total number of the test cases.
- From the second case, type integer A and B

### Example
Input
```
5
1 1
2 3
3 4
9 8
5 2
```
Output
```
Case #1: 1 + 1 = 2
Case #2: 2 + 3 = 5
Case #3: 3 + 4 = 7
Case #4: 9 + 8 = 17
Case #5: 5 + 2 = 7
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
