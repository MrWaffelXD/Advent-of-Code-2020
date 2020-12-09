using System;
using System.Collections.Generic;

namespace AdventOfCode2020_8._1
{
    class Program
    {
        public static int performJump(int v, int old)
        {
            int value = old + v;
            Console.WriteLine("Jump to {0}", value - 1);
            return value -1;
        }
        public static int changeAcc(int v, int accu)
        {
            
            int value = accu + v;
            Console.WriteLine("New Accu: {0}", value);
            return value;
        }
        static void task1()
        {
            string instructions = System.IO.File.ReadAllText("input.txt");
            string[] stepsArr = instructions.Split("\n");

            List<string[]> steps = new List<string[]>();
            List<int> doneSteps = new List<int>();

            Console.WriteLine("Instruction set:");
            foreach (var s in stepsArr)
            {
                var temp = s;
                temp = temp.Replace("\r", "");
                steps.Add(temp.Split(" "));
                Console.WriteLine(s);
            }
            int i = 0, accu = 0;
            for (int s = 0; s < steps.Count;)
            {
                if (!doneSteps.Contains(s))
                {
                    doneSteps.Add(s);
                    switch (steps[s][0])
                    {
                        case "acc": //change value
                            accu = changeAcc(Convert.ToInt32(steps[s][1]), accu);
                            s++;
                            break;
                        case "jmp":
                            s = performJump(Convert.ToInt32(steps[s][1]), s);
                            s++;
                            break;
                        case "nop":
                            s++;
                            break;
                    }
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("Done");
            Console.WriteLine("Accumulator: {0}", accu);
        }
        static void task2()
        {
            string instructions = System.IO.File.ReadAllText("input.txt");
            string[] stepsArr = instructions.Split("\n");

            List<string[]> steps = new List<string[]>();
            List<int> doneSteps = new List<int>();
            List<int> switchedSteps = new List<int>();

            Console.WriteLine("Instruction set:");
            foreach (var st in stepsArr)
            {
                var temp = st;
                temp = temp.Replace("\r", "");
                steps.Add(temp.Split(" "));
                Console.WriteLine(st);
            }
            int s = 0, accu = 0;
            bool ended = false;
            while (!ended)
            {
                bool switched = false;//reset only on new try
                if (!doneSteps.Contains(s))
                {
                    doneSteps.Add(s);
                    switch (steps[s][0])
                    {
                        case "acc": //change value
                            accu = changeAcc(Convert.ToInt32(steps[s][1]), accu);
                            s++;
                            break;
                        case "jmp":
                            if (!switchedSteps.Contains(s) && !switched)
                            {
                                Console.WriteLine("Changed jmp to nop");
                                switched = true;
                                switchedSteps.Add(s);
                                s++;
                                break;
                            }
                            else
                            {
                                s = performJump(Convert.ToInt32(steps[s][1]), s);
                                s++;
                                break;
                            }
                        case "nop":
                            if (!switchedSteps.Contains(s) && !switched)
                            {
                                Console.WriteLine("Changed nop to jmp");
                                s = performJump(Convert.ToInt32(steps[s][1]), s);
                                s++;
                                break;
                            }
                            else
                            {
                                s++;
                                break;
                            }
                    }
                }
                else
                {
                    //ended = false;
                }

            }
            Console.WriteLine("Done");
            Console.WriteLine("Accumulator: {0}", accu);
        }
        static void Main(string[] args)
        {
            task2();
        }
    }
}
