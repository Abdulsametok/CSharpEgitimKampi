using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //for (int i = 3; i < 100; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            // Unutmayalım ki içerideki for döngüsü bitmeden dışarıya çıkmaz
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine("*");
            //    for (int j = 4; j >=0; j--)
            //    {
            //        Console.WriteLine("**");
            //    }
            //}

            //1  *
            //3  ***                    Solda Verilen Şekli for Yapısıyla Nasıl oluşturur ? 
            //5  *****                    öncelikle algoritmayı bul. 2 sayı var olsun. Bunlar a ve b
            //8  ********                   a=1 b=2 iken 1
            //13 *************              a=2 b=3 iken 3 ***
            //21 son                        a=3 b=2 iken 5 demek algoritmamız a yı 1 den başlat 1 artırarak git  yani a 
            //                                                                b yi 2 dan başlat 1 artırarak git  yani a+b   
            //                                                                                                   yani a+b+a+a
            //                                                                                                   yani a+b+a+a+b+a
            //                                                                                                   yani a+b+a+a+b+a+a+b+a
            //                                                                b + a+b toplamı kadar * yazdır 6. adımda son bulduğundan sınır değerleri 6 olabilir.



            //int count = 1;      // ilk satırdaki yıldız sayısı
            //int d1 = 2, d2 = 2; // artışların tohumları

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(new string('*', count)); // mevcut sayıda yıldız
            //    count += d2;                                // bir sonraki satırın sayısı

            //    int nextDelta = d1 + d2;                    // fibo: artışları ilerlet
            //    d1 = d2; d2 = nextDelta;
            //}

            //int totalvalue = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    totalvalue += i;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalvalue);


            //int modtotalvalue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        modtotalvalue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(modtotalvalue);

            // 1 2 4 8 16 kendini bölerek çoğalıyor.  her saatte 2 ye bölünen bir bakteri var.
            // 24 saatin sonunda bu ortamda kaç bakteri vardır.
            // algoritma mantığı a bakterisi 
            // 1 saat a
            // 2 saat a*2
            // 3 saat 2a*2
            // yani her saatte bir öncekini 2 ile çarpıyoruz

            //int bakteri = 1;
            //int totalbakteri = 0;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *=2 ;
            //    Console.WriteLine( i + ".saatte " +  bakteri + " Bakteri ");
            //    totalbakteri +=bakteri;

            //}
            //Console.WriteLine();
            //Console.WriteLine("------------");
            //Console.WriteLine("Toplam Bakteri Sayısı "+ totalbakteri);
            #endregion
            #region While Loop
            //int i = 0;

            //while (i<10)
            //{
            //    Console.WriteLine("10 Dan Küçük Ve değer" + i);
            //    i++; 
            //}

            //int i, sum;
            //i=1;
            //sum=0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            // Asal sayıları yazdıran while döngüsünü yazınız
            //int number;
            //Console.WriteLine("Lütfen Sayısı Giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //int i = 2;
            //while (i<number/2)
            //{

            //    if (number%2==0 )
            //    {
            //        Console.WriteLine( "Bu Sayı Asal Değildir. "+ number );
            //    }


            //    else
            //    {
            //        Console.WriteLine("Bu Sayı Asaldır : " + number);
            //    }
            //}

            // klavyede girilen 3 basamaklı sayının basamakları toplamı
            // örnek 538
            // program 3 bilinmeyen abc a yı al b yı al c yi al topla.

            //int birler, onlar, yuzler;
            //int sayi;
            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz : ");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //yuzler = sayi / 100;
            //birler = sayi % 10;
            //onlar = (sayi % 100) / 10;
            //Console.WriteLine("Girilen Sayının rakamları = {0}-{1}-{2} Ve  Rakamların Toplamı İse = {3}",yuzler,onlar,birler,yuzler+onlar+birler);
            //Console.WriteLine($"Girilen Sayının rakamları = {yuzler}-{onlar}-{birler} Ve Rakamların Toplamı İse = {yuzler+onlar+birler}" );

            
            #endregion
                Console.Read();
        }
    }
}
