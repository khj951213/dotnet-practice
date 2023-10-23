### Question 2444
Draw star

### Example
Input
```
5
```
Output
```
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
```

### Code
```c#
using System.Text;


StarFamily SpaceBuilder = (int n) =>
{
    var builder = new StringBuilder();
    for (int i = n - 1; i > 0; i--)
    {
        builder.Append(" ");
    }
    return builder.ToString();
};

StarFamily StarBuilder = (int n) =>
{
    var builder = new StringBuilder();
    var m = n + 1;
    for (int i = 0; i < n + m; i++)
    {
        builder.Append("*");
    }
    return builder.ToString();   
};

var n = int.Parse(Console.ReadLine() ?? "5");

var builder = new StringBuilder();
for (int i = 0; i < n; i++)
{
    builder.Append(new StarFamily(SpaceBuilder).Invoke(n - i));
    builder.AppendLine(new StarFamily(StarBuilder).Invoke(i));
}
for (int i = n - 2; i > -1; i--)
{
    builder.Append(new StarFamily(SpaceBuilder).Invoke(n - i));
    builder.AppendLine(new StarFamily(StarBuilder).Invoke(i));
}

Console.WriteLine(builder.ToString());
delegate string StarFamily(int n);

```
