using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O2F_Cats
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');

            double sum = 0;
            foreach (string number in array)
            {
                double value = Convert.ToDouble(number, CultureInfo.GetCultureInfo("en-US"));
                sum += Math.Pow(value, 2);
            }

            double euclidNorm = Math.Sqrt(sum);

            if (euclidNorm % 1 != 0)
            {
                Console.WriteLine(euclidNorm.ToString(CultureInfo.GetCultureInfo("en-US")));
            }
            else
            {
                Console.WriteLine(euclidNorm.ToString("F1", CultureInfo.GetCultureInfo("en-US")));
            }

        }
    }
}