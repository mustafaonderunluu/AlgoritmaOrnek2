using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Taban değeri ve üssü kullanıcı tarafından girilen işlemin sonucunu For döngüsü kullanarak hesaplayan örnek
            int Taban, Us, Sonuc = 1;
            Console.Write("Taban Değeri Giriniz :");
            Taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üs Değeri Giriniz  :");
            Us = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Us; i++) {


                Sonuc = Sonuc * Taban;
            
            }
            Console.WriteLine("Tabanı {0} Kuvveti {1} Değeri =  {2}",Taban,Us,Sonuc);
            Console.ReadKey();


            // Kullanıcının girdiği 3 sayıdan en büyük olanını ekranda gösteren örnek
            //int s1, s2, s3;
            //Console.Write("Lütfen BİRİNCİ SAYIYI GİRİNİZ : ");
            //s1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("LÜTFEN İKİNCİ SAYIYI GİRİNİZ : ");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("LÜTFEN ÜÇÜNCÜ SAYIYI GİRİNİZ : ");
            //s3 = Convert.ToInt32(Console.ReadLine());
            //    if (s1 > s2 && s1 > s3)
            //    {

            //        Console.WriteLine("EN BÜYÜK SAYI BİRİNCİ SAYIDIR ");

            //    }
            //    else if (s2 > s1 && s2 > s3)
            //    {

            //        Console.WriteLine("EN BÜYÜK SAYI İKİNCİ SAYIDIR ");

            //    }
            //    else if (s3 > s1 && s3 > s2)
            //    {

            //        Console.WriteLine("EN BÜYÜK SAYI ÜÇÜNCÜ SAYIDIR ");


            //    }
            //    else
            //    {
            //        Console.WriteLine("FARKLI SAYI GİRİNİZ  ");


            //    }





        }
        
    }
}
