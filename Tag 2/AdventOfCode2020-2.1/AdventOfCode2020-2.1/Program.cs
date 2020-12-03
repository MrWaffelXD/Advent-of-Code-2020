using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020_2._1
{
    //count valid passwords from policy
    class Policy
    {
        //1-13 r: gqdrspndrpsrjfjx
        public int max { get; set; }
        public int min { get; set; }
        public char character { get; set; }
        public string password { get; set; }
    }
    class Program
    {
        public static int task1()
        {
            string[] passwords = System.IO.File.ReadAllLines("..\\..\\..\\passwords.txt");

            char[] spearator = { ' ' };
            int counter = 0;
            foreach (string p in passwords)
            {
                string[] strlist = p.Split(spearator);
                /*
                1-13
                r:
                gqdrspndrpsrjfjx
                */
                Policy pw = new Policy();

                string[] qty = strlist[0].Split("-");

                pw.min = Convert.ToInt32(qty[0]);
                pw.max = Convert.ToInt32(qty[1]);
                pw.character = strlist[1][0];
                pw.password = strlist[2];

                int count = pw.password.Count(f => f == pw.character);//linq - count occurence of char in str
                if (count >= pw.min && count <= pw.max)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int task2()
        {
            string[] passwords = System.IO.File.ReadAllLines("..\\..\\..\\passwords.txt");

            char[] spearator = { ' ' };
            int counter = 0;
            foreach (string p in passwords)
            {
                string[] strlist = p.Split(spearator);

                Policy pw = new Policy();

                string[] qty = strlist[0].Split("-");

                pw.min = Convert.ToInt32(qty[0]);
                pw.max = Convert.ToInt32(qty[1]);
                pw.character = strlist[1][0];
                pw.password = strlist[2];

                char first = pw.password[pw.min - 1];
                char second = pw.password[pw.max - 1];

                if(first != second && first == pw.character || first != second && second == pw.character)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("There are {0} passwords matching the policy!", task1());
            Console.WriteLine("There are {0} passwords matching the new policy!", task2());
        }
    }
}
