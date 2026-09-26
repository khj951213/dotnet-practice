namespace Algorithm.Problems;

public class LC0002_AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val)
        {
            this.val = val;
        }

        public ListNode(int val, ListNode? next)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode Solve(ListNode l1, ListNode l2)
    {
        ListNode dummy = new(0); // create a result list node
        ListNode current = dummy; // copy reference

        ListNode? p1 = l1; // for null warning
        ListNode? p2 = l2; // for null warning

        int carry = 0; // next 10+ digit

        while (p1 != null || p2 != null || carry > 0)
        {
            int x = p1?.val ?? 0; 
            int y = p2?.val ?? 0;

            int sum = x + y + carry;

            carry = sum / 10;
            int digit = sum % 10;
            

            current.next = new ListNode(digit);
            current = current.next;

            Console.WriteLine($"x: {x}, y: {y}, sum: {sum}, carry: {carry}, digit: {digit}");
            PrintList(current);

            p1 = p1?.next;
            p2 = p2?.next;
        }

        return dummy.next!;
    }

    public static void PrintList(ListNode? node)
    {
        Console.Write("[");

        while (node != null)
        {
            Console.Write(node.val);

            if (node.next != null)
            {
                Console.Write(",");
            }

            node = node.next;
        }

        Console.WriteLine("]");
    }
}