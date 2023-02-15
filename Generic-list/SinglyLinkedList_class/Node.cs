using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_LinkedList
{
    /// <summary>
    /// This is a Generic Node class for the Singly Linked List.
    /// It is being used by the Stack and Queue generic classes also;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {

        public T data;
        public Node<T> next;

        public Node()
        {
        }

        public Node(T d)
        {
            data = d;
            next = null;
        }

        public static implicit operator int(Node<T> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Node<T>(int v)
        {
            throw new NotImplementedException();
        }
    }
}
