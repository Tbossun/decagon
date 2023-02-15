using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Class
{
    // The generic class for queue
     
    public class QueueClass<T>
    {
        public Node<T> front;
        public Node<T> back;
        public int count = 0;


       
       
        // This is the IsEmpty method
        //This method returns true if the queue is empty and false otherwise

        public bool IsEmpty()
        {
            return count == 0;
        }

        
        
        //Enqueue method
        //This method add an new item to the back of the queue
        
        public void EnQueue(T data)
        {

            Node<T> myQueue = new Node<T>(data);

            if (head == null)
            {
                head = myQueue;
            }
            else
            {
                current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = myQueue;
            }
            count++;
        }


        
        // Dequeue method
        // This method remove and then returns the item at the front of the queue

        public T DeQueue()
        {
            if (head == null)
            {
                return default;
            }
            Node<T> temp = head;
            if (count > 0)
            {
                head = temp.next;
                count--;
            }
            
            return temp.data;
        }

        
        // QueueSize Method
        // This method returns the size of the queue
        
        public int QueueSize()
        {
            return count;
        }

       
        }
    }
}
