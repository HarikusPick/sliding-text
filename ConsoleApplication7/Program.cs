using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            string bos = " ", mesaj;
            Console.WriteLine("Ne yazdırmak istiyorsunuz? :");
            mesaj = Console.ReadLine();
            Console.WriteLine("Kaç defa yazdırmak istiyorsunuz? :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(mesaj);
                Console.Write(bos);
                bos = bos + " ";


            }
            Console.ReadKey();
        }
    }
}
