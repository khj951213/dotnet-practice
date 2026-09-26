

static string Solution(string s, int numRows)
{
    if (numRows == 1 || numRows >= s.Length)
    {
        return s;
    }

    string[] rows = new string[numRows];

    int currentRow = 0;
    bool goingDown = false;

    foreach (char c in s)
    {
        rows[currentRow] += c;
        if (currentRow == 0 || currentRow == numRows - 1)
        {
            goingDown = !goingDown;
        }

        currentRow += goingDown ? 1 : -1;
    }

    return string.Concat(rows);
}