using System;

namespace пересдача
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            for (int i = 1; i <= 1000; i++)
                if (Divider(i) == 8)
                    count += 1;

            Console.WriteLine($"f(10^6)={count}");
            Console.ReadKey();
        }
        static int Divider(int number)
        {
            var count = 0;
            for (var i=1; i<=number; i++)
            {
                if (number % i == 0)
                    count += 1;
                if (count > 8)
                    break;
            }
            return count;
        }
    }
}
