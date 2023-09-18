### Question 2588
Get (three digit number) x (tree digit number) calculation process 

For example

   472
  x385
  \-----
  2360 -- (1)
 3776 -- (2)
1416 -- (3)
\--------
181720 -- (4)

return 1, 2, 3, 4 results in a separate line.

### Example
Input
```
472
385
```
Output
```
2360
3776
1416
181720
```
### Code
```c#
var b = Console.ReadLine();
var a = Console.ReadLine();

if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
{
    var n1 = int.Parse(a);
    var n2 = int.Parse(b);
    var res = new int[4];
    var ones = n1 % 10;
    res[0] = ones * n2;
    var tens = n1 % 100 - ones;
    res[1] = (tens * n2) / 10;
    var hundreds = n1 - (ones + tens);
    res[2] = (hundreds * n2) / 100;
    res[3] = res[0] + res[1] * 10 + res[2] * 100;
    foreach (var item in res)
    {
        Console.WriteLine(item);
    }
}
```
