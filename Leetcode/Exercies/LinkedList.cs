using System;

namespace Leetcode.Exercies
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node Previous;

        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }

    //public class LinkedList
    //{
    //    private Node Head;

    //    public LinkedList(Node Head)
    //    {
    //        this.Head = Head;
    //    }

    //    public void AddLast(int value)
    //    {
    //        Node  newNode = new Node(value);

    //        if (Head == null)
    //        {
    //            Head = newNode;
    //            return;
    //        }
    //        else
    //        {
    //            Node  currentNode = Head;
                
    //            while (currentNode.Next != null)
    //            {
    //                currentNode = currentNode.Next;
    //            }

    //            currentNode.Next = newNode;
    //        }
    //    }

    //    public void AddFirst(int value)
    //    {
    //        Node  newNode = new Node(value);

    //        newNode.Next = Head;
    //        Head = newNode;
    //    }

    //    public void RemoveFirst()
    //    {
    //        if (Head == null)
    //            return;

    //        Head = Head.Next;

    //        return;
    //    }

    //    public void RemoveLast()
    //    {
    //        if (Head == null)
    //        {
    //            return;
    //        }
    //        else
    //        {
    //            if (Head.Next == null)
    //            {
    //                Head = null;
    //                return;
    //            }
    //            else
    //            {
    //                Node  currentNode = Head;

    //                while (currentNode.Next != null)
    //                {
    //                    currentNode = currentNode.Next;
    //                }

    //                currentNode.Next = null;
    //            }
    //        }
    //    }
    //}
}
