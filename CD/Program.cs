using System;
using System.Collections.Generic;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            HashSet<string> collection = new HashSet<string>();
            string input;
            string[] parameters;

            while ((input = Console.ReadLine()) != "0 0")
            {
                parameters = input.Split(' ');
                N = int.Parse(parameters[0]);
                M = int.Parse(parameters[1]);

                collection.Clear();

                for (; N > 0; N--)
                {
                    collection.Add(Console.ReadLine());
                }

                for (; M > 0; M--)
                {
                    if (collection.Contains(Console.ReadLine()))
                        N++;
                }

                Console.WriteLine(N);
            }
        }
    }
}
