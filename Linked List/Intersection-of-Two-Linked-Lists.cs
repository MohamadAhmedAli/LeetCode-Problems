/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
{
    int countA = 1;
    int countB = 1;
    var p1 = headA;
    var p2 = headB;
    while(p1.next != null)
    {
        countA++;
        p1 = p1.next;
    }
    while (p2.next != null)
    {
        countB++;
        p2 = p2.next;
    }
     p1 = headA;
     p2 = headB;
    while(countA > countB)
    {
        p1 = p1.next;
        countA--;
    }

    while (countB > countA)
    {
        p2 = p2.next;
        countB--;
    }

    while(countA > 0)
    {
        if (p1 == p2)
            return p2;
        else
        {
            p1 = p1.next;
            p2 = p2.next;
            countA--;
        }
    }

    return null;
}
}