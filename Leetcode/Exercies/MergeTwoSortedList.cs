using System;
using System.Dynamic;
using Leetcode.Exercies;

namespace Leetcode.Exercies
{
    public class MergeTwoSortedList
    {
        private Node Head;

        MergeTwoSortedList(Node FirstLinkedListHead, Node SecondLinkedListHead)
        {
            Head = (FirstLinkedListHead.Data > SecondLinkedListHead.Data) ? FirstLinkedListHead : SecondLinkedListHead;
        }

        public Node Merge()
        {



            return null;
        }

        public void AddLast(Node Node)
        { 
            if (Head == null)
            {
                Head = Node;
                return;
            }
            else
            {
                Node currentNode = Head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = Node;
            }
        }
        public void AddFirst(Node Node)
        {
            Node.Next = Head;
            Head = Node;
        }

        public void RemoveFirst()
        {
            if (Head == null)
                return;

            Head = Head.Next;
        }

        public void RemoveLast()
        {
            if (Head != null)
            {
                if (Head.Next == null)
                {
                    Head = null;
                }
                else
                {
                    Node currentNode = Head;

                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }

                    currentNode.Next = null;
                }
            }
        }
    }
}
