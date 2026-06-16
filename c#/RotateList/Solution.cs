/*
61. Rotate List
Given the head of a linked list, rotate the list to the right by k places.

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:


Input: head = [0,1,2], k = 4
Output: [2,0,1]
 

Constraints:

The number of nodes in the list is in the range [0, 500].
-100 <= Node.val <= 100
0 <= k <= 2 * 109
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

