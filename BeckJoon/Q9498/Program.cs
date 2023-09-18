var inputScore = Console.ReadLine();

if (!string.IsNullOrEmpty(inputScore))
{
    var grade = "";
    var score = int.Parse(inputScore);
    if (score > 89) grade = "A";
    else if (score > 79) grade = "B";
    else if (score > 69) grade = "C";
    else if (score > 59) grade = "D";
    else grade = "F";
    Console.WriteLine(grade);
}