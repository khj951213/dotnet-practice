namespace Algorithm.Problems;

public static class CorrectParantheses
{

    public static bool Solve(string s)
{
    Stack<char> parentheses = new();

    foreach (var c in s)
    {
        if (c == ')')
        {
            if (parentheses.Count == 0 || parentheses.Peek() != '(')
                return false;

            parentheses.Pop();
        }
        else if (c == ']')
        {
            if (parentheses.Count == 0 || parentheses.Peek() != '[')
                return false;

            parentheses.Pop();
        }
        else if (c == '}')
        {
            if (parentheses.Count == 0 || parentheses.Peek() != '{')
                return false;

            parentheses.Pop();
        }
        else if (c == '(' || c == '{' || c == '[')
        {
            parentheses.Push(c);
        }
    }

    return parentheses.Count == 0;
}
}