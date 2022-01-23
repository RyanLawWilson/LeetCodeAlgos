using System;
using System.Collections.Generic;
using System.Text;


public class MinStack
{
    public SinglyLinkedListNode head;

    public MinStack() { }

    public void Push(int val)
    {
        if (head == null)
        {
            head = new SinglyLinkedListNode(val);
        }
        else
        {
            SinglyLinkedListNode temp = head;
            head = new SinglyLinkedListNode(val);
            head.next = temp;
        }
    }

    public void Pop()
    {
        head = head.next;
    }

    public int Top()
    {
        return head.val;
    }

    public int GetMin()
    {
        int min = head.val;
        SinglyLinkedListNode currentNode = head;

        // Search through the stack to find the smallest value.
        while (currentNode != null)
        {
            if (currentNode.val < min)
            {
                min = currentNode.val;
            }
            else
            {
                currentNode = currentNode.next;
            }
        }

        return min;
    }
}

public class SinglyLinkedListNode
{
    public int val;
    public SinglyLinkedListNode next;
    public SinglyLinkedListNode(int val)
    {
        this.val = val;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
