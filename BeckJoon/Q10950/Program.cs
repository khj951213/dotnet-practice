var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var num1 = int.Parse(inputs.Split(" ")[0]);
    var num2 = int.Parse(inputs.Split(" ")[1]);
    Console.WriteLine(num1 + num2);
}