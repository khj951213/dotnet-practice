### Question 1152
Find how characters are inside a given word.

### Example 1
Input
```
The Curious Case of Benjamin Button
```
Output
```
6
```

### Example 2
Input
```
 The first character is a blank
```
Output
```
6
```

### Code
```c#
var s = Console.ReadLine();

Console.WriteLine(s.Trim().Split(" ").Length);

```
