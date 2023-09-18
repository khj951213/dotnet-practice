### Question 10430
Calculate remainder

Is (A+B)%C same as ((A%C) + (B%C))%C?
Is (A×B)%C same as ((A%C) × (B%C))%C?

Let's find out!

### Example
Input: Type A, B, C respectively
```
5 8 4
```
Output
- First line: (A+B)%C
- Second line: ((A%C) + (B%C))%C
- Third line: (A×B)%C
- Forth line: ((A%C) × (B%C))%C
```
1
1
0
0
```
### Code
```c#
var inputs = Console.ReadLine();
if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    var c = int.Parse(inputs.Split(" ")[2]);
    Console.WriteLine((a + b) % c);
    Console.WriteLine(((a % c) + (b % c)) % c);
    Console.WriteLine((a * b) % c);
    Console.WriteLine(((a % c) * (b % c)) % c);
}
```
