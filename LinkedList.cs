using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class LinkedList<T>
    {
        /// <summary>
        /// This is the first and Last Node that will be in my list
        /// </summary>
        public Node<T> headNode;
        public Node<T> lastNode;

        /// <summary>
        /// This is the default constructor 
        /// </summary>
        public LinkedList()
        {
            headNode = null;
            lastNode = null;
        }

        /// <summary>
        /// This adds node to the end of the list 
        /// </summary>
        /// <param name="value"></param>
        public void AddNodeToEnd(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (headNode == null)
            {
                headNode = newNode;
                lastNode = newNode;
            }
            else
            {
                lastNode.Next = newNode;
                lastNode = newNode;
            }

        }

        /// <summary>
        /// This add Node to beggining
        /// </summary>
        /// <param name="value"></param>
        public void AddNodeToBeggining(T value)
        {

        }

        /// <summary>
        /// TRhis deletes the node value
        /// </summary>
        public void DeleteNode(T value)
        {
            if (headNode == null)
            {
                Console.WriteLine("The list is empty");
            }


        }

        /// <summary>
        /// Find a certain value and returns T or F 
        /// </summary>
        /// <param name="value"></param>
        public bool FindNode(T value)
        {
            return true;
        }

        /// <summary>
        /// This prints out the whole list
        /// </summary>
        public void printList()
        {
            if (headNode == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            Node<T> number = headNode;
            Node<T> current = headNode;
            while (!(number == null))
            {
                Console.WriteLine(number.Value);
                current = number;
                number = current.Next;
            }
        }

        /// <summary>
        /// This functions converts Array to LinkedList 
        /// </summary>
        public void convertArraytoList()
        {

        }

    }
}
