using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //degiskenler();
            Vatandas vatandas1 = new Vatandas();
            vatandas1.Ad="muhammed";
            SelamVer("muhammed");
            SelamVer("melih");
            SelamVer();
      
            int sonuc = Topla(6,58);
            Console.WriteLine(sonuc);

            //Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "engin";
            ogrenciler[1] = "kerem";
            ogrenciler[2] = "berkay";
            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "ankar", "istanbul", "izmir" };
            string[] sehirler2 = new[] {"bursa","antalya","diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine("buraaaa "+sehirler2[0]);


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            Person person1 = new Person();
            person1.FirstName = "MUHAMMED";
            person1.LastName = "TAPLAMACI";
            person1.NationalIdentity = 123;
            person1.DateOfBirthYear = 1985;


            List<string> yenisehirler1 = new List<string> { "ankara","istanbul","izmir" };
            yenisehirler1.Add("Adana 1");
            Console.WriteLine("----------------");
            foreach (var sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba "+ isim);
        }

        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+sonuc.ToString());
            return sonuc;
        }

        private static void degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            double oran = 1.18;
            int sayi = 100;
            bool isAutonticate = false;
            string ad = "muhammed";
            string soyad = "muhammed";
            int dogumYili = 1996;
            long tcNo = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * oran);
        }
    }
    class Vatandas
    {
       
       
      
        public string Ad { get; set; }
        public string Aoyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
