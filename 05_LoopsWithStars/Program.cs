using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 yıldız

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine("*",i);
            //}

            #endregion
            #region Yan Yana 10 yıldız

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.Write("*", i);
            //}

            #endregion
            #region Alt Alta 10 yıldız her satırda 10 tane yıldız.

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine("***********",i);
            //}

            #endregion
            #region Dik Ucgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion
            #region Ters Dik Ucgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Elmas

            // for (int b = 0; b < 3; b++) // döngü tekrarlama
            // {
            //  Console.WriteLine("");

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            // }
            #endregion
            #region Piramit
            int bosluk = 3;
            for (int i = 0; i < bosluk; i++)
            {
                for (int j = bosluk-1; j > 0; j--)
                {

                    Console.Write(" ");
                }
            }

            #endregion
            Console.Read();
        }
    }
}
