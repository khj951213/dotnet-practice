var input = Console.ReadLine();

var charList = new int[26];
for (int i = 0; i < charList.Length; i++)
{
    charList[i] = 0;
}
var inputChars = input?.ToLower().ToCharArray();
var isQuestion = false;
var isFound = false;
var index = 0;
if (inputChars != null && inputChars.Length > 0)
{
    foreach (var c in inputChars)
    {
        charList[c-97] += 1;
        if (index != c - 97 && charList[c-97] > 1)
        {
            isQuestion = true;
            break;
        }
        else if (charList[c-97] > 1)
        {
            isFound = true;
            index = c - 97;
        }
        else if (!isFound)
        {
            index = c - 97;
        }
    }

    Console.WriteLine(isQuestion ? "?" : ((char)(index+97)).ToString().ToUpper());
    
}
