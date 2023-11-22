### Question 2941
Count character

### Example 
Input
```
ljes=njak
```
Output
```
6
```

### Example 2
Input
```
ddz=z=
```
Output
```
2
```


### Code
```c#
var input = Console.ReadLine();
var inputList = input?.ToCharArray();


if (inputList != null && inputList.Length > 0)
{
    var cnt = 0;
    var length = inputList.Length;
    for (int i = 0; i < length; i++)
    {
        if (inputList[i].Equals('c') && i + 1 <= length)
        {
            if (inputList[i + 1].Equals('=') || inputList[i + 1].Equals('-'))
            {
                cnt++;
                i++;
            }
            else
            {
                cnt++;
            }
        }
        else if (inputList[i].Equals('d') && i + 1 <= length)
        {
            if (inputList[i + 1].Equals('-'))
            {
                cnt++;
                i++;
            }
            else if (inputList[i + 1].Equals('z') && inputList[i + 2].Equals('='))
            {
                cnt++;
                i += 2;
            }
            else
            {
                cnt++;
            }
        }
        else if (i + 1 <= length && (
            inputList[i].Equals('l') && inputList[i + 1].Equals('j') 
            || inputList[i].Equals('n') && inputList[i + 1].Equals('j')
            || inputList[i].Equals('s') && inputList[i + 1].Equals('=')
            || inputList[i].Equals('z') && inputList[i + 1].Equals('=')))
        {
            cnt++;
            i++;
        }
        else
        {
            cnt++;
        }
    }

    Console.WriteLine(cnt);
}


```
