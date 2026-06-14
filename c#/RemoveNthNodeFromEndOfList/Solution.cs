/*
19. Remove Nth Node From End of List

Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

Example 1:


Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
 

Constraints:

The number of nodes in the list is sz.
1 <= sz <= 30
0 <= Node.val <= 100
1 <= n <= sz
 

Follow up: Could you do this in one pass?

*/

public class Solution
{
    public ListNode? Solve(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        ListNode? counter = head;
        int count = 0;

        while (counter != null) {
            counter = counter.next;
            count++;
        }

        int target = count - n;

        for (int i = 1; i <= target; i++)
        {
            prev = prev.next!;
        }

        prev.next = prev.next!.next;

        return dummy.next;
    }
}

