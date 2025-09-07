using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İf-else Yapısı
            //string password; 
            //Console.WriteLine("Lütfen Parolayı giriniz");
            //password = Console.ReadLine();
            //if (password == "samet")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else {
            //    Console.WriteLine("Hatalı Giriş Yaptınız");
            //}

            //Sınav Ortalaması ve Harf Notu Hesaplama 
            //double vize, final, Sonuc;
            //Console.WriteLine(" Vize Notunu Giriniz");
            //vize=double.Parse(Console.ReadLine());
            //Console.WriteLine("Final Notunu Giriniz");
            //final=double.Parse(Console.ReadLine());
            //Sonuc = (vize * 0.4) + (final * 0.6);
            //if (Sonuc<=100 && Sonuc>80)
            //{
            //    Console.WriteLine(" Geçtiniz. Sınav Notunuz :" + " " + Sonuc + " " +" Harf Notunuz" + " " + "AA");
            //}
            //if (Sonuc<80 && Sonuc>=60)
            //{
            //    Console.WriteLine("Geçtiniz. Sınav Notunuz :" + " " + Sonuc + " " +" Harf Notunuz" + " " + "BB");
            //}
            //if (Sonuc<60 && Sonuc>=40)
            //{
            //    Console.WriteLine("Geçtiniz. Sınav Notunuz :" + " " + Sonuc + " " +" Harf Notunuz" + " " + "CC");
            //}
            //if (Sonuc<40 && Sonuc>=20)
            //{
            //    Console.WriteLine("Şarlı Geçtiniz. Sınav Notunuz :" + " " + Sonuc + " " +" Harf Notunuz" + " " + "DD");
            //}
            //if (Sonuc < 20 && Sonuc >= 0)
            //{
            //    Console.WriteLine("Kaldınız. Sınav Notunuz :" + " " + Sonuc + " " + " Harf Notunuz" + " " + "FF");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen Sonuçları Doğru Giriniz");
            //}


            #endregion
            #region Mod İşlemleri
            //int number = 25;
            //int result = number % 4;
            //Console.WriteLine(result);

            ///Mod hesaplatma

            //double num1, num2, result;
            //Console.Write("Modunu Almak İstediğiniz Sayıyı Giriniz : ");
            //num1=Convert.ToDouble(Console.ReadLine()); // buda başka bir dönüşüm şeklidir. parse parçalar convert dönüştürür.
            //Console.Write("Hangi Sayıya Göre Mod Almak İstiyorsunuz : ");
            //num2=Convert.ToDouble(Console.ReadLine());
            //result = num1 % num2;
            //Console.WriteLine(num1+" Sayısının "+ num2 +" Sayısına Göre Modu Şudur => " + result);

            //Sayı Tek mi? Çift mi ?
            //int num3;
            //Console.Write("Sayı Giriniz : ");
            //num3=int.Parse(Console.ReadLine());
            //if (num3 % 2 == 0)
            //{
            //    Console.WriteLine(num3 + " Sayısı çift sayıdır.");
            //}
            //else { Console.WriteLine(num3 + " Sayısı tek sayıdır."); }

            #endregion
            #region by if else write Example Application

            //Console.WriteLine("*****C# Eğitim Kütüphanesi*****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("1-Tıp Bölümü");
            //Console.WriteLine("2-Kimya Bölümü");
            //Console.WriteLine("3-Yazılım Bölümü");
            //Console.WriteLine("4-Fizik Bölümü");
            //Console.WriteLine("5-Matematik Bölümü");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();

            //string MenuItem;
            //Console.Write("İncelemek İstediğiniz Branş Numarasını Giriniz : ");
            //MenuItem = Console.ReadLine();
            //if (MenuItem == "1") { Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-İnsan Anatomisi "); Console.WriteLine("2-Beyin Ve Sinir Ağları"); Console.WriteLine("3-Kardiyal Anjiyo"); Console.WriteLine("----------------"); }
            //if (MenuItem == "2") { Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-Polarizasyon"); Console.WriteLine("2-Organik Kimya"); Console.WriteLine("3-Elementler"); Console.WriteLine("4-Simya Bilimi"); Console.WriteLine("----------------"); } 
            //if (MenuItem == "3") { Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-C#Eğitim"); Console.WriteLine("2-Programlamaya Giriş"); Console.WriteLine("3-Algoritmalar");Console.WriteLine("4-Veri Yapıları"); Console.WriteLine("5-Ağ Mimarisi"); Console.WriteLine("----------------"); }
            //if (MenuItem == "4") { Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-Kuantum Mekaniği");Console.WriteLine("2-Momentum");Console.WriteLine("3-Hız,İvme,Sürat");Console.WriteLine("4-Vektörler");  Console.WriteLine("----------------"); }
            //if (MenuItem == "5") { Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-Fonksiyonlar"); Console.WriteLine("2-LinearCebir"); Console.WriteLine("3-Diferansiyel Denklemler"); Console.WriteLine("----------------"); }
            //else{Console.WriteLine("Hatalı Sayı Girdiniz");}

            #endregion
            #region Switch-Case
            ////Az önce yaptığımız if-else mantığıyla yaptığımız örneği switch- case ile ne kadar kolay hale getiriyoruz görelim.
            //Console.WriteLine("*****C# Eğitim Kütüphanesi*****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("1-Tıp Bölümü");
            //Console.WriteLine("2-Kimya Bölümü");
            //Console.WriteLine("3-Yazılım Bölümü");
            //Console.WriteLine("4-Fizik Bölümü");
            //Console.WriteLine("5-Matematik Bölümü");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();
            //string MenuItem;
            //Console.Write("İncelemek İstediğiniz Branş Numarasını Giriniz : ");
            //MenuItem = Console.ReadLine();
            //switch (MenuItem)
            //{
            //    case "1": Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-İnsan Anatomisi "); Console.WriteLine("2-Beyin Ve Sinir Ağları"); Console.WriteLine("3-Kardiyal Anjiyo"); Console.WriteLine("----------------"); break;
            //    case "2": Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-Polarizasyon"); Console.WriteLine("2-Organik Kimya"); Console.WriteLine("3-Elementler"); Console.WriteLine("4-Simya Bilimi"); Console.WriteLine("----------------"); break;
            //    case "3": Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-C#Eğitim"); Console.WriteLine("2-Programlamaya Giriş"); Console.WriteLine("3-Algoritmalar"); Console.WriteLine("4-Veri Yapıları"); Console.WriteLine("5-Ağ Mimarisi"); Console.WriteLine("----------------"); break;
            //    case "4": Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-Kuantum Mekaniği"); Console.WriteLine("2-Momentum"); Console.WriteLine("3-Hız,İvme,Sürat"); Console.WriteLine("4-Vektörler"); Console.WriteLine("----------------"); break;
            //    case "5": Console.WriteLine(); Console.WriteLine("----------------"); Console.WriteLine("1-Fonksiyonlar"); Console.WriteLine("2-LinearCebir"); Console.WriteLine("3-Diferansiyel Denklemler"); Console.WriteLine("----------------"); break;
            //        default: Console.WriteLine("Hatalı Sayı Girdiniz."); break;
            //}

            #endregion
            #region by Switch-Case Calcilator Application
            //double num1, num2, result;
            //char symbol;
            //Console.WriteLine("*****Hesap Makinesi*****");
            //Console.WriteLine();
            //Console.Write("Birinci Sayıyı Giriniz : ");
            //num1 =double.Parse(Console.ReadLine());
            //Console.Write("İkinciSayısıGiriniz : ");
            //num2 =double.Parse(Console.ReadLine());
            //Console.Write("Yapmak istediğiniz işlemi Giriniz : ");
            //symbol= char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '-': result = num1 - num2; Console.WriteLine("Sonucunuz => " + result); break;
            //    case '+': result = num1 + num2; Console.WriteLine("Sonucunuz => " + result); break;
            //    case '*': result = num1 * num2; Console.WriteLine("Sonucunuz => " + result); break;  
            //    case '/': result = num1 / num2; Console.WriteLine("Sonucunuz => " + result); break;
            //    default: Console.WriteLine("Hatalı Giriş Yaptınız."); break;

            //}


            #endregion
            Console.Read();
        }
    }
}
