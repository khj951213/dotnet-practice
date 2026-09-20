namespace Algorithm.Problems;


/**
* 문제: 중복 숫자 찾기
* 정수 배열 nums가 주어진다. 배열 안에서 처음으로 두번째 등장하는 숫자를 반환.
*/

public static class FindDuplicateNumbers
{
    public static int Solve(int[] nums)
{
    HashSet<int> passed = [];

    foreach (int num in nums)
    {
        if (!passed.Add(num))
        {
            return num;
        }
    }

    return -1;
}
}