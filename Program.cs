using System;
using System.Text;

namespace timuocso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int  a, b , uscln=1;
            Console.Write("Nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b: ");  
            b = Convert.ToInt32(Console.ReadLine());
            uocsochunglonnhat(a, b);
            Console.Write("\nUSCLN cua {0} va {1} la: {2}\n\n", a, b, uscln);
        }

        private static void uocsochunglonnhat(int a, int b)
        {
            int j, i, uscln;
            j = (a < b) ? a : b;
            for (i = 1; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    uscln = i;
                }
            }
          

        }
    }
}
