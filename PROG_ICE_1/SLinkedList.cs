// Tyler Jagdew
// ST10117021
// ICE TASK 1

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_ICE_1
{
    [DebuggerDisplay("Count={Count}")]
    public class SLinkedList<T>
    {
        // Fields
        private int counter;
        private SLinkedListNode<T> start;
        private SLinkedListNode<T> end;
        private int resetter;

        //  new instance of the SLinkedList(T) 
        public SLinkedList()
        {

        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        //Adds the items to the end
        public SLinkedList(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                AddToEnd(item);
            }
        }

        //Adds the value to SLinkedList after node.
        public SLinkedListNode<T> AddAfter(SLinkedListNode<T> node, T value)
        {
            SLinkedListNode<T> nextNode = new SLinkedListNode<T>(this, value);

            AddAfter(node, nextNode);

            return nextNode;
        }
        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Adds the nextNode to SLinkedList after node.
        public void AddAfter(SLinkedListNode<T> node, SLinkedListNode<T> nextNode)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (nextNode == null)
            {
                throw new ArgumentNullException("nextNode");
            }

            if (node.Owner != this)
            {
                throw new InvalidOperationException("node is not owned by this list");
            }

            if (nextNode.Owner != this)
            {
                throw new InvalidOperationException("nextNode is not owned by this list");
            }

            // The added node becomes the end
            if (end == node)
            {
                end = nextNode;
            }

            nextNode.Next = node.Next;
            node.Next = nextNode;

            ++counter;
            ++resetter;
        }

        
        // Adds the value to SLinkedList before node.
        public SLinkedListNode<T> AddBefore(SLinkedListNode<T> node, T value)
        {
            SLinkedListNode<T> nextNode = new SLinkedListNode<T>(this, value);

            AddBefore(node, nextNode);

            return nextNode;
        }
        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Adds the nextNode to SLinkedList before the node.
        public void AddBefore(SLinkedListNode<T> node, SLinkedListNode<T> nextNode)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (nextNode == null)
            {
                throw new ArgumentNullException("nextNode");
            }

            if (node.Owner != this)
            {
                throw new InvalidOperationException("node is not owned by this list");
            }

            if (nextNode.Owner != this)
            {
                throw new InvalidOperationException("nextNode is not owned by this list");
            }

            if (start == node)
            {
                nextNode.Next = start;
                start = nextNode;
            }
            else
            {
                SLinkedListNode<T> beforeNode = start;

                while (beforeNode != null && beforeNode.Next != node)
                {
                    beforeNode = beforeNode.Next;
                }

                if (beforeNode == null)
                {
                    throw new InvalidOperationException("something went wrong");
                }

                nextNode.Next = node;
                beforeNode.Next = nextNode;
            }
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Chandrasen Singh
        // YEAR: 2016
        // WEBSITE: https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp

        // Adds the value to the start of SLinkedList.
        public SLinkedListNode<T> AddToBeginning(T value)
        {
            SLinkedListNode<T> nextNode = new SLinkedListNode<T>(this, value);

            if (IsEmpty)
            {
                start = nextNode;
                end = nextNode;
            }
            else
            {
                nextNode.Next = start;
                start = nextNode;
            }

            ++counter;
            ++resetter;

            return nextNode;
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Adds the value to the end of the SLinkedList.
        public SLinkedListNode<T> AddToEnd(T value)
        {
            SLinkedListNode<T> nextNode = new SLinkedListNode<T>(this, value);

            if (IsEmpty)
            {
                start = nextNode;
                end = nextNode;
            }
            else
            {
                end.Next = nextNode;
                end = nextNode;
            }

            ++counter;
            ++resetter;

            return nextNode;
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Removes all items from the SLinkedList.

        public void Clear()
        {
            SLinkedListNode<T> tmp;

            // Clean up the items in the list
            for (SLinkedListNode<T> node = start; node != null;)
            {
                tmp = node.Next;

                // Change the counter and start pointer 
                start = tmp;
                --counter;

                // clear the contents
                node.Next = null;
                node.Owner = null;

                // Move to the next node
                node = tmp;
            }

            if (counter <= 0)
            {
                start = null;
                end = null;
            }

            ++resetter;
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Chandrasen Singh
        // YEAR: 2016
        // WEBSITE: https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp

        // Checks if data is present in SLinkedList.
        public bool Contains(T data)
        {
            return Find(data) != null;
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Locates the node that contains the specified data.
        public SLinkedListNode<T> Find(T data)
        {
            if (IsEmpty)
            {
                return null;
            }

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            // Traverse the list from the start to end.
            for (SLinkedListNode<T> curr = Head; curr != null; curr = curr.Next)
            {
              
                if (comparer.Equals(curr.Data, data))
                {
                    return curr;
                }
            }

            return null;
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Removes the first state of the items from the SLinkedList.
        public bool Remove(T item)
        {
            return Remove(item, false);
        }

        
        public void Remove(SLinkedListNode<T> node)
        {
            if (IsEmpty)
            {
                return;
            }

            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Owner != this)
            {
                throw new InvalidOperationException("The node doesn't belong to this list.");
            }

            SLinkedListNode<T> prev = null;
            SLinkedListNode<T> curr = Head;

            // Find the node located before the specified node.
            while (curr != null && curr != node)
            {
                prev = curr;
                curr = curr.Next;
            }

            // The node has been found
            if (curr == node)
            {
                // Assign the start to the next node 
                if (start == node)
                {
                    start = node.Next;
                }

                // Assign the end to the previous node
                if (end == node)
                {
                    end = prev;
                }

                // Set the previous node 
                if (prev != null)
                {
                    prev.Next = curr.Next;
                }

                // Null output 
                node.Next = null;
                node.Owner = null;

                --counter;
                ++resetter;
            }
        }

       
        public bool Remove(T item, bool allOccurences)
        {
            if (IsEmpty)
            {
                return false;
            }

            SLinkedListNode<T> prev = null;
            SLinkedListNode<T> curr = Head;
            bool removed = false;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            // ___CODE ATTRIBUTION___
            // AUTHOR: Ankit Sharma
            // YEAR: 2019
            // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

            // Start traversing the list at the head
            while (curr != null)
            {
                // Check to see if the current node contains the data we are trying to delete
                if (!comparer.Equals(curr.Data, item))
                {
                    // Assign the current node to the previous node and the previous node to the current node
                    prev = curr;
                    curr = curr.Next;
                    continue;
                }

                // Create a pointer to the next node in the previous node
                if (prev != null)
                {
                    prev.Next = curr.Next;
                }

                if (curr == Head)
                {
                    Head = curr.Next;
                }

                if (curr == Tail)
                {
                    Tail = prev;
                }

                // ___CODE ATTRIBUTION___
                // AUTHOR: Chandrasen Singh
                // YEAR: 2016
                // WEBSITE: https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp

                // Save the pointer for clean up later
                SLinkedListNode<T> tmp = curr;

                // move the current to the next node
                curr = curr.Next;

               
                tmp.Next = null;
                tmp.Owner = null;

                // stop the counter when node removed
                --counter;

                removed = true;

                if (!allOccurences)
                {
                    break;
                }
            }

            if (removed)
            {
                ++resetter;
            }

            return removed;
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Chandrasen Singh
        // YEAR: 2016
        // WEBSITE: https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp

        public T[] ToArray()
        {
            T[] retVal = new T[counter];

            int index = 0;
            for (SLinkedListNode<T> i = Head; i != null; i = i.Next)
            {
                retVal[index] = i.Data;
                ++index;
            }

            return retVal;
        }

       
        public int Count
        {
            get { return counter; }
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Gets the start node in the SLinkedList.
        public SLinkedListNode<T> Head
        {
            get { return start; }
            private set { start = value; }
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // States if the SLinkedList is empty.
        public bool IsEmpty
        {
            get { return counter <= 0; }
        }
        // ___CODE ATTRIBUTION___
        // AUTHOR: Chandrasen Singh
        // YEAR: 2016
        // WEBSITE: https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp

        // Gets the end node in the SLinkedList.
        public SLinkedListNode<T> Tail
        {
            get { return end; }
            private set { end = value; }
        }
    }
}
