### Question 5622
Calculate the total time to call using the dial phone.

- You need to call using the characters (think of the old phones that have characters with the numbers such as 1 - a, b, c and 2 - d, e, f ...)
- Every time you select a number, the dial needs to go back and start from the beginning.
- Each time you spin the dial it takes 2 seconds to turn to 1.
- For numbers bigger than 1, it takes 1 second from one number to the other (example. from number 2 to 3 takes 1 second, from number 3 to 4 takes 2 seconds, ..., from 1 to 4 it takes 3 seconds).
- For more clear explanation refer to the code.
<br />

For example, if you try to call using the alphabet UNUCIC, the phone number will be 868242. <br />
This means that you need to add (2s + 7s) + (2s + 6s) ... (2s + 1s).

### Example 1
Input
```
WA
```
Output
```
13
```

### Example 2
Input
```
UNUCIC
```
Output
```
36
```


### Code
```c#
var dialDict = new Dictionary<string, object>()
{
    { "a", 2 },
    { "b", 2 },
    { "c", 2 },
    { "d", 3 },
    { "e", 3 },
    { "f", 3 },
    { "g", 4 },
    { "h", 4 },
    { "i", 4 },
    { "j", 5 },
    { "k", 5 },
    { "l", 5 },
    { "m", 6 },
    { "n", 6 },
    { "o", 6 },
    { "p", 7 },
    { "q", 7 },
    { "r", 7 },
    { "s", 7 },
    { "t", 8 },
    { "u", 8 },
    { "v", 8 },
    { "w", 9 },
    { "x", 9 },
    { "y", 9 },
    { "z", 9 },
};

var s = Console.ReadLine().ToLower();
var total = 0;
for (int i = 0; i< s.Length; i++)
{
    total += 2;
    total += (int)dialDict[s[i].ToString()]-1;
}
Console.WriteLine(total);
```
