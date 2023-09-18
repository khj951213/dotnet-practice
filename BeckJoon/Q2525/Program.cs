var time = Console.ReadLine();
var add = Console.ReadLine();

if (!string.IsNullOrEmpty(time) && !string.IsNullOrEmpty(add))
{
    var hour = int.Parse(time.Split(" ")[0]);
    var minute = int.Parse(time.Split(" ")[1]);

    minute += int.Parse(add);

    while (minute > 59)
    {
        minute -= 60;
        hour += 1;
    }

    while (hour > 23)
    {
        hour -= 24;
    }

    Console.WriteLine(hour + " " + minute);

}