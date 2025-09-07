using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DiziOrnekleri
            // sayilar, renkler, benzer öğelerin bir arada tutulduğu kümelerdir.
            //Değişken türü [] DiziAdi = New Degiskenturu[eleman sayısı]
            //String[] Colors = new String[4];
            //Colors[0] = "Kırmızı";
            //Colors[1] = "yeşil";
            //Colors[2] = "sarı";
            //Colors[3] = "pembe";

            //Console.WriteLine(Colors[0]);

            //int[] number = new int[10];
            //number[0] = 2;
            //number[1] = 4;
            //number[2] = 6;
            //number[3] = 8;
            //number[4] = 10;
            //number[5] =12;
            //number[6] = 14;
            //number[7] = 16;
            //number[9] = 20;

            //Console.WriteLine(number[8]);
            //// eğer bir değer girilmezse 0 değerini alır;

            //int[] numbers = { 10, 21, 33, 44, 56, 612, 73, 86, 90, 1120, 131, 1122, 1433, 149, 15 };

            //    foreach (var number in numbers)
            //    {
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($" Çift Sayı : {number}");
            //    }
            //    else { Console.WriteLine($" Tek Sayı : {number}"); }
            //    }




            #endregion
            #region DiziMetotları
            //lenght dizi uzunluğunu verir
            //Sort diziyi kb sıralar
            //Revers diziyi tersten sıralar
            // İndexof(diziadi,"Aranandeger") dizideki aranan elamanı bulur (eger aranan deger yoksa -1 degerini verir)
            // max-min metotları

            //int[] sayilar = { 12, 41, 51, 816, 916, 4458, 3215, 485, 15, 94, 1, 3, 5, 745, 951 };
            //int maxvalue, minvalue;
            //////////// Console.WriteLine(sayilar.Length);
            ////////// Array.Sort(sayilar);
            ////// Array.Reverse(sayilar);    
            //////int ArananDeger = Array.IndexOf(sayilar, 916);
            //////Console.WriteLine($"916 numaralı sayının yeri {ArananDeger}. indextir." );
            //minvalue = sayilar.Min();
            //maxvalue = sayilar.Max();
            //Console.WriteLine($"Dizideki en küçük değer {minvalue} ve bu değerin  indexi {Array.IndexOf(sayilar, minvalue)} ");
            //Console.WriteLine($"Dizideki en büyük değer {maxvalue} ve bu değerin  indexi {Array.IndexOf(sayilar, maxvalue)} ");


            #endregion
            #region KullanıcıdanDegerAlma
            //string[] cities = new string [5];

            //for (int i = 0; i < cities.Length; i++) {
            //    Console.WriteLine($"Lütfen {i + 1}. sehri giriniz ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("***********************");
            //foreach (string a in cities)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("***********************");

            #endregion


            #region Listeler
            //List<DegiskenTuru> ListeAdi = new List <DegiskenTuru>()

            List<string> listeadi = new List<string>()
            {
                "Deger1", "Deger2","Deger3","Deger4"
            };
            foreach (string a in listeadi) {
                Console.WriteLine(a);
                    }
            #endregion

            Console.Read();
        }
    }
}
