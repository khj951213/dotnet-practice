### Question 25314
<<<<<<< Updated upstream
오늘은 혜아의 면접 날이다. 면접 준비를 열심히 해서 앞선 질문들을 잘 대답한 혜아는 이제 마지막으로 칠판에 직접 코딩하는 문제를 받았다. 혜아가 받은 문제는 두 수를 더하는 문제였다. C++ 책을 열심히 읽었던 혜아는 간단히 두 수를 더하는 코드를 칠판에 적었다. 코드를 본 면접관은 다음 질문을 했다. “만약, 입출력이 
N 바이트 크기의 정수라면 프로그램을 어떻게 구현해야 할까요?”

혜아는 책에 있는 정수 자료형과 관련된 내용을 기억해 냈다. 책에는 long int는 
4 바이트 정수까지 저장할 수 있는 정수 자료형이고 long long int는 
8 바이트 정수까지 저장할 수 있는 정수 자료형이라고 적혀 있었다. 혜아는 이런 생각이 들었다. “int 앞에 long을 하나씩 더 붙일 때마다 
4 바이트씩 저장할 수 있는 공간이 늘어나는 걸까? 분명 long long long int는 
12 바이트, long long long long int는 
16 바이트까지 저장할 수 있는 정수 자료형일 거야!” 그렇게 혜아는 당황하는 면접관의 얼굴을 뒤로한 채 칠판에 정수 자료형을 써 내려가기 시작했다.

혜아가 
N 바이트 정수까지 저장할 수 있다고 생각해서 칠판에 쓴 정수 자료형의 이름은 무엇일까?
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
