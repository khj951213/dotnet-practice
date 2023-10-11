### Question 10809
Find the alphatbet in the given word from A-Z. <br />
The word will be given and you'll need to find where the character is from a-z. <br />

- If the character is included in the word then print the index.
- If not included in the word then print -1.

### Example 
Input
```
baekjoon
```
Output
```
1 0 -1 -1 2 -1 -1 -1 -1 4 3 -1 -1 7 5 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
```


### Code
```c#
var s = Console.ReadLine();

var charList = new List<char>();
for (int i = 97; i < 123; i++)
{
    charList.Add((char)i);
}

var resList = new List<int>();

foreach (var c in charList)
{
    if (s.Contains(c))
    {
        resList.Add(s.IndexOf(c));
    }
    else
    {
        resList.Add(-1);
    }
}

foreach (var r in resList)
{
    Console.Write(r + " ");
}
```
