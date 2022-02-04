using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutre
{
    internal class LinkedList
    {
        public Node head;
        public void AddLast(int data)
        { 
            Node new_node = new Node(data);
            
            if(this.head == null)
            {
                this.head = new_node;   
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("{0} Node inserted into linked list", new_node);
        }

        public Node 
    }
}
