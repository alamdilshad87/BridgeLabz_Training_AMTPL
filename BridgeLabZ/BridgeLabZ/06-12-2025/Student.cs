using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    public class Student
    {
        public int Roll;
        public string Name;
        public double Marks;

        public Student(int roll, string name, double marks)
        {
            this.Roll = roll;
            this.Name = name;
            this.Marks = marks;
        }

        public override string ToString()
        {
            return $"Roll: {Roll}, Name: {Name}, Marks: {Marks}";
        }
    }

    public class DoubleNode
    {
        public Student Data;
        public DoubleNode Prev;
        public DoubleNode Next;

        public DoubleNode(Student data)
        {
            this.Data = data;
            Prev = null;
            Next = null;
        }
    }

    public class DoublyLinkedList
    {
        public DoubleNode Head;

        public void InsertAtFront(Student s)
        {
            DoubleNode newNode = new DoubleNode(s);
            if (Head != null)
            {
                newNode.Next = Head;
                Head.Prev = newNode;
            }
            Head = newNode;
        }

        public void InsertAtEnd(Student s)
        {
            DoubleNode newNode = new DoubleNode(s);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            DoubleNode curr = Head;
            while (curr.Next != null)
                curr = curr.Next;
            curr.Next = newNode;
            newNode.Prev = curr;
        }

        public void DeleteByRoll(int roll)
        {
            if (Head == null)
                return;
            if (Head.Data.Roll == roll)
            {
                Head = Head.Next;
                if (Head != null)
                    Head.Prev = null;
                return;
            }
            DoubleNode curr = Head;
            while (curr != null && curr.Data.Roll != roll)
                curr = curr.Next;
            if (curr == null)
                return;
            if (curr.Next != null)
                curr.Next.Prev = curr.Prev;
            if (curr.Prev != null)
                curr.Prev.Next = curr.Next;
        }

        public void Print()
        {
            Console.WriteLine("\nStudents (Head -> Tail):");
            DoubleNode curr = Head;
            while (curr != null)
            {
                Console.WriteLine(curr.Data);
                curr = curr.Next;
            }
        }

        public void PrintReverse()
        {
            Console.WriteLine("\nStudents (Tail -> Head):");
            if (Head == null)
                return;
            DoubleNode curr = Head;
            while (curr.Next != null)
                curr = curr.Next;
            while (curr != null)
            {
                Console.WriteLine(curr.Data);
                curr = curr.Prev;
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.InsertAtFront(new Student(917, "Dilshad", 95));
            dll.InsertAtFront(new Student(929, "Sudipta", 89.8));
            dll.InsertAtEnd(new Student(919, "Om", 92.3));
            dll.InsertAtEnd(new Student(894, "Prajan", 88.7));

            dll.Print();
            dll.PrintReverse();

            Console.WriteLine("\nDeleting RollNo: 929...");
            dll.DeleteByRoll(929);

            dll.Print();
            dll.PrintReverse();
        }
    }
}
