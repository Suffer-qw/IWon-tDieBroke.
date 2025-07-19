using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static int DuplicateCount(string str)
        {
            int result = 0;
            str = str.ToLower();
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else charCounts[c] = 1;
            }
            foreach (int c in charCounts.Values)
                if(c>1)
                    result++;
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("Indivisibilities"));
        }
    }
}
