using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _10_DatabaseCrud
{



    internal class Program
    {

        static MySqlConnection con;


        static void baglantiAc()
        {
            string baglanti = "server=localhost; uid=root; pwd=root; database=egitimkampidb;";
            con = new MySqlConnection(baglanti);
            con.Open();
        }
        static void baglantiKapat()
        {
            string baglanti = "server=localhost; uid=root; pwd=root; database=egitimkampidb;";
            con = new MySqlConnection(baglanti);
            con.Close();
        }
       
        static void Main(string[] args)
        {
            //CRUD-> CREATE READ UPDATE DELETE
            #region Kategori Ekleme 
            Console.WriteLine("Menü Sipariş İşlem Paneli");
            Console.WriteLine("");
            Console.WriteLine("***********************");
            //Console.Write("Eklemek istediğiniz kategori adını giriniz : ");
            //string categoryname = Console.ReadLine();
            //string baglanti = "server=localhost; uid=root; pwd=root;database=egitimkampidb";
            //MySqlConnection con = new MySqlConnection(baglanti);
            //con.Open();
            //MySqlCommand kategotiekleme = new MySqlCommand("insert into category (CategoryName) values (@p1)", con);
            //kategotiekleme.Parameters.AddWithValue("@p1", categoryname);
            //kategotiekleme.ExecuteNonQuery();
            //con.Close();
            //Console.WriteLine("Kategori Başarı İle Eklendi");
            #endregion
            #region Ürün Ekleme
            //Console.Write("Eklemek İstediğiniz Ürün Adını Giriniz : ");
            //string ProductName= Console.ReadLine();
            //Console.Write("Eklemek İstediğiniz Ürün fiyatı : ");
            //decimal ProductPrice=decimal.Parse(Console.ReadLine());
            //baglantiAc();
            //MySqlCommand cmd = new MySqlCommand("insert into product (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", con);
            //cmd.Parameters.AddWithValue("@p1", ProductName);
            //cmd.Parameters.AddWithValue("@p2", ProductPrice);
            //cmd.Parameters.AddWithValue("@p3", true);
            //cmd.ExecuteNonQuery();
            //baglantiKapat();
            //Console.WriteLine("Ürün Eklemesi Başarılı.");







            #endregion
            #region Ürün Lİsteleme
            //baglantiAc();
            //MySqlCommand cmd = new MySqlCommand("Select * From product", con);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item  in row.ItemArray) 
            //    {
            //        Console.Write(item.ToString());

            //    }
            //    Console.WriteLine();
            //}
            //baglantiKapat();
            #endregion
            #region Ürün Silme
            //baglantiAc();
            //Console.Write("Silinecek Ürün İD giriniz : ");
            //int productid = int.Parse(Console.ReadLine());
            //MySqlCommand cmd = new MySqlCommand("Delete From product where idproduct=@p1",con);
            //cmd.Parameters.AddWithValue("@p1", productid);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine($"{productid} Numaralı ürün silindi.");
            //baglantiKapat();
            #endregion
            #region Ürün Güncelleme
            //baglantiAc();
            //Console.Write("Güncellemek istediğiniz Ürün İd Giriniz : ");
            //int idproduct=int.Parse(Console.ReadLine());
            //MySqlCommand urunlisteme = new MySqlCommand("Select * From product where idproduct=@p1",con);
            //urunlisteme.Parameters.AddWithValue("@p1", idproduct);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(urunlisteme);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow dr in dt.Rows) {
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($" {idproduct} id'li ürünün Durumu : [1] Mevcut [0] Stokta Yok");
            //int urundegeri = int.Parse(Console.ReadLine());
            //        MySqlCommand guncelle = new MySqlCommand("Update product Set ProductStatus=@ps where idproduct=@p1 ", con);
            //switch (urundegeri)
            //{
            //    case 1: Console.WriteLine("Ürün Artık Mevcut");
            //        guncelle.Parameters.AddWithValue("@ps", urundegeri);
            //        guncelle.Parameters.AddWithValue("@p1", idproduct);
            //    guncelle.ExecuteNonQuery();
            //        break;
            //    case 0: Console.WriteLine("Ürün Stokta Yok");
            //        guncelle.Parameters.AddWithValue("@ps", urundegeri);
            //        guncelle.Parameters.AddWithValue("@p1", idproduct);
            //        guncelle.ExecuteNonQuery(); 
            //        Console.WriteLine("Ürün Durumu Güncellendi") ;
            //        break;
            //}
            //baglantiKapat();
            #endregion<
            Console.Read();
        }
       
    }
}
