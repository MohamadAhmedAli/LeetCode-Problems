/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        
        int count = 1;
        var curr = head;
        while (curr.next != null)
        {
             curr = curr.next;
            count++;
        }

        if(count == 1) 
            return null;
        var node = head;

        if(count - n == 0)
            return head.next;
        while (count - n >1)
        {
            node = node.next;
            count--;
        }
        node.next = node.next.next;

        return head;
    }
}