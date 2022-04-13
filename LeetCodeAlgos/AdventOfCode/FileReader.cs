using System;
using System.Collections.Generic;
using System.Text;

public class FileReader
{
    private static readonly string FILEPATH = @"D:\Users\Ryan Wilson\Projects\LeetCodeAlgos\LeetCodeAlgos\AdventOfCode\";
    public string filename { get; set; }

    public FileReader(string filename)
    {
        this.filename = filename;
    }

    public static string ReadFile(string filename)
    {
        return System.IO.File.ReadAllText(FILEPATH + filename);
    }
}