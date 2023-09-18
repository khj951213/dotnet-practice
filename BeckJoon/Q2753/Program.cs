var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    bool isLeapYear = false;
    var year = int.Parse(input);
    
    if (year % 400 == 0 || (year % 4 == 0) && (year % 100 != 0)) isLeapYear = true;

    Console.WriteLine(isLeapYear);
}