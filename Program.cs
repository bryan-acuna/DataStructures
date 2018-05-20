using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList1;

namespace LinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddNodeToEnd(12);
            list1.AddNodeToEnd(13);
            list1.AddNodeToEnd(15);
            list1.AddNodeToEnd(17);
            list1.AddNodeToEnd(18);
            list1.AddNodeToEnd(10);
            list1.printList();
            list1.DeleteNode();





            Console.ReadKey();
        }
    }
}
