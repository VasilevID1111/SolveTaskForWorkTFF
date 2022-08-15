using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    internal class Program {
        static void Main(string[] args)
        {
            string[] subs = Console.ReadLine().Split(' ');
            string[] x = new string[int.Parse(subs[0])];
            for (int i = 0; i < subs.Length; i++)
            {
                x[i] = Console.ReadLine();
            }

            for (int i = 0; i < int.Parse(subs[1]); i++)
            {
                int s1 = 0;
                string[] subs1 = Console.ReadLine().Split(' ');
                foreach (string s in x)
                {
                    string nes = (s.Substring(0, subs1[0].Length));
                    string nessd = s.Substring(s.Length - subs1[1].Length);
                    if ((nes == subs1[0]) && (nessd == subs1[1]))
                    {
                        s1++;
                    }
                }
                Console.WriteLine(s1);
            }

            Console.ReadKey();
        }
    }
}


//1
//int[] x = new int[4];
//int[] y = new int[4];
//string a = Console.ReadLine();
//string[] subs = a.Split(' ');
//string b = Console.ReadLine();
//string[] subs1 = b.Split(' ');
//x[0] = Convert.ToInt32(subs[0]);
//y[0] = Convert.ToInt32(subs[1]);
//x[1] = Convert.ToInt32(subs[2]);
//y[1] = Convert.ToInt32(subs[3]);
//x[2] = Convert.ToInt32(subs1[0]);
//y[2] = Convert.ToInt32(subs1[1]);
//x[3] = Convert.ToInt32(subs1[2]);
//y[3] = Convert.ToInt32(subs1[3]);
//int l1 = x.Max() - x.Min();
//int l2 = y.Max() - y.Min();
//if (l1 > l2)
//    Console.WriteLine(Math.Pow(l1, 2));
//else
//    Console.WriteLine(Math.Pow(l2, 2));
//Console.ReadKey();


//2
//Dictionary<HashSet<string>, int> Dic = new Dictionary<HashSet<string>, int>((HashSet<string>.CreateSetComparer()));
//int count = int.Parse(Console.ReadLine());
//for (int i = 0; i < count; i++)
//{
//    HashSet<string> vs = new HashSet<string>();
//    string[] subs = Console.ReadLine().Split(' ');
//    vs.Add(subs[0]);
//    vs.Add(subs[1]);
//    vs.Add(subs[2]);
//    bool cheak = true;
//    foreach (KeyValuePair<HashSet<string>, int> a in Dic)
//    {
//        if (vs.SetEquals(a.Key))
//        {
//            Dic[vs]++;
//            cheak = false;
//            break;
//        }
//    }
//    if (cheak)
//    {
//        Dic.Add(vs, 1);
//    }
//}
//Console.WriteLine(Dic.Values.Max());
//Console.ReadKey();

//3
//int count = int.Parse(Console.ReadLine());
//string[] subs = (Console.ReadLine()).Split(' ');
//List<int> vs = new List<int>(); //plus
//List<int> vs2 = new List<int>(); //minus
//int ks;
//for (int i = 0; i < count; i++)
//{
//    ks = int.Parse(subs[i]);
//    if (i % 2 == 0)
//    {
//        vs.Add(ks);
//    }
//    else
//    {
//        vs2.Add(ks);
//    }
//}
//int sum1 = vs.Sum() - vs2.Sum();
//int sum2 = sum1 + (vs2.Min() - vs.Max()) * 2;
//Console.WriteLine(sum1 > sum2 ? sum1 : sum2);
//Console.ReadKey();


//4
//Dictionary<int, Dictionary<string, int>> Dic = new Dictionary<int, Dictionary<string, int>>();
//Dic.Add(1, new Dictionary<string, int>());
//string line = Console.ReadLine();
//int current_level = 1;
//while (line != null)
//{
//    if (line.Contains('{'))
//    {
//        current_level++;
//        Dic.Add(current_level, new Dictionary<string, int>());
//    }
//    else if (line.Contains('}'))
//    {
//        Dic[current_level].Clear();
//        current_level--;
//    }
//    else
//    {
//        string[] subs = line.Split('=');
//        int num;
//        if (int.TryParse(subs[1], out num))
//        {
//            bool cheak = true;
//            foreach (KeyValuePair<string, int> b in Dic[current_level])
//            {
//                if (b.Key == subs[0])
//                {
//                    cheak = false;
//                }
//            }
//            if (cheak)
//                Dic[current_level].Add(subs[0], num);
//            else
//                Dic[current_level][subs[0]] = num;
//        }
//        else
//        {
//            int value_maybe = 0;
//            foreach (KeyValuePair<int, Dictionary<string, int>> a in Dic)
//            {
//                foreach (KeyValuePair<string, int> b in a.Value)
//                {
//                    if (b.Key == subs[1])
//                    {
//                        value_maybe = b.Value;
//                    }
//                }
//            }
//            if (Dic[current_level].ContainsKey(subs[0]))
//                Dic[current_level][subs[0]] = value_maybe;
//            else
//                Dic[current_level].Add(subs[0], value_maybe);
//            Console.WriteLine(value_maybe);
//        }
//    }
//    line = Console.ReadLine();

//}
//Console.ReadKey();


//5
//string[] subs = Console.ReadLine().Split(' ');
//int a = int.Parse(subs[0]);
//int b = int.Parse(subs[1]);
//string[] lines = new string[a];
//Dictionary<string, int> map = new Dictionary<string, int>();
//for (int i = 0; i < a; i++)
//{
//    lines[i] = Console.ReadLine();
//    map.Add(lines[i], i);
//}
//Array.Sort(lines);
//subs = Console.ReadLine().Split(' ');
//int key;


//while (subs[0] != null)
//{
//    key = Search(lines, subs[1]);
//    int key1 = key, key2 = key + int.Parse(subs[0]) - 1;
//    bool cheak = false;
//    for (; key1 > 0 && lines[key1 - 1].Contains(subs[1]); key1--) { }
//    if (key2 < lines.Length)
//    {
//        if (lines[key2].Contains(subs[1]))
//        {
//            Console.WriteLine(map[lines[key2]] + 1);
//        }
//    }
//    else
//    {
//        Console.WriteLine("-1");
//    }
//    subs = Console.ReadLine().Split(' ');
//}
//        }
//        public static int Search(string[] data, string value)
//{
//    var left = data.GetLowerBound(0);
//    var right = data.GetUpperBound(0);
//    if (left == right)
//        return left;
//    while (true)
//    {
//        if (right - left == 1)
//        {
//            if (data[left].Contains(value))
//                return left;
//            if (data[right].Contains(value))
//                return right;
//            return -1;
//        }
//        else
//        {
//            var middle = left + (right - left) / 2;
//            var comparisonResult = data[middle].CompareTo(value);
//            if (comparisonResult == 0)
//                return middle;
//            if (comparisonResult < 0)
//                left = middle;
//            if (comparisonResult > 0)
//                right = middle;
//        }
//    }