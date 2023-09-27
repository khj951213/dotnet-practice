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