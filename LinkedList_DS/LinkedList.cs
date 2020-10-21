using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_DS
{
    public class LinkedList
    {
        internal Node head;

        internal LinkedList()
        {
            this.head = null;

        }

        internal void Add(int data)
        {
            Node node = new Node(data);


            if (this.head == null)
            {
                this.head = node;

            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {

                    temp = temp.next;
                }

                temp.next = node;


            }
            Console.WriteLine($"Data {node.data} is added to LinkedList");
        }


        internal void inserAt( int position, int data)
        {
            int count = GetCount();
            int currentPosition = 1;

            if (position == 0 || position > count)
            {
                Console.WriteLine($"Invalid Position!! Length of List is:{count}");
            }
            else
            {
                Node newNode = new Node(data);
                Node temp = head;
                Node previous = null;

                while (currentPosition++ < position)
                {
                    previous = temp;
                    temp = temp.next;
                }

                previous.next = newNode;

                newNode.next = temp;


                Console.WriteLine($"Data {newNode.data} is added to LinkedList at position {position}");

            }

        }

        internal void DeleteAtBeginning()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            head = temp.next;
            Console.WriteLine($"Deleted Element {temp.data} at Beginning");
        }

        internal void DeleteAtEnd()
        {
            Node temp = this.head;


            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (temp.next.next != null)
            {

                temp = temp.next;

            }
            Console.WriteLine($"Deleted Element {temp.next.data} at End");
            temp.next = null;

        }

        internal int GetCount()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                return count;
            }
            else
            {
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;
            }

        }


        internal void Display()
        {
            Console.WriteLine("\nLinked List Elements:");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine($"Data {temp.data}");
                    temp = temp.next;
                }
            }

            Console.WriteLine("\n");

        }

    }
}
