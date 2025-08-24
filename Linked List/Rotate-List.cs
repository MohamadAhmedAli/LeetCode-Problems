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
     public ListNode RotateRight(ListNode head, int k)
 {
     if (head == null || head.next == null|| k ==0)
         return head;

     int index = 0;
     List<int> list = new List<int>();

     ListNode curr = head;
     while (curr != null)
     {
         list.Insert(index, curr.val);
         index++;
         curr =curr.next;
     }
     int count =list.Count;
     int start = (count - k % count) %count ;
     ListNode newhead = new ListNode(list[start]);
     curr = newhead;
     while(--count >0)
     {
         start++;
         if (start == list.Count)
             start = 0;

         curr.next = new ListNode(list[start]);
         curr = curr.next;
        
     }

     return newhead;
 }
}