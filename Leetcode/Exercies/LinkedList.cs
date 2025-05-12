using System;

namespace Leetcode.Exercies
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node<T> Previous;

        public Node(T value)
        {
            Data = value;
            Next = null;
        }
    }

    public class LinkedList<T>
    {
        private Node<T> head;

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                return;
            }
            else
            {
                Node<T> currentNode = head;
                
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);

            newNode.Next = head;
            head = newNode;
        }

        public void RemoveFirst(T value)
        {
            if (head == null)
                return;

            head = head.Next;

            return;
        }

        public void RemoveLast(T value)
        {
            if (head == null)
            {
                return;
            }
            else
            {
                if (head.Next == null)
                {
                    head = null;
                    return;
                }
                else
                {
                    Node<T> currentNode = head;

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
