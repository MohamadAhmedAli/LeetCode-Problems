/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
    
    if (head == null)
        return head;

    Dictionary<Node,Node> dict = new Dictionary<Node,Node>();

    Node curr = head;

    while(curr != null)
    {
        dict[curr] = new Node(curr.val);
        curr = curr.next;
    }

    curr = head;
    while (curr != null)
    {
        if (curr.next != null)
            dict[curr].next = dict[curr.next];
        else
            dict[curr].next = null;

        if (curr.random != null)
            dict[curr].random = dict[curr.random];
        else
            dict[curr].random = null;

        curr = curr.next;
    }

    return dict[head];
}}