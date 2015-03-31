/*
 * https://www.reddit.com/r/dailyprogrammer/comments/30ubcl/20150330_challenge_208_easy_culling_numbers/
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace SandboxCSharpConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var uniqueNumbers = new HashSet<uint>(Console.ReadLine().Split(' ').Select(UInt32.Parse));
            foreach (var number in uniqueNumbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }

    }
}
