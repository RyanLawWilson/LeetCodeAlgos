using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAlgos
{
    public static class Tools
    {
        public static string GetRandomName()
        {
            Random rand = new Random();
            string[] names = new string[] {
                "Brenton","Mcmillan","Tiana","Houston","Camren","Melton","Kayley","Peterson","Skyla","Poole"
            };
            return names[rand.Next(0, names.Length)] + " " + names[rand.Next(0, names.Length)];
        }
    }
}
