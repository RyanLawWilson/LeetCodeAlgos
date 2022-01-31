using System;
using System.Collections.Generic;
using System.Text;

class PalindromeTester
{
    public int num { get; set; }

    public PalindromeTester(int n)
    {
        num = n;
    }

    public bool IsPalindrome()
    {

        Console.WriteLine($"What is 1 / 10?: {1 / 10}");
        int n = num;


        for (int i = 1000000000; i > 0; i /= 10)
        {
            // Left to Right
            Console.WriteLine($"i value: {i}\nDivision {n} / {i}: {n / i} | Remainder {n} % {i}: {n % i}\n");
            n = num % i;


            // Console.WriteLine($"i value: {i}\nDivision {n} / {i}: {n / i} | Remainder {n} % {i}: {n % i}\n");
        }

        return false;
    }
}
