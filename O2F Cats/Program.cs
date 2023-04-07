using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O2F_Cats
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            Console.WriteLine($"{Gcd(a, b)} {Gcd(a, c)} {Gcd(b, c)}");
        }
        static int Gcd(int x, int y)
        {
            if (x > y)
            {
                return Alg(x, y);
            }
            else
            {
                return Alg(y, x);
            }
        }

        static int Alg(int x, int y)
        {
            int remainder = x % y;
            if (remainder == 0)
            {
                return y;
            }
            else
            {
                return Alg(y, remainder);
            }
        }
    }
}
