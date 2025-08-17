 public class MyLinkedList
{
    LinkedList<int> list = new LinkedList<int>();
    public MyLinkedList()
    {
       
    }

    public int Get(int index)
    {
       
        if (index >= list.Count||index <0||list.Count == 0)
            return -1;

        if (index == 0)
            return list.First();
        else if(index == list.Count-1)
            return list.Last();
        else
        {
            var curr = list.First;

            while (index-- > 0)
            {
                curr = curr.Next;
            }
            return curr.Value;
        }
        
    }

    public void AddAtHead(int val)
    {
        list.AddFirst(val);
    }

    public void AddAtTail(int val)
    {
        list.AddLast(val);
    }

    public void AddAtIndex(int index, int val)
    {
        if(index < 0 || index > list.Count)
            return;
        if (index == 0)
            list.AddFirst(val);

        else if (index == list.Count )
            list.AddLast(val);
        else
        {
            var curr = list.First;

            while (index-- > 1)
            {
                curr = curr.Next;
            }
            list.AddAfter(curr, val);
        }
        

    }

    public void DeleteAtIndex(int index)
    {
        if (list.Count == 0 ||index >= list.Count || index <0)
            return;
        var curr = list.First;
        if (index == 0)
            list.RemoveFirst();
        else if (index == list.Count - 1)
            list.RemoveLast();
        else
        {
            while (index-- > 0)
            {
                curr = curr.Next;
            }
            list.Remove(curr);
        }
       

    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */