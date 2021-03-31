﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane
{    /*
     Odev : Bir cift Tavsanimiz var . Bu tavsanlar yavrudur.
            Yavru tavsanlar bir ay icerisinde ergenlige ulasmaktadir.
            Ergenlesen her cift tavsan bir ay sonra bir cift tavsan dogurmaktadir.
            Bu matematige gore de tavsanlar ölümsüzdür.
            100 ay  sonra kac tavsanim olur ?     
     */
    /*     
     Odev : Ekrandan alinacak 3 adet sayiyi kucukten buyuge dogru siralayin     
     */
    /*     
     8 veziri satranc tahtasina birbirini yemeyecek sekilde diziniz.
     Programini yapmayin. Sadece tahtada calisin
     */

    public static class GenelStaticMetodlar
    {
        public static void CarpimTaplosu()
        {
            //Ceren Sahin Cozumu

            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
        }
        public static void Faktoryel(int sayi)
        {
            // Teoman Yanmaz Cozumu

            ulong faktoriyel = 1;
            //int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi; i > 0; i--)
            {
                faktoriyel = (ulong)i * faktoriyel;
            }
            Console.WriteLine(faktoriyel);
        }
        public static int EkrandanSayiOku()
        {
            int sayi = 0;
            string str = "";
            Console.Write("Bir Sayi Giriniz:");
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }
    }
    public class GenelMetodlar
    {

        /// <summary>
        /// Verilen sayiya kadar olan fibanocci sayilarini ekrana basar
        /// </summary>
        /// <param name="sayiAdet"></param>
        public void Fibanocci(int sayiAdet)
        {
            decimal  birinciSayi = 0;
            decimal ikinciSayi = 1;
            decimal temp;
            for (int i = 0; i < sayiAdet; i++)
            {
                Console.WriteLine($"{i}.Sayi: {birinciSayi}");
                temp = ikinciSayi;
                ikinciSayi = birinciSayi + ikinciSayi;
                birinciSayi = temp;
                if (i < sayiAdet - 1)
                    Console.Write(",");
            }
        
        }

        public void fibanocciDizi()
        {
            // Dizinin boyutunu ve tipini belirleyelim .


            int boyut = EkrandanSayiOku("Fibanocci Dizisinin Ust Limitini giriniz:");


            // ULong tipinden ekrandan alinan sayi boyutunda bir dizi olusturur

            ulong[] fibanocci = new ulong[boyut];
            for (int i = 0; i < boyut; i++)
            {
                //Sifira Esitse 
                if (i == 0)
                {
                    fibanocci[i] = 0;
                }
                else if (i == 1)
                {
                    fibanocci[i] = 1;
                }
                else // Birden buyukse
                {
                    fibanocci[i] = fibanocci[i - 1] + fibanocci[i - 2];
                }

                Console.WriteLine($"fibanocci[{i + 1}]:{fibanocci[i]}");
            }


        }

        /// <summary>
        /// Carpim tablosunu Console da gosterir
        /// </summary>
        public void CarpimTaplosu()
        {
            //Ceren Sahin Cozumu

            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Verilen sayinin faktoryelini  hesaplar
        /// </summary>
        /// <param name="sayi">integer tipinden olmalidir</param>
        /// <returns>ulong tipinden </returns>
        public ulong Faktoryel(int sayi)
        {
            // Teoman Yanmaz Cozumu

            ulong faktoriyel = 1;
            //int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi; i > 0; i--)
            {
                faktoriyel = (ulong)i * faktoriyel;
            }
            //Console.WriteLine(faktoriyel);
            return faktoriyel;
        }
        public int EkrandanSayiOku()
        {
            int sayi = 0;
            string str = "";
            Console.Write("Bir Sayi Giriniz:");
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }
        public int EkrandanSayiOku(string ifade)
        {
            int sayi = 0;
            string str = "";
            Console.Write(ifade);
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }
        public long EkrandanSayiOku(string ifade,int deger)
        {
            int sayi = 0;
            string str = "";
            Console.Write(ifade);
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }
    }
   
}