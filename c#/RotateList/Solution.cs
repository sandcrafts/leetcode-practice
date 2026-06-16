/*
61. Rotate List

*/

public class Solution
{
    public ListNode? Solve(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }

        ListNode dummy = head;
        ListNode newTail = head;
        int counter = 1;

        while (dummy.next != null)
        {
            dummy = dummy.next;
            counter++;
        }
        k %= counter;
        if (k == 0)
            return head;

        int steps = counter - k - 1;

        for (int i = 1; i <= steps; i++)
        {
            newTail = newTail.next;
        }

        ListNode newHead = newTail.next;
        newTail.next = null;
        dummy.next = head;


        return newHead;
    }
}

