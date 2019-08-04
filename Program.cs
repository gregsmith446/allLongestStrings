using System;
using System.Collections.Generic;
using System.Linq;

namespace AllLongestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testData = { "aba", "aa", "ad", "vcd", "aba" };

            Algorithm run = new Algorithm();

            string[] answer = run.AllLongestStrings(testData);

            foreach (string str in answer)
            {
                Console.WriteLine(str);
            }
        }
    }

    class Algorithm
    {
        public string[] AllLongestStrings(string[] inputArray)
        {
            List<string> list = inputArray.ToList();

            int max = 0;

            foreach (string str in list)
            {
                if (str.Length > max)
                {
                    max = str.Length;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (max > list[i].Length)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                if (max > list[j].Length)
                {
                    list.Remove(list[j]);
                }
            }

            string[] result = list.ToArray();

            return result;
        }
    }
}
