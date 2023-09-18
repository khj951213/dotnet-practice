var inputs = Console.ReadLine();

if (!string.IsNullOrEmpty(inputs))
{
    var hour = int.Parse(inputs.Split(" ")[0]);
    var minute = int.Parse(inputs.Split(" ")[1]);

    minute -= 45;

    if (minute < 0)
    {
        hour -= 1;
        minute += 60;
    }

    if (hour < 0)
    {
        hour = 23;
    }

    Console.WriteLine(hour + " " + minute);
}