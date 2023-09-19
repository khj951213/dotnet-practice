### Question 2439
Drawing star


### Example 
Input
```
5
```
Output
```
    *
   **
  ***
 ****
*****
```


### Code
```c#
using System.Text;

var nRow = int.Parse(Console.ReadLine());

var starBuilder = new StringBuilder();
var spaceBuilder = new StringBuilder("     ");
for (int i = 0; i < nRow; i++)
{
    starBuilder.Append("*");
    spaceBuilder.Remove(0, 1);
    Console.WriteLine(spaceBuilder.ToString() + starBuilder.ToString());
}
```
