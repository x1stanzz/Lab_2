using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nk, nn;

            Console.Write("Введіть кінець ряду = ");
            string strnk = Console.ReadLine();
            nk = Int32.Parse(strnk);

            Console.Write("Введіть початок ряду = ");
            string strnn = Console.ReadLine();
            nn = Int32.Parse(strnn);

            if (nn > nk || nn < 0)
            {
                Console.WriteLine("Спробуйте ще раз");
                Console.Write("Введіть початок ряду = ");
                strnn = Console.ReadLine();
                nn = Int32.Parse(strnn);
            }

            double sum = 0;

            for(; nn <= nk; nn++)
            {
                sum += (Math.Pow(nn, 2) - 3) / (Math.Pow(nn, 2) - Math.Pow(-1, nn) * nn + 3);
            }
            Console.Write($"Сума ряду = {sum}");
            Console.Read();
        }
    }
}
