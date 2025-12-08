using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ._3_LinkedList.SimpleLinkedList_AllFunctions
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

    public class LinkedList
    {
        public Node Head;

        // =============================
        // INSERT AT BEGINNING
        // =============================
        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        // =============================
        // INSERT AT END
        // =============================
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

        // =============================
        // INSERT AT POSITION (1-based)
        // =============================
        public void InsertAtPosition(int data, int position)
        {
            if (position == 1)
            {
                InsertAtBeginning(data);
                return;
            }

            Node newNode = new Node(data);
            Node curr = Head;

            for (int i = 1; i < position - 1; i++)
            {
                if (curr == null) return;
                curr = curr.Next;
            }

            newNode.Next = curr.Next;
            curr.Next = newNode;
        }

        // =============================
        // DELETE BY VALUE
        // =============================
        public void DeleteByValue(int key)
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

        // =============================
        // DELETE AT BEGINNING
        // =============================
        public void DeleteAtBeginning()
        {
            if (Head != null)
                Head = Head.Next;
        }

        // =============================
        // DELETE AT END
        // =============================
        public void DeleteAtEnd()
        {
            if (Head == null) return;
            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            Node curr = Head;
            while (curr.Next.Next != null)
                curr = curr.Next;

            curr.Next = null;
        }

        // =============================
        // DELETE AT POSITION
        // =============================
        public void DeleteAtPosition(int position)
        {
            if (position == 1)
            {
                DeleteAtBeginning();
                return;
            }

            Node curr = Head;

            for (int i = 1; i < position - 1; i++)
            {
                if (curr == null) return;
                curr = curr.Next;
            }

            if (curr.Next == null) return;

            curr.Next = curr.Next.Next;
        }

        // =============================
        // SEARCH ELEMENT
        // =============================
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

        // =============================
        // COUNT NODES
        // =============================
        public int CountNodes()
        {
            int count = 0;
            Node curr = Head;
            while (curr != null)
            {
                count++;
                curr = curr.Next;
            }
            return count;
        }

        // =============================
        // FIND MIDDLE (Fast & Slow Pointer)
        // =============================
        public int FindMiddle()
        {
            if (Head == null) return -1;

            Node slow = Head, fast = Head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow.Data;
        }

        // =============================
        // REVERSE LINKED LIST
        // =============================
        public void Reverse()
        {
            Node prev = null;
            Node curr = Head;
            Node next = null;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            Head = prev;
        }

        // =============================
        // Nth NODE FROM END
        // =============================
        public int NthFromEnd(int n)
        {
            Node main = Head, refPtr = Head;

            for (int i = 0; i < n; i++)
            {
                if (refPtr == null) return -1;
                refPtr = refPtr.Next;
            }

            while (refPtr != null)
            {
                main = main.Next;
                refPtr = refPtr.Next;
            }

            return main.Data;
        }

        // =============================
        // REMOVE DUPLICATES
        // =============================
        public void RemoveDuplicates()
        {
            Node curr = Head;

            while (curr != null)
            {
                Node temp = curr;
                while (temp.Next != null)
                {
                    if (temp.Next.Data == curr.Data)
                        temp.Next = temp.Next.Next;
                    else
                        temp = temp.Next;
                }
                curr = curr.Next;
            }
        }

        // =============================
        // LOOP DETECTION (Floyd's Algorithm)
        // =============================
        public bool DetectLoop()
        {
            Node slow = Head, fast = Head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    return true;
            }
            return false;
        }

        // =============================
        // REMOVE LOOP
        // =============================
        public void RemoveLoop()
        {
            Node slow = Head, fast = Head;

            // Detect loop
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast) break;
            }

            if (slow != fast) return;

            slow = Head;

            while (slow.Next != fast.Next)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            fast.Next = null;
        }

        // =============================
        // SORT LINKED LIST (BUBBLE SORT)
        // =============================
        public void Sort()
        {
            if (Head == null) return;
            bool swapped;

            do
            {
                swapped = false;
                Node curr = Head;

                while (curr.Next != null)
                {
                    if (curr.Data > curr.Next.Data)
                    {
                        int temp = curr.Data;
                        curr.Data = curr.Next.Data;
                        curr.Next.Data = temp;
                        swapped = true;
                    }
                    curr = curr.Next;
                }
            } while (swapped);
        }

        // =============================
        // MERGE TWO SORTED LISTS
        // =============================
        public static Node MergeSorted(Node l1, Node l2)
        {
            Node dummy = new Node(0);
            Node curr = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.Data < l2.Data)
                {
                    curr.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    curr.Next = l2;
                    l2 = l2.Next;
                }
                curr = curr.Next;
            }

            curr.Next = (l1 != null) ? l1 : l2;
            return dummy.Next;
        }

        // =============================
        // ADD TWO LINKED LIST NUMBERS
        // =============================
        public static Node AddTwoNumbers(Node l1, Node l2)
        {
            Node dummy = new Node(0);
            Node curr = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                int sum = carry;

                if (l1 != null)
                {
                    sum += l1.Data;
                    l1 = l1.Next;
                }
                if (l2 != null)
                {
                    sum += l2.Data;
                    l2 = l2.Next;
                }

                carry = sum / 10;
                curr.Next = new Node(sum % 10);
                curr = curr.Next;
            }
            return dummy.Next;
        }

        // =============================
        // PRINT LIST
        // =============================
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

    // =============================
    // MAIN PROGRAM
    // =============================
    public class Program
    {
        public static void Main()
        {
            LinkedList list = new LinkedList();

            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.Print();

            list.InsertAtPosition(15, 2);
            list.Print();

            list.DeleteByValue(20);
            list.Print();

            Console.WriteLine("Middle: " + list.FindMiddle());

            list.Reverse();
            list.Print();

            Console.WriteLine("3rd from end: " + list.NthFromEnd(3));
        }
    }
}