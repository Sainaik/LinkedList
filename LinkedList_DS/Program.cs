using System;

namespace LinkedList_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Data Structure!");

            LinkedList linkedList = new LinkedList();

            linkedList.Add(56);


            linkedList.Add(30);


            linkedList.Add(70);

            linkedList.Display();
        }
    }
}
