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
        public static void CountSheeps()
        {
            for (int i = 65; i < 123; i++) 
            {
                Console.WriteLine(i + " " + (char)i );
            }

        }
        /*
         * class Program
{
    static void Main()
    {
        int min = 2;
        int max = 8;

        Console.Write("Введите число: ");
        int userNumber = int.Parse(Console.ReadLine());

        int wrappedNumber = WrapIntoRange(userNumber, min, max);

        Console.WriteLine($"Число {userNumber} в диапазоне [{min}, {max}] → {wrappedNumber}");
    }

    static int WrapIntoRange(int number, int min, int max)
    {
        int range = max - min + 1; // Для 2–8 это 7
        return ((number - min) % range + range) % range + min;
    }
}
        */
        public static string Rot13(string message)
        {
            char[] chars = message.ToCharArray();
            string str = "";
            int rangenizreg = 122 - 97 + 1;
            int rangeverxreg = 90 - 65 + 1;
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (chars[i] < 97)
                        str += (char)((((chars[i] + 13) - 65) % rangeverxreg + rangeverxreg) % rangeverxreg + 65);
                    else
                        str += (char)((((chars[i] + 13) - 97) % rangenizreg + rangenizreg) % rangenizreg + 97);
                }
                else
                    str += chars[i];
            }
           
            return str;
        }

        static void Main(string[] args)
        {
            CountSheeps();
            Console.WriteLine(Rot13("ScMX>bs\\bborfHBvz\"UzadCvIfGboKEvanqGSHPUbZPuqphjNc"));
        }
    }
}
