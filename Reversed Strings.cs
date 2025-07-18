using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        //Самый крутой VVV
        public static string Solution(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length / 2; i++)
            { 
                var tmp = sb[i];
                sb[i] = sb[(sb.Length -  i)-1];
                sb[(sb.Length - i) - 1] = tmp;
            }
            return sb.ToString();
        }

        //Гадкий утёнок VVV
        public static string SolutionTwo(string str)
        {
            string sb = "";
            for (int i = str.Length-1; i > -1; i--)
            {
                sb += str[i];
            }
            return sb;
        }

        //Самый лакончиный VVV
        public static string SolutionThree(string str)
            => new string(str.Reverse().ToArray());

        static void Main(string[] args)
        {
            string str = "base";
            Console.WriteLine(SolutionThree(str));
            str = "world";
            Console.WriteLine(SolutionThree(str));

        }
    }
}
