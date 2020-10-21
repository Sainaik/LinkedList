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
            

            if (position == 0 || position > count)
            {
                Console.WriteLine($"Invalid Position!! Length of List is:{count}");
            }
            if(position == 1 )
            {
                Node newNode = new Node(data);
                Node temp = this.head;
                newNode.next = temp;
                this.head = newNode;
                Console.WriteLine($"Data {newNode.data} is added to LinkedList at position {position}");

            }
            else
            {
                int currentPosition = 1;
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

        internal void DeleteAtPosition(int position)
        {
            int count = GetCount();
            int currentPosition = 1;

            if (position == 0 || position > count)
            {
                Console.WriteLine($"Invalid Position!! Length of List is:{count}");
            }
            else if (position == 1)
            {
                this.DeleteAtBeginning();
            }
            else if (position == count)
            {
                this.DeleteAtEnd();
            }
            else
            {
                Node temp = head;
                Node previous = null;

                while (currentPosition++ < position)
                {
                    previous = temp;
                    temp = temp.next;
                }

                Console.WriteLine($"Deleted Element {temp.data} at position {position}");

                previous.next = temp.next;

            }

        }

        internal void DeleteAfterElement(int data)
        {
            int position = this.Search(data);
            this.DeleteAtPosition((position + 1));
        }

        internal int Search(int data)
        {
            Console.WriteLine("Searching .......");

            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            else
            {
                int nodeNumber = 1;
                bool isfound = false;
                while (temp != null)
                {
                    if ((temp.data == data))
                    {
                        isfound = true;
                        break;
                    }
                    nodeNumber++;
                    temp = temp.next;
                }
                if (isfound == true)
                {
                    Console.WriteLine($"Data element {data} is found in Node {nodeNumber}");
                    return nodeNumber;
                }
                else
                {
                    Console.WriteLine($"Data element {data} is NOT found");
                    return 0;
                }
            }
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


        internal Node ListSort(Node head)
        {
           

            if (head == null || head.next == null)
            {
                return head;
            }

            Node temp = head;

            Node slow = head;

            Node fast = head;

            while (fast != null && fast.next != null)
            {
                temp = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            temp.next = null;


            Node leftSide = ListSort(head);
            Node rightSide = ListSort(slow);


            return Merge(leftSide, rightSide);
        }

        internal Node Merge(Node l1, Node l2)
        {
            Node sorted_temp = new Node();
            Node current_node = sorted_temp;

            while (l1 != null && l2 != null)
            {
                if (l1.data < l2.data)
                {
                    current_node.next = l1;

                    l1 = l1.next;
                }
                else
                {
                    current_node.next = l2;

                    l2 = l2.next;
                }
                current_node = current_node.next;
            }

            if (l1 != null)
            {
                current_node.next = l1;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                current_node.next = l2;
                l2 = l2.next;
            }

            return sorted_temp.next;
        }


    }
}
