using System;
using System.Text;

namespace LeetCodeAlgos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            





















            //RestoreString("codeleet", new int[] { 4,5,6,7,0,2,1,3 });
            //AddBinaryNumbers();           
            //GetLengthOfLastWord();        // Leetcode problem for our Sunday meeting on 1/30/2022: https://leetcode.com/problems/length-of-last-word/
            //IsIntegerAPalindrome();       // Leetcode problem for our Sunday meeting on 1/30/2022: https://leetcode.com/problems/palindrome-number/
            //IsTreeHeightBalanced();       // Leetcode problem for our Sunday meeting on 1/23/2022: https://leetcode.com/problems/balanced-binary-tree/
            //FindSingleNumberInArray();    // Leetcode problem for our Sunday meeting on 1/23/2022: https://leetcode.com/problems/single-number/
            //PerformMinStackOperations();  // Leetcode problem for our Sunday meeting on 1/23/2022: https://leetcode.com/problems/min-stack/
            //AreThesePeopleRelated();      // This is not a Leetcode question; it is a question that was given to Nicson in his Microsoft interview
            //MergeTwoLists();              // Leetcode problem
            Console.WriteLine();
        }

        private static string RestoreString(string s, int[] indices)
        {
            char[] res = new char[s.Length];

            //StringBuilder result = new StringBuilder();
            for (int i = 0; i < indices.Length; i++)
            {
                res[indices[i]] = s[i];
            }

            return new string(res);
        }

        private static void AddBinaryNumbers()
        {
            string a = "111011";
            string b = "1010";

            int aLength = a.Length;
            int bLength = b.Length;

            if (aLength > bLength)
            {
                b = new string('0', aLength - bLength) + b;
            }
            else
            {
                a = new string('0', bLength - aLength) + a;
            }

            StringBuilder answer = new StringBuilder("");
            int carry = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int decimalSum = (int)char.GetNumericValue(a[i]) + (int)char.GetNumericValue(b[i]) + carry;

                switch (decimalSum)
                {
                    case 0:
                        carry = 0;
                        answer.Append("0");
                        break;
                    case 1:
                        carry = 0;
                        answer.Append("1");
                        break;
                    case 2:
                        carry = 1;
                        answer.Append("0");
                        break;
                    case 3:
                        carry = 1;
                        answer.Append("1");
                        break;
                }
            }
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
