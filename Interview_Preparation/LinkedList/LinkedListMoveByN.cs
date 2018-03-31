using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class LinkedListMoveByN
    {

        //Time complexity: O(n)
        // In ideal case, we needs two pointers 
        //1. keeps the kthnode reference, 
        //2. keeps the last node reference.
        // Thereafter steps:
            // Set Last.Next = head
            // Set head = KthNode.Next
            // Set kthNode.Next = null
        public static void MoveByN(int[] input, int moveByNode)
        {
            LinkedList<int> list = new LinkedList<int>();

            //LinkedList class in C# have Next and Previous property as readonly so can't set Next property in this case. 
            //So new result list is used.
            //Ideally custom LinkedList class is used if Next needs to be set.
            LinkedList<int> result = new LinkedList<int>();

            list.AddFirst(input[0]);
            for(int i = 1; i < input.Length; i++)
            {
                list.AddLast(input[i]);
            }

            LinkedListNode<int> head = list.First;
            LinkedListNode<int> current = list.First;

            int nodeCounter = 1;
            while (nodeCounter < moveByNode)
            {
                if (current != null)
                    current = current.Next;

                nodeCounter++;
            }

            LinkedListNode<int> kthNode = current;


            while (current.Next != null)
            {
                result.AddLast(new LinkedListNode<int>(current.Next.Value));
                current = current.Next;
            }


            while (head != null && head != kthNode.Next)
            {
                result.AddLast(new LinkedListNode<int>(head.Value));
                head = head.Next;
            }
            //current = head;
        }
    }
}
