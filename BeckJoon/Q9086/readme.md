### Question 9086
Find the first and last character of the given word (string).
- N: Total words(string)
- Sn: each word

### Example
Input
```
3
ACDKJFOWIEGHE
O
AB
```
Output
```
AE
OO
AB
```
### Code
```c#
var n = int.Parse(Console.ReadLine());
var resArr = new List<string>();
for (int i = 0; i < n; i++)
{
    var s = Console.ReadLine();
    resArr.Add($"{s.First()}{s.Last()}");
}
foreach(var res in resArr)
{
    Console.WriteLine(res);
}
```
