### Question 25304
Check receipt <br />

Description: Check if the receipt list has the same amount of price as the total amount.<br/>

- First input: Total amount
- Second input: The number of different items 
- N input: Price and the number of item (separated by the space e.g., 20000 5 = 20000won * 5 items)

### Example 1
Input
```
260000
4
20000 5
30000 2
10000 6
5000 8
```
Output
```
Yes
```

### Example 2
Input
```
250000
4
20000 5
30000 2
10000 6
5000 8
```
Output
```
No
```

### Code
```c#
var totalAmount = Console.ReadLine();
var totalItems = Console.ReadLine();
var total = 0;
if (!string.IsNullOrEmpty(totalAmount) && !string.IsNullOrEmpty(totalItems))
{
    for (int i = 0; i < int.Parse(totalItems); i++)
    {
        var priceAndNumber = Console.ReadLine();
        if (!string.IsNullOrEmpty(priceAndNumber))
        {
            var price = int.Parse(priceAndNumber.Split(" ")[0]);
            var count = int.Parse(priceAndNumber.Split(" ")[1]);
            total += price * count;
        }
    }

    if (total == int.Parse(totalAmount)) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
```
