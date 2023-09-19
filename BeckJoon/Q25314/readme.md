### Question 25314
������ ������ ���� ���̴�. ���� �غ� ������ �ؼ� �ռ� �������� �� ����� ���ƴ� ���� ���������� ĥ�ǿ� ���� �ڵ��ϴ� ������ �޾Ҵ�. ���ư� ���� ������ �� ���� ���ϴ� ��������. C++ å�� ������ �о��� ���ƴ� ������ �� ���� ���ϴ� �ڵ带 ĥ�ǿ� ������. �ڵ带 �� �������� ���� ������ �ߴ�. ������, ������� 
N ����Ʈ ũ���� ������� ���α׷��� ��� �����ؾ� �ұ��?��

���ƴ� å�� �ִ� ���� �ڷ����� ���õ� ������ ����� �´�. å���� long int�� 
4 ����Ʈ �������� ������ �� �ִ� ���� �ڷ����̰� long long int�� 
8 ����Ʈ �������� ������ �� �ִ� ���� �ڷ����̶�� ���� �־���. ���ƴ� �̷� ������ �����. ��int �տ� long�� �ϳ��� �� ���� ������ 
4 ����Ʈ�� ������ �� �ִ� ������ �þ�� �ɱ�? �и� long long long int�� 
12 ����Ʈ, long long long long int�� 
16 ����Ʈ���� ������ �� �ִ� ���� �ڷ����� �ž�!�� �׷��� ���ƴ� ��Ȳ�ϴ� �������� ���� �ڷ��� ä ĥ�ǿ� ���� �ڷ����� �� �������� �����ߴ�.

���ư� 
N ����Ʈ �������� ������ �� �ִٰ� �����ؼ� ĥ�ǿ� �� ���� �ڷ����� �̸��� �����ϱ�?

### Example 1
Input
```
4
```
Output
```
long int
```

### Example 2
Input
```
20
```
Output
```
long long long long long int
```

### Code
```c#
using System.Text;

var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    var stringBuilder = new StringBuilder();
    var n = int.Parse(input);
    for (int i = 0; i < n/4; i++)
    {
        stringBuilder.Append("long ");
    }
    stringBuilder.Append("int");
    Console.WriteLine(stringBuilder.ToString());
}
```
