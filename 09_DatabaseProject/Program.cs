using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tablenumber;
            #region VeriTabanıİslemleri
            Console.Write("C# Veri Tabanlı Ürün- Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış YAP");
            Console.Write("Lütfen Yapmak istediğiniz işlemin numarasını giriniz : ");
            tablenumber = Console.ReadLine();
            Console.WriteLine("--------------------------");
            string connStr = "server=localhost;Uid=root;Pwd=root;database=egitimkampidb;";
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM category", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i]);
                    
                }
                Console.WriteLine();
            }
            con.Close();
         
            #endregion
            Console.Read();

        }
    }
}
