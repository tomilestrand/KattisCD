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

                while (N-- > 0)
                {
                    collection.Add(Console.ReadLine());
                }

                while (M-- > 0)
                {
                    if (collection.Contains(Console.ReadLine()))
                        matches++;
                }

                Console.WriteLine(matches);
            }
        }
    }
}
