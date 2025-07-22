using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        //не до конца работает VVV
        public static bool ValidatePin(string pin)
        {
            int number;
            if (pin.Trim().Length == 4 || pin.Trim().Length == 6)
                if (int.TryParse(pin, out number) && number >= 0)
                    if (pin[pin.Length - 1] != '\n')
                        return true;
            return false;
        }
        public static bool ValidatePinReg(string pin)
        {
            if (Regex.IsMatch(pin, @"^[0-9]{4}([0-9]{2})?\z"))
                return true;
            return false;
            /*
             * Разбор Regex строки 
             * 1 ^
             *   Это символ начала строки.  
             *   Означает, что совпадение должно начинаться с самого начала строки (без пробелов или других символов перед числом).
             *   
             * 2 [0-9]
             *   Это цифровой символ (любая цифра от 0 до 9).  
             *   Эквивалентно \d (но [0-9] более явное и читаемое). 
             * 3 {4}  
             *   Квантификатор, означающий ровно 4 повторения предыдущего элемента.
             *   в нашем случае означает что должно быть 4 цифры подряд
             * 4 ([0-9]{2})?
             *   Это опциональная группа из 2 цифр.
             *   ? — означает, что предыдущий элемент (в данном случае группа) может быть, а может и отсутствовать
             * 5 \z
             *   Это конец строки (аналог $, но \z строже — он гарантирует, что после совпадения нет вообще ничего, даже перевода строки)
             * 
             */
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePinReg("0000" + "\n"));
            Console.WriteLine(ValidatePinReg("1234"));
            Console.WriteLine(ValidatePinReg("+111"));
        }
    }
}
