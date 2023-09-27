### Question 10810
Putting a ball inside the basket.

- N = Total number of baskets 
- M = Number of trials
- i = from basket
- j = to basket
- k = the ball's number

For each trial, Dohyun (person's name) will put the k ball (ball's number) from i basket to j basket <br />

For example, if Dohyun puts ball number 2 from basket 4 to basket 6 which means that i = 4, j = 6, and k = 2. <br />
The result will be: 0 0 0 2 2 2. You can see that the ball number 2 is inside the basket 4, 5, 6. <br />

### Example 1
Input
```
5 4
1 2 3
3 4 4
1 4 1
2 2 2
```
Output
```
1 2 1 1 0
```

### Code
```c#
var inputs = Console.ReadLine();
var nums = ToNumList(inputs);
var n = nums[0];
var m = nums[1];

var nBaskets = new int[n];

for (int i = 1; i < n; i++)
{
    nBaskets[i] = 0;
}

for (int trials = 0; trials < m; trials++)
{
    inputs = Console.ReadLine();
    nums = ToNumList(inputs);
    var i = nums[0] - 1;
    var j = nums[1] - 1;
    var k = nums[2];
    for (int l = i; l <= j; l++)
    {
        nBaskets[l] = k;
    }
}

for (int i = 0; i < n; i++)
{
    Console.Write(nBaskets[i] + " ");
}

List<int> ToNumList(string? s)
{
    if (s == null) return new();
    else return s.Trim().Split(" ").Select(e => int.Parse(e)).ToList();
}
```
