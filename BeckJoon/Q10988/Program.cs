var input = Console.ReadLine();
var reverse = new string(input.Reverse().ToArray());

if (!string.IsNullOrEmpty(input) && input.Equals(reverse))
    Console.WriteLine(1);
else
    Console.WriteLine(0);