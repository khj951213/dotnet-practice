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