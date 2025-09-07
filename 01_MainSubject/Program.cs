 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırma komutları
            //Console.WriteLine("******ARAÇLAR****");
            //Console.WriteLine("******************");
            //Console.WriteLine("1-Otomobil");
            //Console.WriteLine("2-Cherrybisiklet");
            //Console.WriteLine("3-Kamyonet");
            //Console.WriteLine("******************");
            #endregion
            #region Değişlenler
            //string name;
            //name = "Abdulsamet" 
            //Console.WriteLine(name);

            //string MusteriAdi;
            //string MusteriSoyadi;
            //string MusteriAdresi, MusterEmail;

            //MusteriAdi = "Ali";
            //MusteriSoyadi = "Yasa";
            //MusteriAdresi = "Adana";
            //MusterEmail = "aliyasa@gmail.com";

            //Console.WriteLine("*****Müşteri Bilgileri*****");
            //Console.WriteLine("AD SOYAD :"+MusteriAdi + " " + MusteriSoyadi);
            //Console.WriteLine("ADRES :"+MusteriAdresi);
            //Console.WriteLine("E-MAİL :"+MusterEmail);
            //Console.WriteLine("***********");

            int BusRentPrice=10;
            int CherryRentPrice=25;
            int BananaRentPrice=50;

            Console.WriteLine("*******Araç Kiralama Bedelleri*******");
            Console.WriteLine("Otobüs Kiralama Ücreti"+ " "+BusRentPrice);
            Console.WriteLine("Cherry Kiralama Ücreti"+ " "+CherryRentPrice);
            Console.WriteLine("Araba Kiralama Ücreti" +" "+ BananaRentPrice);
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine();

            int BusRentCount, CherryRentCount, BananaRentCount;
            BusRentCount = 3;
            CherryRentCount = 5;
            BananaRentCount = 10;

            int BusTotalPrice, CherryTotalPrice, BananaTotalPrice, MainPrice;
            BusTotalPrice = BusRentPrice * BusRentCount;
            BananaTotalPrice = BananaRentPrice * BananaRentCount;
            CherryTotalPrice = CherryRentPrice * CherryRentCount;
            MainPrice= BusTotalPrice+BananaTotalPrice+CherryTotalPrice;

            Console.WriteLine("******Kiralama bedeli******");
            Console.WriteLine("Toplam kiralanan Otobüs Sayısı :" +" "+ BusRentCount + " TL , " + "Otobüs Kiralama Ücreti"+ " "+BusRentPrice + " TL , " + "Toplam Otobüs Kiralama Ücreti ="+" "+ BusTotalPrice + " TL");
            Console.WriteLine("Toplam kiralanan Cherry Sayısı :" +" "+ CherryRentCount + " TL , " + "Cherry Kiralama Ücreti"+ " "+CherryRentPrice + " TL , " + "Toplam Cherry Kiralama Ücreti ="+" "+ CherryTotalPrice + " TL");
            Console.WriteLine("Toplam kiralanan Araba Sayısı :" +" "+ BananaRentCount + " TL , " + "Araba Kiralama Ücreti"+ " "+BananaRentPrice + " TL , " + "Toplam Araba Kiralama Ücreti ="+" "+ BananaTotalPrice + " TL");
            Console.WriteLine("Genel Toplam : " + " " + MainPrice + " TL");
            Console.WriteLine("*************************************");
            #endregion
            Console.Read();

        }
    }
}
