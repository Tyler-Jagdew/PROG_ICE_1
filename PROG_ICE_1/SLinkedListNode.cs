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
    [DebuggerDisplay("Data={Data}")]
    public class SLinkedListNode<T>
    {
        SLinkedList<T> point;
        SLinkedListNode<T> nextset;
        T dataset;

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Initializes a new instance of the SLinkedList with the data.
        public SLinkedListNode(T data)
        {
            dataset = data;
        }
        // ___CODE ATTRIBUTION___
        // AUTHOR: Chandrasen Singh
        // YEAR: 2016
        // WEBSITE: https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp

        // Initializes a new instance of the SLinkedList class with the data .
        internal SLinkedListNode(SLinkedList<T> owner, T data)
        {
            dataset = data;
            point = owner;
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Returns the next node.
        public SLinkedListNode<T> Next
        {
            get { return nextset; }
            internal set { nextset = value; }
        }
        // ___CODE ATTRIBUTION___
        // AUTHOR: Chandrasen Singh
        // YEAR: 2016
        // WEBSITE: https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp

        // Gets or sets the point of the node
        internal SLinkedList<T> Owner
        {
            get { return point; }
            set { point = value; }
        }

        // ___CODE ATTRIBUTION___
        // AUTHOR: Ankit Sharma
        // YEAR: 2019
        // WEBSITE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        // Gets the data in the node
        public T Data
        {
            get { return dataset; }
            internal set { dataset = value; }
        }
    }
}
