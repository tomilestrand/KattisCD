using System;
using System.Collections.Generic;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            int matches, N, M;
            HashSet<string> collection;
            string input;
            string[] parameters;
            while ((input = Console.ReadLine()) != "0 0")
            {
                parameters = input.Split(' ');
                N = int.Parse(parameters[0]);
                M = int.Parse(parameters[1]);

                matches = 0;
                collection = new HashSet<string>();

                for (; N > 0; N--)
                {
                    collection.Add(Console.ReadLine());
                }

                for (; M > 0; M--)
                {
                    if (collection.Contains(Console.ReadLine()))
                        matches++;
                }
                Console.WriteLine(matches);
            }
        }
    }
}
