### Question 9498
Find out grade.

- A = 90 - 100
- B = 80 - 89
- C = 70 - 79
- D = 60 - 69
- F = 0 - 59

### Example
Input
```
67
```
Output
```
D
```
### Code
```c#
var inputScore = Console.ReadLine();

if (!string.IsNullOrEmpty(inputScore))
{
    var grade = "";
    var score = int.Parse(inputScore);
    if (score > 89) grade = "A";
    else if (score > 79) grade = "B";
    else if (score > 69) grade = "C";
    else if (score > 59) grade = "D";
    else grade = "F";
    Console.WriteLine(grade);
}
```
