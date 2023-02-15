

namespace SinglyLinkedList
{
    //Generic singlyLinkList 

    public class SinglyLinkedLists<T>
    {
        Node<T> singlyLinkedList = new Node<T>();

        internal Node<T> head;
        internal Node<T> previous;
        internal Node<T> current;
        internal int numberOfNodes = 0;

        public SinglyLinkedLists()
        {
            head = null;
            previous = null;
            current = null;
        }


        
        // This method adds to the tail of my list.

        public void AddToTail(T data)

        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            numberOfNodes++;
        }

        // This method removes an item from the list.
        
        public void RemoveNode(T data)
        {
            Node<T> nodeToRemove = new Node<T>(data);
            current = head;

            if (head.data.Equals(nodeToRemove.data))
            {
                current = head.next;
                head = current;
            }
            else
            {
                while (current != null)
                {
                    if (current.data.Equals(nodeToRemove.data))
                    {
                        previous.next = current.next;
                        current = previous;
                    }
                    else
                    {
                        previous = current;
                        current = current.next;
                    }
                }
            }
            numberOfNodes--;
        }

      
        // This method checks the Number of Items in the list.
   
        public int ListSize()
        {
            return numberOfNodes;
        }



        //This method checks for a specified item in the list and return true if found or false otherwise 

        public bool Check(T data)
        {
           Node<T> current = head;
            while (current != null) 
            {
                if (current.Data.Equals(items)) 
                { 
                    return true;
                }
                current = current.next;
            }
            return false;
        }

      
        // This method checks if an item is in the list.
        // It will return a boolean based on it check on the list.
  
        public bool InList(T data)
        {
            Node<T> nodeToLookFor = new Node<T>(data);
            Node<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(nodeToLookFor.data))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
       
    }
}
