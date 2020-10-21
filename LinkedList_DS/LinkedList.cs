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
