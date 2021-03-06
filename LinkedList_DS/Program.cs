﻿using System;

namespace LinkedList_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Data Structure!");

            LinkedList linkedList = new LinkedList();

            linkedList.Add(56);
            linkedList.Add(70);

            linkedList.Display();

            linkedList.inserAt(2,30);

            linkedList.Display();

            linkedList.DeleteAtBeginning();

            linkedList.Display();

            linkedList.DeleteAtEnd();

            linkedList.Display();


            linkedList.Search(30);

            linkedList.inserAt(1, 56);

            linkedList.Add(40);

            linkedList.Add(70);

            linkedList.Display();

            linkedList.DeleteAfterElement(30);

            linkedList.Display();

            Console.WriteLine("Sorting Linked List.......");
            linkedList.head = linkedList.ListSort(linkedList.head);

            linkedList.Display();


        }
    }
}
