using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2020_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"input.txt");

            Dictionary<int, int> found = new Dictionary<int, int>();//index, value -> find num with lowest index

            for(int i = 0; i < input.Length; i++)
            {
                if(i > 4)
                {
                    Console.WriteLine(i);

                    List<int> prae = new List<int>();
                    int pc = i - 5;
                    for (int pi = 0; pi < 5; pi++)
                    {
                        prae.Add(Convert.ToInt32(input[pc]));
                        foreach (var p in prae)
                        {
                            //Console.WriteLine("Präämbel: " + p);
                        }
                        pc++;
                    }
                    //filled prae
                    int curr = i;
                    foreach (int p in prae)
                    {
                        int first = p;
                        for (int j = 0;j<prae.Count; j++)
                        {
                            first + j
                        }
                    }
                }
            }
        }
    }
}
