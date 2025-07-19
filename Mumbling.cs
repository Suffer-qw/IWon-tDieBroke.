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
        public static string Accum(string str)
        {
           StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(Char.ToUpper(str[i]));
                for (int y = 1; y <= i; y++)
                {
                    sb.Append(Char.ToLower(str[i]));
                }
                sb.Append("-");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

      
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("ZpglnRxqenU"));

        }
    }
}
