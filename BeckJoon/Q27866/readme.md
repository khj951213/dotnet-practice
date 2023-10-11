### Question 27866
When a word S and a number i is given, find the ist character of given S.
** the index does not start with 0 (start from 1)

### Example 1
Input
```
Sprout
3
```
Output
```
r
```

### Example 2
Input
```
shiftpsh
6
```
Output
```
p
```

### Example 3
Input
```
Baekjoon
4
```
Output
```
k
```

### Code
```c#
var s = Console.ReadLine();
var i = int.Parse(Console.ReadLine());

Console.WriteLine(s[--i]);
```
