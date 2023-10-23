### Question 3003
Chess uses 16 pieces 1 King, 1 Queen, 2 Rooks, 2 Bishops, 2 Knights, 8 pones. <br />
Given a white pieces, write a program to find out how many pieces you need to add or subract to make the correct set.

### Example 
Input
```
0 1 2 2 2 7
```
Output
```
1 0 0 0 0 1
```

### Example 2
Input
```
2 1 2 1 2 1
```
Output
```
-1 0 0 1 0 7
```


### Code
```c#
var cp = new List<int>() { 1, 1, 2, 2, 2, 8 };
var input = Console.ReadLine();
var nList = input.Split(" ").Select(int.Parse).ToList();
for (int i = 0; i < nList.Count; i++)
{
    cp[i] = cp[i] - nList[i];
}

foreach (var item in cp)
{
    Console.Write(item + " ");
}
```
