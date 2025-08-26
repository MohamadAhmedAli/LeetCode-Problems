/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head)
{ 
    if (head == null)
        return head;
    Node dummy = new Node();
    Node curr = dummy;
    Stack<Node> stack = new Stack<Node>();
    stack.Push(head);

    while(stack.Count > 0)
    {
        Node node = stack.Pop();
        if(node.next != null) 
            stack.Push(node.next);
        if(node.child != null)
            stack.Push(node.child);

        curr.next = node;
        node.prev = curr;
        node.child = null;
        curr = node;
    }
    dummy.next.prev = null;
    return dummy.next;
}
}