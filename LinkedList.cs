//Common Programs


using System.Collections.Immutable;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace console1
{
    class ArrayProblem
    {

        static void Main(String[] args)
        {
            //Linked List
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddLast(4);

            LinkedListNode<int> node = list.FindLast(2);
            list.AddAfter(node, 5);
            list.AddBefore(node, 6);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

    }
}