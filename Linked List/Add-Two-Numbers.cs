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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode dummy = new ListNode();
    ListNode curr = dummy;
    int carry = 0;

    while (l1 != null || l2!= null)
    {
        
        int num1 = l1 == null ? 0 : l1.val;
        int num2 = l2 ==null ? 0: l2.val;

        int sum = num1 + num2 + carry;

        curr.next = new ListNode(sum % 10);
        carry = sum/ 10;
        curr = curr.next;

        if(l1 != null) 
            l1 = l1.next;

        if(l2  != null)
            l2 = l2.next;

       
    }
    if(carry > 0)
        curr.next = new ListNode(carry);

    return dummy.next;
}
}