using System;

namespace LeetCodeAlgos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list1 = SinglyLinkedListNode.ReturnRandomLinkedList();
            var list2 = SinglyLinkedListNode.ReturnRandomLinkedList();

            var result = SinglyLinkedListNode.MergeTwoLists(list1, list2);

            Console.WriteLine();
        }
    }
}
