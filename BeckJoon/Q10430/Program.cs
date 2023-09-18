var inputs = Console.ReadLine();
if (!string.IsNullOrEmpty(inputs))
{
    var a = int.Parse(inputs.Split(" ")[0]);
    var b = int.Parse(inputs.Split(" ")[1]);
    var c = int.Parse(inputs.Split(" ")[2]);
    Console.WriteLine((a + b) % c);
    Console.WriteLine(((a % c) + (b % c)) % c);
    Console.WriteLine((a * b) % c);
    Console.WriteLine(((a % c) * (b % c)) % c);
}