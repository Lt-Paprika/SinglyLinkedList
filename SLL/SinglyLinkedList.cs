using System;
using System.Collections.Generic;

namespace Assignment_3_skeleton
{
    public class Asign3LinkedList<T> : ILinkedListADT
    {
        private Node head;
        private int listSize;

        public Assign3LinkedList()
        {
            head = null;
            listSize = 0;
        }

        public bool IsEmpty()
        {
            if(head is null)
            {
                return true;
            }
            return false;
        }

        public void clear()
        {
            head = null;
            listSize = 0;
        }

        public void Append(Object data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode currentNode = head;
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;
        }

        public void Prepend(Object data)
        {
            Node newNode = new Node(data);

            newNode.Next = head;
            head = newNode;
        }

        public void Insert(Object data, int index)
        {
            if (index == null)
            {
                throw new ArgumentNullException(nameof(index)), "The node to add by cannot be null"
            }

            Node newNode = new Node(data);

            if (head == null)
            {
                listSize++;
                head = newNode;
                return;
            }

            newNode currentNode = head;
            while (currentNode.Next != null)
            {
                if (currentNode.Data.Equals(index.Data))
                {
                    listSize++;
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    return;
                }

                currentNode.Next = newNode;
            }

            throw new InvalidOperationException("node does not exist in the list");
        }

        public void Replace(Object data, int index)
        {
            if (index == null)
            {
                throw new ArgumentNullException(nameof(index), "The node to replace cannot be null or negative")
            }
            if (head == null)
            {
                return;
            }

            Node previousNode = null;
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(index))
                {
                    currentNode = data;
                    return;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            throw new InvalidOperationException("The node to replace does not exist within the list.")
        }

        public int Size()
        {
            if (head is null)
            {
                return 0;
            }
            return listSize;
        }

        public void Delete(int index)
        {
            if (index == null)
            {
                throw new ArgumentNullException(nameof(index), "The node to remove cannot be null.");
            }

            if (head == null)
            {
                return;
            }

            Node previousNode = null;
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(index))
                {
                    listSize--;
                    
                    previousNode.Next = currentNode.Next;
                    return;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            throw new InvalidOperationException("The node to remove does not exist in the list.");
        }

        public void Retrieve(int index)
        {
            if (head == null)
            {
                return;
            }

            Node previousNode = null;
            Node currentNode = head;
            while (currentNode != null)
            (
                if (currentNode.Data.Equals(index.Data))
                {
                    nodeInfo = currentNode.Data;
                    Console.WriteLine($"{nodeInfo}");
                    return;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            )

        }

        int IndexOf (Object data)
        {

        }

        bool Contains(Object data)
        {

        }

    }
}
