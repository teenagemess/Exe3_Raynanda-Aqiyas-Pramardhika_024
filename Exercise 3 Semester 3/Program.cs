﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Semester_3
{
    class Node
    {
        //creates Nodes fo the circular nexted list
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CircularList
    {
        Node LAST;
        
        public CircularList()
        {
            LAST = null;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        //Searches for the specified node
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true); //returns true if the node is found
            }
            if (rollNo == LAST.rollNumber) // if the node is present at the end
                return true;
            else
                return (false); //returns false if the node is not found
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }

        public void traverse()//Traverses all the nodes of the list
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are: \n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "   " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + "    " + LAST.name + "\n");
            }
        }
       public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe first record in the list is:\n\n " + LAST.next.rollNumber + "   " + LAST.next.name);
        }
            
    }
        
}
