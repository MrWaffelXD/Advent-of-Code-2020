using System;

namespace AdventOfCode2020_1._1
{
    class Program
    {
        static void task1()
        {
            string[] numbers = System.IO.File.ReadAllLines("..\\..\\..\\input.txt");
            int arrl = numbers.Length;

            int curr = 0;
            foreach (string sn in numbers)
            {
                int n = Convert.ToInt32(sn);
                curr = n;
                for (int i = 0; i < arrl; i++)
                {
                    if (curr + Convert.ToInt32(numbers[i]) == 2020)
                    {
                        Console.WriteLine("{0} + {1} = 2020", curr, Convert.ToInt32(numbers[i]));
                        Console.WriteLine("{0} * {1} = {2}", curr, Convert.ToInt32(numbers[i]), curr * Convert.ToInt32(numbers[i]));
                        Console.WriteLine("\n");
                    }
                }
            }
            Console.WriteLine("End of program!");
        }
        static void task2()
        {
            string[] numbers = System.IO.File.ReadAllLines("input.txt");
            int arrl = numbers.Length;

            for(int fi = 0; fi<arrl; fi++)
            {
                int currf = Convert.ToInt32(numbers[fi]);//get first number
                for (int si = 0; si<arrl; si++)
                {
                    int currs = Convert.ToInt32(numbers[si]);//get first number
                    for(int ti = 0; ti<arrl; ti++)
                    {
                        int currt = Convert.ToInt32(numbers[ti]);
                        if(currf + currs + currt == 2020)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 2020", currf, currs, currt);
                            Console.WriteLine("{0} * {1} * {2} = {3}", currf, currs, currt, currf * currs * currt);
                            Console.WriteLine("\n");
                        }
                    }
                }
            }
            Console.WriteLine("End of program!");
        }
        static void Main(string[] args)
        {
            task2();
        }
    }
}
