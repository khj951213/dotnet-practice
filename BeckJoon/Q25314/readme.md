### Question 25314
<<<<<<< Updated upstream
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
=======
Coding is PE (Physical Education) !

Today is June's interview day. June has been preparing for the interview test and now he is doing his final interview coding test using a whiteboard.
The last question was to add two numbers. June read the programming book and wrote the code on the whiteboard. When the examiner looked at the whiteboard,
he asked June "if the input is N byte sized integer, how should we implement this?"
<br /> <br />
June recalled his memory and remembered that the book said long int can store up to 4 bytes and long long int can store up to 8 bytes. June thought that adding long each time
at the front of the int, will the size increase by 4 bytes? And thought long long long int will store up to 12 bytes and long long long long int can store up to 16 bytes. 
June started writing the data type despite of interviewer's panic face.

Question: in the first input, the N will be given (4 <= N <= 1000; N is multiples of 4)

>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
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
=======
Console.WriteLine("Hello, World!");
>>>>>>> Stashed changes
```
