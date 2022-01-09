using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для алфавита CS");
            string str = Console.ReadLine();
            Console.WriteLine(Trans(str));
            Console.WriteLine("Решение 5.2 " + Garderob());

        }
        static string Trans(string str)
        {
            str = str.ToUpper();
            str = str.Replace("А", "A");
            str = str.Replace("Б", "6");
            str = str.Replace("В", "В");
            str = str.Replace("Г", "r");
            str = str.Replace("Д", "D");
            str = str.Replace("Е", "E");
            str = str.Replace("Ё", "E");
            str = str.Replace("Ж", "}|{");
            str = str.Replace("З", "3");
            str = str.Replace("И", "u");
            str = str.Replace("Й", "u*");
            str = str.Replace("К", "K");
            str = str.Replace("Л", "JI");
            str = str.Replace("М", "M");
            str = str.Replace("Н", "H");
            str = str.Replace("О", "O");
            str = str.Replace("П", "n");
            str = str.Replace("Р", "P");
            str = str.Replace("С", "C");
            str = str.Replace("Т", "T");
            str = str.Replace("У", "Y");
            str = str.Replace("Ф", "cp");
            str = str.Replace("Х", "X");
            str = str.Replace("Ц", "L|");
            str = str.Replace("Ч", "4");
            str = str.Replace("Ш", "LLI");
            str = str.Replace("Щ", "LLL");
            str = str.Replace("Ъ", "`b");
            str = str.Replace("Ы", "bI");
            str = str.Replace("Ь", "b");
            str = str.Replace("Э", "-)");
            str = str.Replace("Ю", "IO");
            str = str.Replace("Я", "9I");

            return str;
        }
        static string Garderob()
        {
            string str = "гардероб";
            char[] sRev = str.ToCharArray();
            Array.Reverse(sRev);
            string str2 = new string(sRev);
            return str + " - " + str.Substring(26, 5) + str[26] + str[39] + str[22] + str[25] + str[22] + str.Substring(23, 5) + str[23] + str[27] + str[26] + str[39] + str[37];

        }
    }
}
