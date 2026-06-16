/*
82. Remove Duplicates from Sorted List II

Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:


Input: head = [1,1,1,2,3]
Output: [2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.


*/

public class Solution
{
    public ListNode? Solve(ListNode head)
    {
        ListNode holder = new ListNode (0, head);
        ListNode prev = holder;
        ListNode dummy = head;

        while (dummy != null) {
            bool isDuplicate = false;
            
            while (dummy.next != null && dummy.val == dummy.next.val) {
                dummy = dummy.next;
                isDuplicate = true;
            }

            if (isDuplicate) {
                prev.next = dummy.next;
            } else {
                prev = dummy;
            }
            
            dummy = dummy.next;
        }

        return holder.next;
    }
}

