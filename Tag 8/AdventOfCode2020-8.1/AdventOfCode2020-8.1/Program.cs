using System;
using System.Collections.Generic;

namespace AdventOfCode2020_8._1
{
    class Program
    {
        public static void performJump(int v, int old)
        {

        }
        public static int changeAcc(int v)
        {
            Console.WriteLine("v: {0}", v);
            int value = v;
            return value;
        }
        static void Main(string[] args)
        {
            string instructions = System.IO.File.ReadAllText("input.txt");
            string[] stepsArr = instructions.Split("\n");

            List<string[]> steps = new List<string[]>();

            foreach (var s in stepsArr)
            {
                var temp = s;
                temp = temp.Replace("\r","");
                steps.Add(temp.Split(" "));
                Console.WriteLine(s);
            }
            int i = 0, accu = 0;
            foreach (var s in steps)
            {
                switch (s[0])
                {
                    case "acc": //change value
                        accu = changeAcc(Convert.ToInt32(s[1]));
                        break;
                    case "jmp":
                        performJump(Convert.ToInt32(s[1]), i);
                        break;
                    case "nop":
                        break;
                }
                i++;
            }
        }
    }
}
