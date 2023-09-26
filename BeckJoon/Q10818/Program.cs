var n = Console.ReadLine();
var numStr = Console.ReadLine();

if (numStr != null) {
    var nums = numStr.Split(" ").Select(e => int.Parse(e)).ToList();
    Console.WriteLine(nums.Min());
    Console.WriteLine(nums.Max());
}