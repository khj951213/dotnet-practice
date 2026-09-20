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
                // peek는 stack의 맨 위 값을 보는 메서드
                // peek는 null일 경우 예외처리가되기 때문에 확인
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

        return parentheses.Count == 0; // 추가적인 괄호가 (예:'(((') 들어있으면 return false;
    }
}