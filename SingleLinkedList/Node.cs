using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    /// <summary>
    /// This class lets you take create any type of Node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        //The value that will added to the linked list 
        public T Value { get; set; }
        //This is what connects the nodes
        public Node<T> Next { get; set; }
        
        //Constructor 
        public Node(T value)
        {
            Value = value;
            Next= null;
        }
    }
}
