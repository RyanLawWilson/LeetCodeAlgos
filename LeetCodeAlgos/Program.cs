using System;

namespace LeetCodeAlgos
{
    public class Program
    {
        public static void Main(string[] args)
        {



            //AreThesePeopleRelated();      // This is not a Leetcode question; it is a question that was given to Nicson in his Microsoft interview
            //MergeTwoLists();              // Leetcode problem
            Console.WriteLine();
        }







        private static void AreThesePeopleRelated()
        {
            Person[] searchForPeople = Genealogy.CreateGenealogyTree();
            Person person1 = searchForPeople[0];
            Person person2 = searchForPeople[1];

            Console.Write("Are these people related?: ");
            Console.WriteLine(Genealogy.AreThesePeopleRelated(person1, person2) ? "Yes" : "No");
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
