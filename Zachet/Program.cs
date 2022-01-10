using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            Console.WriteLine(F(k));
            Console.ReadKey();
        }

        static int F(int k)
        {
            int sum = GetSpecialSum(k);
            return sum % 1000000007;
        }


        static int GetSpecialSum(int k)
        {
            List<int> S = GetS(k);
            int N = GetN(S);
            List<int> RaffsNumbers = GetKRaffsNumbers(S, N);

            int sum = 0;
            int size = RaffsNumbers.Count;
            for (int i = 0; i < size; i++)
            {
                if (CheckLastDigit(RaffsNumbers[i], 7))
                {
                    sum += RaffsNumbers[i];
                }

            }

            return sum;
        }

        static int GetN(List<int> S_k)
        {
            int product = 1;
            for (int i = 0; i < S_k.Count; i++)
            {
                product *= S_k[i];
            }

            return product;
        }


        static List<int> GetKRaffsNumbers(List<int> S_k, int upperBound)
        {
            List<int> a = new List<int>();

            for (int i = 0; i < upperBound; i++)
            {
                if (IsKRaffsNumber(i, S_k))
                {
                    a.Add(i);
                }
            }

            return a;
        }


        static bool IsKRaffsNumber(int number, List<int> S_k)
        {
            for (int i = 0; i < S_k.Count; i++)
            {
                if (number % S_k[i] == 0)
                {
                    return false;
                }
            }

            return true;
        }


        static List<int> GetS(int k)
        {
            List<int> S = new List<int>(2 + k);
            S.Add(2);
            S.Add(5);

            int numbersCount = 0;
            for (int i = 7; numbersCount < k; i += 10)
            {
                if (IsPrime(i))
                {
                    S.Add(i);
                    numbersCount++;
                }
            }

            return S;
        }


        static bool IsPrime(int number)
        {
            for (int i = 2; i < Sqrt(number) + 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckLastDigit(int number, int digit)
        {
            return GetLastDigit(number) == digit;
        }

        static int GetLastDigit(int number)
        {
            return number % 10;
        }


        static double Sqrt(double number)
        {
            double x = 1;
            for (; ; )
            {
                double nx = (x + number / x) / 2;
                double diff = x - nx;
                if (-1e-10 < diff && diff < 1e-10)
                    break;

                x = nx;
            }

            return x;
        }
    }
}
