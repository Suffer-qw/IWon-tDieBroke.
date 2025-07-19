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
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> diff = new List<int>(a);
            for (int i = 0; i < b.Length; i++) 
            {
                diff.RemoveAll(x => x == b[i]);
            }
            return diff.ToArray();
        }


        static void Main(string[] args)
        {
            foreach (int arg in ArrayDiff(new int[] {1, 2},    new int[] {1}))
            {
                Console.WriteLine(arg);
            }
        }
    }
}
