using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Veriables
            //double ApplePrice = 10.25;
            //double BananaPrice = 25.50;
            //double CherryPrice = 50.60;

            //Console.WriteLine("*******Meyve Fiyatları*******");
            //Console.WriteLine("Elma Birim Fiyatı" + " " + ApplePrice);
            //Console.WriteLine("Muz Birim Fiyatı" + " " + BananaPrice);
            //Console.WriteLine("Vişne Birim Fiyatı" + " " + CherryPrice);
            //Console.WriteLine("*************************************");
            //Console.WriteLine();
            //Console.WriteLine();

            //int AppleGram, BananaGram, CherryGram;
            //AppleGram = 3;
            //BananaGram = 5;
            //CherryGram = 10;

            //double AppleTotalPrice, BananaTotalPrice, CherryTotalPrice, MainTotalPrice;
            //AppleTotalPrice = ApplePrice * AppleGram;
            //BananaTotalPrice = BananaPrice * BananaGram;
            //CherryTotalPrice = CherryPrice * CherryGram;
            //MainTotalPrice = AppleTotalPrice + BananaTotalPrice + CherryTotalPrice;

            //Console.WriteLine("******Kiralama bedeli******");
            //Console.WriteLine("Alınan Elma Gramı :" + " " + AppleGram + " TL , " + "Elma Fiyatı " + " " + ApplePrice + " TL , " + "Toplam Elma Fiyatı  =" + " " + AppleTotalPrice + " TL");
            //Console.WriteLine("Alınan Vişne Gramı : " + " " + CherryGram + " TL , " + "Vişne Fiyatı " + " " + CherryPrice + " TL , " + "Toplam Vişne Fiyatı  =" + " " + CherryTotalPrice + " TL");
            //Console.WriteLine("Alınan Muz Gramı : " + " " + BananaGram + " TL , " + "Muz Fiyatı " + " " + BananaPrice + " TL , " + "Toplam Muz Fiyatı  =" + " " + BananaTotalPrice + " TL");
            //Console.WriteLine("Genel Toplam : " + " " + MainTotalPrice + " TL");
            //Console.WriteLine("*************************************");
            #endregion
            #region Char Veriables
            // char tek tırnakla tanımlanır '.
            //Console.OutputEncoding = Encoding.UTF8; // utf8 formatına çevirerek tl işaretini görebiliriz.
            //char symbol;
            //symbol = '₺';
            //Console.WriteLine(symbol);


            #endregion
            #region Klavyeden Veri Girişi Ve Dönüşümler
            string CustomerName, CustomerSurname, CustomerAddress, CustomerCity;
            int CustomerNumber, CustomerPostalCode;
            Console.WriteLine("****Araç Kiralama Sistemi****");
            Console.Write("Müşteri Adı :");
            CustomerName = Console.ReadLine();
            Console.Write("Müşteri Soyadı :");
            CustomerSurname = Console.ReadLine();
            Console.Write("Müşteri Adres :");
            CustomerAddress=Console.ReadLine();
            Console.Write("Yaşadığı Şehir :");
            CustomerCity=Console.ReadLine();
            Console.Write("Telefon Numarası :");
            CustomerNumber=int.Parse(Console.ReadLine());
            Console.Write("Posta Kodu :");
            CustomerPostalCode=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****Müşteri Bilgileri****");
            Console.WriteLine("Ad Soyad :" + " " + CustomerName + " " + CustomerSurname);
            Console.WriteLine("Adres Bİlgileri : " + " " + CustomerCity + "," + CustomerAddress + "," + CustomerPostalCode);
            Console.WriteLine("İletişim Bilgileri :" + CustomerNumber);






            #endregion
            Console.Read();
        }
    }
}
