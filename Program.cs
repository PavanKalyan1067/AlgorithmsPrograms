using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Permutation Using Recursion");
                Console.WriteLine("2.Binary Search the word from wordlist");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter String to find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutations.Permutate(str, 0, n - 1);
                        break;
                    case 2:
                        string txtpath = File.ReadAllText(@"algo.txt");
                        List<string> words = new List<string>(txtpath.Split());
                        words.Sort();
                        BinarySearch.BinarySearchWord(words);
                        break;
                    default:
                        Console.WriteLine("Enter the valid option!");
                        break;

                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }
        }
    }
}