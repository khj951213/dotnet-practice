ListNode l1 = new(2,
    new ListNode(4,
        new ListNode(3)));

ListNode l2 = new(5,
    new ListNode(6,
        new ListNode(4)));

ListNode? result = Solve(l1, l2);

while (result != null)
{
    Console.Write(result.Value + " ");
    result = result.Next;
}

static ListNode? Solve(ListNode? l1, ListNode? l2)
{
    ListNode dummy = new(0);
    ListNode current = dummy;

    int carry = 0;

    while (l1 != null || l2 != null || carry > 0)
    {
        int x = l1?.Value ?? 0;
        int y = l2?.Value ?? 0;

        int sum = x + y + carry;

        carry = sum / 10;
        int digit = sum % 10;

        current.Next = new ListNode(digit);
        current = current.Next;

        l1 = l1?.Next;
        l2 = l2?.Next;
    }

    return dummy.Next;
}

public class ListNode
{
    public int Value { get; set; }
    public ListNode? Next { get; set; }

    public ListNode(int value = 0, ListNode? next = null)
    {
        Value = value;
        Next = next;
    }
}