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
        public bool valid(string field)
        {
            switch (field)
            {
                case "byr":
                    if (byr.Length == 4)
                    {
                        if (Convert.ToInt32(byr) >= 1920 && Convert.ToInt32(byr) <= 2002)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "iyr":
                    if (iyr.Length == 4)
                    {
                        if (Convert.ToInt32(iyr) >= 2010 && Convert.ToInt32(iyr) <= 2020)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "eyr":
                    if (eyr.Length == 4)
                    {
                        if (Convert.ToInt32(eyr) >= 2020 && Convert.ToInt32(eyr) <= 2030)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "hgt":
                    int min = 0, max = 0;
                    Regex size = new Regex(@"\d{1,3}");
                    Regex unit = new Regex(@"\D{1,2}");
                    Match sizeM = size.Match(hgt);
                    Match unitM = unit.Match(hgt);
                    if (sizeM.Success && unitM.Success)
                    {
                        if (unitM.Value == "cm")
                        {
                            min = 150;
                            max = 193;
                        }
                        else if (unitM.Value == "in")
                        {
                            min = 59;
                            max = 76;
                        }
                        if (Convert.ToInt32(sizeM.Value) >= min && Convert.ToInt32(sizeM.Value) <= max)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "hcl":
                    Regex color = new Regex(@"[#][0-9a-fA-F]{6}");
                    Match colorM = color.Match(hcl);
                    if (colorM.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "ecl":
                    if (ecl.Length == 3)
                    {
                        if (ecl == "amb")
                        {
                            return true;
                        }
                        else if (ecl == "blu")
                        {
                            return true;
                        }
                        else if (ecl == "brn")
                        {
                            return true;
                        }
                        else if (ecl == "gry")
                        {
                            return true;
                        }
                        else if (ecl == "grn")
                        {
                            return true;
                        }
                        else if (ecl == "hzl")
                        {
                            return true;
                        }
                        else if (ecl == "oth")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "pid":
                    if (pid.Length == 9)
                    {
                        try
                        {
                            Convert.ToInt32(pid);
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;

                default:
                    return false;
                    break;
              }
            return false;
            }
        public void isValid()
        {
            /*return true;
            bool valid = true;
            if (Convert.ToInt32(byr) < 1920 && Convert.ToInt32(byr) > 2002)
            {
                valid = false;
                Console.WriteLine("BYR: " + byr + " is invalid");
            }
            if (Convert.ToInt32(iyr) < 2010 && Convert.ToInt32(iyr) > 2020)
            {
                valid = false;
                Console.WriteLine("IYR: " + iyr + " is invalid");
            }
            if (Convert.ToInt32(eyr) < 2020 && Convert.ToInt32(eyr) > 2030)
            {
                valid = false;
                Console.WriteLine("EYR: " + eyr + " is invalid");
            }

            int min = 0, max = 0;
            Regex size = new Regex(@"\d{1,3}");
            Regex unit = new Regex(@"\D{1,2}");

            Match sizeM = size.Match(hgt);
            Match unitM = unit.Match(hgt);
            if (sizeM.Success && unitM.Success)
            {
                if (unitM.Value == "cm")
                {
                    min = 150;
                    max = 193;
                }
                else if (unitM.Value == "in")
                {
                    min = 59;
                    max = 76;
                }
                if (Convert.ToInt32(sizeM.Value) < min && Convert.ToInt32(sizeM.Value) > max)
                {
                    valid = false;
                }
            }

            Regex color = new Regex(@"[#][0-9a-fA-F]{6}");
            Match colorM = color.Match(hcl);
            if (!colorM.Success)
            {
                valid = false;
            }

            bool eclB = false;
            if (ecl == "amb")
            {
                eclB = true;
            }
            else if (ecl == "blu")
            {
                eclB = true;
            }
            else if (ecl == "brn")
            {
                eclB = true;
            }
            else if (ecl == "gry")
            {
                eclB = true;
            }
            else if (ecl == "grn")
            {
                eclB = true;
            }
            else if (ecl == "hzl")
            {
                eclB = true;
            }
            else if (ecl == "oth")
            {
                eclB = true;
            }
            if (!eclB)
            {
                valid = false;
            }

            Regex passportId = new Regex(@"\d{9}");
            Match passportIdM = passportId.Match(pid);
            if (!passportIdM.Success || pid.Length != 9)
            {
                valid = false;
            }

            return valid;*/
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
                        if (ps.valid("byr") && ps.valid("iyr") &&  ps.valid("eyr") &&  ps.valid("hgt") &&  ps.valid("hcl") &&  ps.valid("ecl") &&  ps.valid("pid"))
                        {
                            valid++;
                            Console.WriteLine("----------\nValid passport. Total: {0}\n----------\n", valid);
                        }

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
            if (!String.IsNullOrEmpty(ps.byr) &&
                        !String.IsNullOrEmpty(ps.iyr) &&
                        !String.IsNullOrEmpty(ps.eyr) &&
                        !String.IsNullOrEmpty(ps.hgt) &&
                        !String.IsNullOrEmpty(ps.hcl) &&
                        !String.IsNullOrEmpty(ps.ecl) &&
                        !String.IsNullOrEmpty(ps.pid))
            {
                if (ps.valid("byr") && ps.valid("iyr") && ps.valid("eyr") && ps.valid("hgt") && ps.valid("hcl") && ps.valid("ecl") && ps.valid("pid"))
                {
                    valid++;
                    Console.WriteLine("----------\nValid passport. Total: {0}\n----------\n", valid);
                }
            }
            Console.WriteLine("Valid passports: {0}", valid);
        }
    }
}
