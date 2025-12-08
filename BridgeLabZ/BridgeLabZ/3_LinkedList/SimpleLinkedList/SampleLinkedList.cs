using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ._3_LinkedList.SimpleLinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    internal class SampleLinkedList
    {
        public Node Head;

        // INSERT AT BEGINNING
        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        // INSERT AT END
        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node curr = Head;
            while (curr.Next != null)
                curr = curr.Next;

            curr.Next = newNode;
        }

        // DELETE NODE
        public void Delete(int key)
        {
            if (Head == null) return;

            if (Head.Data == key)
            {
                Head = Head.Next;
                return;
            }

            Node curr = Head;
            while (curr.Next != null && curr.Next.Data != key)
                curr = curr.Next;

            if (curr.Next == null) return;

            curr.Next = curr.Next.Next;
        }

        // SEARCH
        public bool Search(int key)
        {
            Node curr = Head;
            while (curr != null)
            {
                if (curr.Data == key) return true;
                curr = curr.Next;
            }
            return false;
        }

        // PRINT
        public void Print()
        {
            Node curr = Head;
            while (curr != null)
            {
                Console.Write(curr.Data + " -> ");
                curr = curr.Next;
            }
            Console.WriteLine("NULL");
        }
    }
    public class Program
    {
        public static void Main()
        {
            SampleLinkedList list = new SampleLinkedList();

            list.InsertAtBeginning(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.Print();

            Console.WriteLine(list.Search(20)); // True

            list.Delete(20);
            list.Print();
        }
    }
}
