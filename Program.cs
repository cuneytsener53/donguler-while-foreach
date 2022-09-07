using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while 
            //1 den başlayarak console girilen sayıya kadar (Sayı Dahil) ortalama hesaplayıp console yazdıran program.,
            Console.WriteLine("Bir sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<= sayi)
            {
                toplam+= sayac;
                sayac ++;
            }

            Console.WriteLine(toplam/sayi);

            //A 'dan Z ye kadar tüm harfleri console yazdır
            char character = 'a' ;
            while (character< 'z')
            {
                Console.Write(character);
                character ++;
            }
            Console.Write("********* FOR EACH *****");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);    
            }
        }
    }
}