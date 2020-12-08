using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020_7._1
{
    class Program
    {
        public static Dictionary<string, int> getChilds(string[] words, int contains)
        {
            /*
clear violet bags contain   3
1 dotted lavender bag,  7
5 bright tan bags,  11
5 dim violet bags,  15
5 drab salmon bags.     19
 */
            var pair = new Dictionary<string, int>();
            int i = 0;
            int temp = contains;
            while (temp > 0)
            {
                i = i + 4;
                temp--;
            }
            string key = words[i + 1] + words[i + 2] + words[i + 3];

            key = key.Replace(",", "");
            key = key.Replace(".", "");

            pair.Add(key, Convert.ToInt32(words[i]));

            return pair;
        }
        public static Dictionary<string, Dictionary<string, int>> serializeData()
        {
            string[] lines = File.ReadAllLines("input.txt");
            var lineCount = File.ReadLines("input.txt").Count();

            Dictionary<string, Dictionary<string, int>> bags = new Dictionary<string, Dictionary<string, int>>(); //shinybluebag, (shinygoldbag, 3)

            foreach (var line in lines)
            {
                var words = line.Split(" ");
                string key = words[0] + words[1] + words[2];//lightredbags
                string valuename;//567
                int valueamount;//4
                key = key.Remove(key.Length - 1);//lightredbag

                if (words[4] == "no")//does not contain a bag
                {
                    Console.WriteLine(key + " does not contain any bags");
                }
                else
                {
                    valuename = words[5] + words[6] + words[7];
                    valueamount = Convert.ToInt32(words[4]);

                    var pair = new Dictionary<string, int>();

                    int contains = words.Length;
                    contains = contains - 4;
                    contains = contains / 4;
                    while (contains > 0)
                    {
                        var values = getChilds(words, contains);//get key value pair
                        foreach (var v in values)
                        {
                            pair.Add(v.Key, v.Value);
                        }
                        contains--;
                    }
                    bags.Add(key, pair);
                    foreach (var p in pair)
                    {
                        Console.WriteLine(key + " = " + p.Key + " / " + p.Value);
                    }
                }
            }
            return bags;
        }
        static void Main(string[] args)
        {
            var bags = serializeData();
            string wanted = "shinygoldbag";

            int foundWanted = 0;
            foreach (var b in bags)
            {
                var l = b.Value;
                if (l.Count(x=> x.Key == wanted) != 1)
                {
                    foundWanted++;
                }
            }
            Console.WriteLine(foundWanted);
        }
    }
}
