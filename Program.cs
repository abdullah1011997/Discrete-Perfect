using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int n1, n2;
            Console.WriteLine("The perfec number");

            Console.Write("Enter The First Number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Nuumber: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("The perfect numbers is:\n");
            for (n = n1; n <= n2; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;

                    i++;


                }
                if (sum == n)
                    Console.WriteLine("{0}", n);


            }

        }
    }
}
