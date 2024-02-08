using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Eren");
            SelamVer();

            int sonuc = Topla(6,5);

            Person person1


            PttManager pttManager = new PttManager(new Fore);

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=5, int sayi2=3)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
    }
}
