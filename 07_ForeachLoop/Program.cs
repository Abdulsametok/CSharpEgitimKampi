using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        enum DersDurum { Kaldı, Geçti }
        static void Main(string[] args)
        {
            #region ForeachDongusu
            ////foreach(1;2;3;4)
            //// 1 : değişken türü
            //// 2 : değişken takma adı
            //// 3 : in
            //// 4  : liste,koleksiyon, dizi adi
            //// "4" dizinin "3" içindeki "2" takma isimli "1" değişken türlü değer 
            //List<string> KadinAdlari = new List<string>()
            //{
            //    "Selma", "Ayşe"
            //};

            //foreach (string w in KadinAdlari)
            //{
            //    Console.WriteLine(w);
            //}
            #endregion
            #region OgreciNotOrtalamasi
            // Sınıftaki öğrencilerin  ad soyad + vize + final notlarını girip sınıf ortalaması ve öğrencilerin
            // not durumlarını yazdıran programı tasarlayınız.
            int ToplamOgrenciSayisi;
            Console.WriteLine("********- C# Eğitim Kampı Sınav Sonuç Uygulaması -********");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Sınıftaki Öğrenci Sayısını Giriniz :");
            ToplamOgrenciSayisi=int.Parse(Console.ReadLine());
            string[] OgrenciAdları = new string[ToplamOgrenciSayisi];
            double[] VizeNotlari=new double[ToplamOgrenciSayisi];
            double[] FinalNotlari=new double[ToplamOgrenciSayisi];
            double[] NotOrtalamasi= new double[ToplamOgrenciSayisi];
            double SınıfOrtalaması = 0;


            Console.WriteLine("-----------Öğrenci Bilgileri-----------");
            for (int i = 0;OgrenciAdları.Length > i;i++)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}. Öğrencinin adını giriniz : ");
                OgrenciAdları[i]= Console.ReadLine();
                Console.Write($"{OgrenciAdları[i]} isimli Öğrencinin Vize Notunu Giriniz : ");
                VizeNotlari[i] = double.Parse(Console.ReadLine());
                Console.Write($"{OgrenciAdları[i]} isimli Öğrencinin Final Notu Giriniz : ");
                FinalNotlari[i] = double.Parse(Console.ReadLine());
                NotOrtalamasi[i] = (FinalNotlari[i] * 0.6) + (VizeNotlari[i] * 0.4);
            }
            Console.WriteLine("-----------Öğrenci Bilgileri-----------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            double ToplamSınıfNotları = 0;
            Console.WriteLine("-----------Sınav Sonuçları-----------");
            for (int i = 0; i < ToplamOgrenciSayisi; i++)
            {
                DersDurum durum = DersDurum.Kaldı;

                if ( NotOrtalamasi[i]>=0 && NotOrtalamasi[i] <= 49)
                {
                    durum = DersDurum.Kaldı;
                }
                if (NotOrtalamasi[i] >= 50 && NotOrtalamasi[i] <=100)
                {
                    durum = DersDurum.Geçti;
                }
                
                
                Console.WriteLine($"{OgrenciAdları[i]} İsimli Öğrencinin Not Ortalaması: {NotOrtalamasi[i]} Ders Durumu: {durum}");
                ToplamSınıfNotları += NotOrtalamasi[i];

            }
            
            Console.WriteLine($"Sınıf Ortalaması : {ToplamSınıfNotları/ToplamOgrenciSayisi}");
            Console.WriteLine("-----------Sınav Sonuçları-----------");




            #endregion
            Console.Read();
        }
    }
}
