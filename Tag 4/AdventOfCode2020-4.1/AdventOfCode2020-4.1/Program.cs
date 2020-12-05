using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2020_4._1
{
    public class Passport
    {
        public Passport()
        {
            //hgt = new Height();
        }
        public void resetPassport()
        {
            byr = null;
            iyr = null;
            eyr = null;
            hgt = null;
            hcl = null;
            ecl = null;
            pid = null;
            cid = null;
        }
        public string byr { get; set; }
        public string iyr { get; set; }
        public string eyr { get; set; }
        public string hgt { get; set; }
        public string hcl { get; set; }
        public string ecl { get; set; }
        public string pid { get; set; }
        public string cid { get; set; }

    }
    public class Height
    {
        public Height(int size = 0, string unit = "")
        {

        }
        public int size { get; set; }
        public string unit { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] passports = System.IO.File.ReadAllLines("input.txt");

            Regex regex = new Regex(@".{3}[:]\S{1,}");
            Passport ps = new Passport();
            int valid = 0;

            foreach (var p in passports)
            {
                if (p == "")
                {

                    if (!String.IsNullOrEmpty(ps.byr) &&
                        !String.IsNullOrEmpty(ps.iyr) &&
                        !String.IsNullOrEmpty(ps.eyr) &&
                        !String.IsNullOrEmpty(ps.hgt) &&
                        !String.IsNullOrEmpty(ps.hcl) &&
                        !String.IsNullOrEmpty(ps.ecl) &&
                        !String.IsNullOrEmpty(ps.pid))
                    {
                        valid++;
                        Console.WriteLine("----------\nValid passport. Total: {0}\n----------\n", valid);
                    }
                    else
                    {
                        Console.WriteLine("----------\nInvalid passport. Total: {0}\n----------\n", valid);
                    }
                    ps.resetPassport();
                }
                else
                {
                    string[] elements = p.Split(' ');

                    foreach (var e in elements)
                    {

                        Match match = regex.Match(e);
                        if (match.Success)
                        {
                            string key = match.Value.Substring(0, 3);
                            string value = match.Value.Remove(0, 4);

                            if (key == "byr")
                            {
                                ps.byr = value;
                            }
                            else if (key == "iyr")
                            {
                                ps.iyr = value;
                            }
                            else if (key == "eyr")
                            {
                                ps.eyr = value;
                            }
                            else if (key == "hgt")
                            {
                                ps.hgt = value;
                            }
                            else if (key == "hcl")
                            {
                                ps.hcl = value;
                            }
                            else if (key == "ecl")
                            {
                                ps.ecl = value;
                            }
                            else if (key == "pid")
                            {
                                ps.pid = value;
                            }
                            else if (key == "cid")
                            {
                                ps.cid = value;
                            }
                            Console.WriteLine(key + " / " + value);
                        }
                    }
                }               
            }
            valid++;//yeah i know. not the best solution...
            Console.WriteLine("Valid passports: {0}", valid);
        }
    }
}
