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
     public ListNode DeleteDuplicates(ListNode head)
 {
     Dictionary<int,int> dict = new Dictionary<int,int>();

     var zero = new ListNode(0);
     var curr = head;
     while (curr != null)
     {
         if (dict.ContainsKey(curr.val))
             dict[curr.val]++;
         else 
             dict.Add(curr.val,0);

         curr = curr.next;
     }

     curr = zero;
     foreach (var item in dict.Keys)
     {
         if (dict[item] ==0)
         {
             curr.next = new ListNode(item);
             curr = curr.next;
         }
         

     }

     return zero.next;
 }
}