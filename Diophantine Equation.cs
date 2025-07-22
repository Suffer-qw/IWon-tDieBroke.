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

        //кад на половину мой, а на половину нейронки , рабочий (прашёл кату) 
        public static string MysolEquaStr(long n)
        {
            List<long> ints = new List<long>();
            for (long a = 1; a <= Math.Sqrt(n); a++)
            {
                if (n % a == 0)
                {
                    long b = n / a;
                    if ((a + b) % 2 == 0 && (b - a) % 4 == 0)
                    {
                        long y = (b - a) / 4;
                        if (y >= 0)
                        {
                            ints.Add((a + b) / 2);
                            ints.Add(y);
                        }
                    }
                }
            }
            string result = "[";
            for (int i = 0; i < ints.Count; i += 2)
            {
                result += $"[{ints[i]}, {ints[i + 1]}], ";
            }
            if(result.Length >1)
                result = result.Remove(result.Length - 2,2);
            result += "]";
            return result;
        }

        // уже забыл что за код не рабочий
        public static string solEquaStr(long n)
        {
            List<long> ints = new List<long>();
            for (long a = (long)Math.Sqrt(n)+1; a >= 0; a--)
            {
                long tmp = a * a - n;
                if (tmp >= 0 || tmp % 4 ==0)
                {
                    long b = (long)Math.Sqrt(tmp/4);
                    if (b >= 0)
                    {
                        ints.Add(a);
                        ints.Add(b);
                    }
                }
            }
            string result = "[";
            for (int i = 0; i < ints.Count; i += 2)
            {
                result += $"[{ints[i]},{ints[i + 1]}],";
                Console.WriteLine("n =" + (ints[i] * ints[i] - 4 * (ints[i + 1] * ints[i + 1])));
            }
            if (result.Length > 1)
                result = result.Remove(result.Length - 1, 1);
            result += "]";
            Console.WriteLine(result);
            return result;
        }

        //фулл код нейронки который не работает (этот код не прошёл бы кату)
        public static string solEquaStrNeiro(long n)
        {
            List<int[]> solutions = new List<int[]>();
            for (long a = 1; a <= Math.Sqrt(n); a++)
            {
                if (n % a == 0)
                {
                    long b = n / a;
                    if ((a + b) % 2 == 0 && (b - a) % 4 == 0)
                    {
                        int x = (int)((a + b) / 2);
                        int y = (int)((b - a) / 4);
                        if (y >= 0)
                        {
                            solutions.Add(new int[] { x, y });
                        }
                    }
                }
            }
            solutions.Sort((pair1, pair2) => pair2[0].CompareTo(pair1[0]));
            // Сортируем по убыванию x
            solutions.Sort((x, y) => y[0].CompareTo(x[0]));

            StringBuilder sb = new StringBuilder("[");
            for (int i = 0; i < solutions.Count; i++)
            {
                sb.Append($"[{solutions[i][0]},{solutions[i][1]}]");
                if (i < solutions.Count - 1) sb.Append(",");
            }
            sb.Append("]");

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(solEquaStrNeiro(9000000041L));
            Console.WriteLine(solEquaStrNeiro(13));
            Console.WriteLine(solEquaStrNeiro(16));
            Console.WriteLine(solEquaStrNeiro(90005));

            Console.WriteLine(MysolEquaStr(9000000041L));
            Console.WriteLine(MysolEquaStr(13));
            Console.WriteLine(MysolEquaStr(16));
            Console.WriteLine(MysolEquaStr(90005));

        }
    }
}
