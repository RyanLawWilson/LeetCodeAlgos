using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAlgos
{
    public class SinglyLinkedListNode
    {
        public int val;
        public SinglyLinkedListNode next;
        public SinglyLinkedListNode(int val = 0, SinglyLinkedListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        /// <summary>
        /// Merge two linked lists into a single linked list.  Problem is from LeetCode
        /// Linked Lists can be created by the ReturnRandomLinkedList method.
        /// </summary>
        /// <link>https://leetcode.com/explore/interview/card/top-interview-questions-easy/93/linked-list/771/</link>
        /// <see cref="ReturnRandomLinkedList"/>
        /// <param name="l1">Sorted linked list</param>
        /// <param name="l2">Sorted linked list</param>
        /// <returns>Merged sorted linked list</returns>
        public static SinglyLinkedListNode MergeTwoLists(SinglyLinkedListNode l1, SinglyLinkedListNode l2)
        {
            if (l1 == null || l2 == null) return l1 ?? l2;

            SinglyLinkedListNode head = l1.val <= l2.val ? l1 : l2;
            SinglyLinkedListNode current = head;
            SinglyLinkedListNode l1PlaceHolder = head == l1 ? l1.next : l1;
            SinglyLinkedListNode l2PlaceHolder = head == l2 ? l2.next : l2;

            Console.WriteLine($"Head before iterating: {head}\n");

            // If one of the pointers is null, stop looping.
            while (l1PlaceHolder != null && l2PlaceHolder != null)
            {
                // Determine which value is smaller between pointer 1 and pointer 2.  current.next is set to
                // the node that has the smaller value.  That node then goes to the next node in its
                // respective linked list.
                if (l1PlaceHolder.val <= l2PlaceHolder.val)
                {
                    Console.WriteLine($"l1PlaceHolder value is smaller: {l1PlaceHolder.val} <= {l2PlaceHolder.val}");
                    if (current.next == l1PlaceHolder)
                        Console.WriteLine("No new node added to the list");

                    current.next = l1PlaceHolder;
                    l1PlaceHolder = l1PlaceHolder.next;
                    
                    Console.WriteLine($"List so far: {head}\n");
                }
                else
                {
                    Console.WriteLine($"l2PlaceHolder value is smaller: {l1PlaceHolder.val} > {l2PlaceHolder.val}");
                    if (current.next == l2PlaceHolder)
                        Console.WriteLine("No new node added to the list");

                    current.next = l2PlaceHolder;
                    l2PlaceHolder = l2PlaceHolder.next;
                    Console.WriteLine($"List so far: {head}\n");
                }

                current = current.next;
            }

            Console.WriteLine("One of the pointers is null so put the remaining nodes on the end.\n");
            // Find the pointer that is not null and set current.next to that node.
            current.next = l2PlaceHolder ?? l1PlaceHolder;

            return head;
        }
    
        /// <summary>
        /// Returns a node for a singly-linked list of a certain length.  The list is sorted in ascending order.
        /// </summary>
        /// <param name="length">The length of the list (number of nodes)</param>
        /// <param name="minRange">The smallest value a node can have</param>
        /// <param name="maxRange">The largest value a node can have</param>
        /// <returns>A linked list node that represents a sorted lined list</returns>
        public static SinglyLinkedListNode ReturnRandomLinkedList(int length = 4, int minRange = 0, int maxRange = 20)
        {
            if (length == 0) return null;
            length = length < 0 ? 4 : length;
            maxRange = length > maxRange ? length : maxRange;

            Random rand = new Random();
            SinglyLinkedListNode head = new SinglyLinkedListNode(rand.Next(minRange, maxRange));
            SinglyLinkedListNode cur = head;

            for (int i = 0; i < length - 1; i++)
            {
                cur.next = new SinglyLinkedListNode(rand.Next(cur.val, maxRange));
                cur = cur.next;
            }

            return head;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            SinglyLinkedListNode cur = this;
            while (cur != null)
            {
                sb.Append(string.Format("{0,2}{1}", cur.val, " -> "));
                cur = cur.next;
            }

            sb.Append("null ]");
            return sb.ToString();
        }

        public string ToString(string delimeter = " -> ")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            SinglyLinkedListNode cur = this;
            while (cur != null)
            {
                sb.Append(string.Format("{0,2}{1}", cur.val, delimeter));
                cur = cur.next;
            }

            sb.Append("null ]");
            return sb.ToString();
        }
    }
}
