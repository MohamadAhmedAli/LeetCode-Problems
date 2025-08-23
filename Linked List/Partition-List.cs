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
    public ListNode Partition(ListNode head, int x)
{
    int i_less = 0;
    int i_greater = 0;
    List<int> less = new List<int>();
    List<int> greater = new List<int>();

    var curr = head;
    while (curr != null)
    {
        if (curr.val < x)
        {
            less.Insert(i_less,curr.val);
            i_less++;
        }
        else
        {
            greater.Insert(i_greater, curr.val);
            i_greater++;
        }

        curr = curr.next;
    }

    ListNode dummy = new ListNode(0);
    curr = dummy;
    for (int i = 0; i < i_less; i++)
    {
        curr.next = new ListNode(less[i]);
        curr = curr.next;
    }
    for (int i = 0; i < i_greater; i++)
    {
        curr.next = new ListNode(greater[i]);
        curr = curr.next;
    }
    return dummy.next;
}
}