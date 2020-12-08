using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ansStr = System.IO.File.ReadAllText("input.txt");

            ansStr = ansStr.Replace("\r", "");
            string[] ans = ansStr.Split("\n\n");
            List<int> persons = new List<int>();
            int i = 0;
            foreach(var a in ans)
            {
                persons.Add(a.Split('\n').Length);
                ans[i] = a.Replace("\n", "");
                i++;
            }
            int total1 = 0, total2 = 0;

            char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            i = 0;
            foreach (var a in ans)
            {
                int amnt = 0, amnt2 = 0;
                
                foreach(var c in abc)
                {
                    if (a.Count(f => f == c) > 0)
                    {
                        amnt++;
                        if (a.Count(f => f == c) == persons[i])
                        {
                            amnt2++;
                        }
                    }
                    
                }
                i++;
                Console.WriteLine(a + ": " + amnt);
                total1 = total1 + amnt;
                total2 = total2 + amnt2;
            }
            Console.WriteLine("Task1-Total: " + total1);
            Console.WriteLine("Task2-Total: " + total2);
        }
    }
}
