using Singly_LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGenericClass
{
    
    // This is a generic stack class.
    
    public class StackClass<T>
    {
        internal Node<T> head;
        internal int count = 0;

        Node<T> myStack = new Node<T>();


        // This method returns true if the stack is empty and false is it isn’t 

        public bool StackIsEmpty()
        {
            return count == 0;
        }


        // This method adds an item to the tail of the stack 

        public void StackPush(T data)
        {
            Node<T> itemToPush = new Node<T>(data);
            itemToPush.next = head;
            head = itemToPush;
            count++;
        }

        
        // This method removes and returns the last item added to the stack 
        
        public T StackPop()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                return default;
            }
            else
            {
                head = temp.next;
                count--;
            }

            return temp.data;
            
        }


        
        // This method returns the last item added to the stack.
        
        public T StackPeep()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                return default;
            }
            else
            {
                head = temp.next;
                
            }

            return temp.data;
        }

        
        // This method will return the size/number of items in the stack;
        
        public int StackSize()
        {
            return count;
        }
        
      
        }
    }
}
