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
public class Solution {
     public ListNode SwapPairs(ListNode head)
 {
     ListNode temp ;
     if (head == null || head.next == null)
         return head;
     
    ListNode dummy = new  ListNode(0,head);
    ListNode prev = dummy;
    ListNode curr = head;
    ListNode second = curr.next;
    ListNode nxt = curr.next.next;
     while (curr !=null&&curr.next !=null)
     {
        nxt = curr.next.next;
        second = curr.next;

        prev.next = second;
        second.next =curr;
        curr.next=nxt;
        
        prev = curr;
        curr = nxt;
        
     }
     return dummy.next;
 }
}