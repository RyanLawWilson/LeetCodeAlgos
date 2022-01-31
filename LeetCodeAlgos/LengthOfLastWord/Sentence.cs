using System;
using System.Collections.Generic;
using System.Text;

// Sentences should have real words with any number of spaces before or after the word.
class Sentence
{
    public string sentence { get; set; }

    public Sentence(string s)
    {
        sentence = s;
    }

    public int LengthOfLastWord()
    {
        string[] words = sentence.TrimEnd().Split(" ");
        return words[words.Length - 1].Length;
    }
}

