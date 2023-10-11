### Question 2908
Reverse two given numbers from front to back and find the larger number. <br />
Example. Given 734 and 893. First reverse the numbers which will be 437 and 398. <br />
Then, add find the larger number which is 437

### Example 1
Input
```
734 893
```
Output
```
437
```

### Example 2
Input
```
221 231
```
Output
```
132
```

### Example 3
Input
```
839 237
```
Output
```
938
```


### Code
```c#
var given = Console.ReadLine();

var sList = given.Trim().Split(" ").ToList();
var max = 0;
foreach (var s in sList)
{
    var reversed = s.ToCharArray().Reverse();
    var n = int.Parse(new string(reversed.ToArray()));
    if (max < n)
    {
        max = n;
    }
}

Console.WriteLine(max);
```
