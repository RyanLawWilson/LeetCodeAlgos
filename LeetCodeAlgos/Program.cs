﻿using System;

namespace LeetCodeAlgos
{
    public class Program
    {
        public static void Main(string[] args)
        {

            GetLengthOfLastWord();



            //Console.WriteLine($"1^2: {1 ^ 2}");
            //Console.WriteLine($"2^1: {2 ^ 1}");
            //Console.WriteLine($"1^1: {1 ^ 1}");
            //Console.WriteLine($"2^2: {2 ^ 2}");

            //GetLengthOfLastWord();        // Leetcode problem for our Sunday meeting on 1/30/2022: https://leetcode.com/problems/length-of-last-word/
            //IsIntegerAPalindrome();       // Leetcode problem for our Sunday meeting on 1/30/2022: https://leetcode.com/problems/palindrome-number/
            //IsTreeHeightBalanced();       // Leetcode problem for our Sunday meeting on 1/23/2022: https://leetcode.com/problems/balanced-binary-tree/
            //FindSingleNumberInArray();    // Leetcode problem for our Sunday meeting on 1/23/2022: https://leetcode.com/problems/single-number/
            //PerformMinStackOperations();  // Leetcode problem for our Sunday meeting on 1/23/2022: https://leetcode.com/problems/min-stack/
            //AreThesePeopleRelated();      // This is not a Leetcode question; it is a question that was given to Nicson in his Microsoft interview
            //MergeTwoLists();              // Leetcode problem
            Console.WriteLine();
        }


        private static void GetLengthOfLastWord()
        {
            Sentence s = new Sentence("       Hello     World  adf a a a a a aa dfadsf asdf asdfasdfasdfa s  ");

            Console.WriteLine($"Sentence: {s.sentence}\nLength of last word: {s.LengthOfLastWord()}\n");
        }

        private static void IsIntegerAPalindrome()
        {
            PalindromeTester pal = new PalindromeTester(123454321);

            pal.IsPalindrome();

        }

        private static void PerformMinStackOperations()
        {
            Console.WriteLine("Minimum Stack");

            int valueRange_min = -10;   // Exclusive upper bound
            int valueRange_max = 100;
            int numberOfOperations = 10;

            string[] possibleOperations = new string[] { "Push", "Pop", "Top", "GetMin" };

            Random rand = new Random();

            MinStack minstack = new MinStack();

            // Perform random operations on the min stack.
            for (int i = 0; i < numberOfOperations; i++)
            {
                string op = possibleOperations[rand.Next(0, possibleOperations.Length)];
                switch (op)
                {
                    case "Push":
                        int randNum = rand.Next(valueRange_min, valueRange_max);
                        Console.WriteLine($"Pushing {randNum}");
                        minstack.Push(randNum);
                        break;
                    case "Pop":
                        Console.WriteLine($"Popping from stack");
                        minstack.Pop();
                        break;
                    case "Top":
                        Console.WriteLine($"Stack's top value is {minstack.Top()}");
                        break;
                    case "GetMin":
                        Console.WriteLine($"Stack's min value is {minstack.GetMin()}");
                        break;
                }
            }
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
