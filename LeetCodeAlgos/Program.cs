using System;

namespace LeetCodeAlgos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person[] searchForPeople = Genealogy.CreateGenealogyTree();
            Person person1 = searchForPeople[0];
            Person person2 = searchForPeople[1];

            Console.WriteLine(Genealogy.AreThesePeopleRelated(person1, person2) ? "Yes" : "No");

            //MergeTwoLists();
            Console.WriteLine();
        }

        private static void MergeTwoLists()
        {
            var list1 = SinglyLinkedListNode.ReturnRandomLinkedList();
            var list2 = SinglyLinkedListNode.ReturnRandomLinkedList();

            Console.WriteLine($"List 1: {list1}\nList 2: {list2}\n");

            var result = SinglyLinkedListNode.MergeTwoLists(list1, list2);

            Console.WriteLine($"Final result: {result}");
        }
    }
}
