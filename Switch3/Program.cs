using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen plakanın ait oldugu sehri konsola yazdırma

            Console.WriteLine("Lütfen bir plaka girin : ");
            string plaka = (Console.ReadLine());
            Yazdir(plaka);

            Console.Read();
        }

        static void Yazdir(string plaka)
        {
            switch (plaka)
            {
                case "6":
                    Console.WriteLine("Ankara");
                    break;
                case "35":
                    Console.WriteLine("İzmir");
                    break;
                case "34":
                    Console.WriteLine("İstanbul");
                    break;
                default:
                    Console.WriteLine("Gecersiz bir plaka girdiniz");
                    break;
            }
        }
    }
}
