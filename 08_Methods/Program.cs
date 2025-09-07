using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geriye Değer Döndürmeyen Metotlar Void MethodAdi()
            //GERİYE DEĞER DÖNDÜRMEYEN METOTLAR (VOİD)
            //void KullanicilariListele() { Console.WriteLine("Ahmet Işık"); Console.WriteLine("Veli Işık"); Console.WriteLine("Celil Işık"); }
            //KullanicilariListele();       

            #endregion
            #region Geriye Değer Döndürmeye String Parametreli Metotlar Void MethodAdi (string CustomerName)
            //GERİYE     DEĞER DÖNDÜRMEYEN PARAMETRELİ METOTRLAR
            //void KullanicilariListele(string Kadi)
            //{
            //    Console.WriteLine(Kadi);
            //}
            //KullanicilariListele("Samyeli");


            //void CustomerCard(string name, string surname)
            //{

            //    Console.WriteLine($"Müşteri Adı : {name} ------ Soyadı : {surname}");
            //}
            //CustomerCard("Ali" , "BİRGÜLLÜ");
            //CustomerCard("Ayşe" , "URLA");
            //CustomerCard("Can" , "TUZ");
            //CustomerCard("Samet" , "GÖNÜL");

            #endregion
            #region Geriye Değer Döndürmeyen İnt Parametreli  Metotlar Void MethodAdi (int CustomerName)
            //void sum(int number1, int number2, int number3)
            //{
            //    Console.WriteLine("Girilen Sayıların Toplamı : " + (number1 + number2 + number3));
            //}
            //sum(1, 2, 3);

            #endregion
            #region Geriye Değer Döndüren Metotlar String MethodAdi()
            //string YemVer()
            //{
            //    return "Kuş Beslendi";
            //}
            //Console.WriteLine(YemVer());

            #endregion
            #region Geriye Değer Döndüren Parametreli Metotlar String MethodAdi(String Name, Surname)
            //string KimlikKartıOlustur(string name, string surname)
            //{
            //    string KartBilgi = name + surname;
            //    return KartBilgi;
            //}
            //Console.WriteLine(KimlikKartıOlustur("Ali","BİRGÜLLÜ"));
            //Console.WriteLine(KimlikKartıOlustur("Leyla","PAPAĞAN"));
            //Console.WriteLine(KimlikKartıOlustur("Kartal","TİBET"));
            //Console.WriteLine(KimlikKartıOlustur("Mogli","TARZAN"));

            #endregion
            #region  Geriye Değer Döndüren Parametreli Metotlar İnt MethodAdi(int dogumtarihi, int date )
            //int yashesapla(int dogumtarihi, int date)
            //{
            //    int yas = date-dogumtarihi;
            //    return yas;
            //}
            //Console.WriteLine(yashesapla(2002, 2025));
            #endregion
            #region Örnek Uygulama
            string SinavSonuc(string OgrenciAdi,double VizeNotu, double FinalNotu)
            {
                double sonuc = (VizeNotu * 0.4 + FinalNotu * 0.6);
                if (sonuc >=50)
                { return OgrenciAdi + " İsimli Öğrenci Sınavdan Geçti  Ortalaması :" + sonuc; }
                else
                { return OgrenciAdi + " İsimli Öğrenci Sınavdan Kaldı  Ortalaması :" + sonuc; }
            }
            Console.Write("Adı Soyadı :");
            string x = Console.ReadLine();
            Console.Write("Vize Notu :");
            int y =int.Parse(Console.ReadLine());
            Console.Write("Final Notu :");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("**************");
            Console.WriteLine("");
            Console.WriteLine("SONUÇ");
            Console.WriteLine(SinavSonuc(x, y, z));

            #endregion
            Console.Read();
        }
    }
}
