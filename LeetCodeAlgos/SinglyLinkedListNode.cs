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

        public static SinglyLinkedListNode MergeTwoLists(SinglyLinkedListNode l1, SinglyLinkedListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return l1 ?? l2;
            }

            SinglyLinkedListNode head;
            if (l1.val < l2.val)
            {
                head = new SinglyLinkedListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                head = new SinglyLinkedListNode(l2.val);
                l2 = l2.next;
            }
            SinglyLinkedListNode current = head;

            while (l1 != null || l2 != null)
            {
                Console.WriteLine($"l1: {l1?.val} l2: {l2?.val}");
                if (l1 == null)
                {
                    head.next = l2;
                    return head;
                }
                else if (l2 == null)
                {
                    head.next = l1;
                    return head;
                }
                else
                {
                    if (l1.val < l2.val)
                    {
                        head.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        head.next = l2;
                        l2 = l2.next;
                    }
                }
                head = head.next;
            }

            return head;
        }
    
        public static SinglyLinkedListNode ReturnRandomLinkedList(int length = 4, int minRange = 0, int maxRange = 10)
        {
            if (length == 0) return null;
            length = length < 0 ? 4 : length;
            maxRange = length > maxRange ? length : maxRange;

            Random rand = new Random();
            SinglyLinkedListNode head = new SinglyLinkedListNode(rand.Next(minRange, maxRange));
            SinglyLinkedListNode cur = head;

            for (int i = 0; i < length - 1; i++)
            {
                cur.next = new SinglyLinkedListNode(rand.Next(minRange, maxRange));
                cur = cur.next;
            }

            return head;
        }







        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");

            SinglyLinkedListNode cur = this;
            while (cur != null)
            {
                sb.Append($"{cur.val} -> ");
                cur = cur.next;
            }

            sb.Append("null ]");
            return sb.ToString();
        }

        public string ToString(string delimeter = "->")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            SinglyLinkedListNode cur = this;
            while (cur != null)
            {
                sb.Append($"{cur.val}{delimeter}");
                cur = cur.next;
            }

            sb.Append("null]");
            return sb.ToString();
        }
    }
}
