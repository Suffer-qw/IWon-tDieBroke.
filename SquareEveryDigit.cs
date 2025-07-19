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
        public static int SquareDigits(int n)
        {
            string result = "0";
            int digit = 0;
            while (n>0)
            {
                digit = n%10;
                result += digit*digit;
                n = n /10;  

            }
            return int.Parse(result);
        }

        public static int SquareDigitsTwo(int n)
        {
            StringBuilder result = new StringBuilder();
            while (n > 0)
            {
                int digit = n % 10;
                result.Insert(0, digit*digit);
                n = n / 10;

            }
            return result.Length == 0 ? 0 : int.Parse(result.ToString());
        }

        static void Main(string[] args)
        {
            //НЕ ТЕСТИРОВАЛСЯ СРАЗУ НА КОД ВАРС 


        }
    }
}
