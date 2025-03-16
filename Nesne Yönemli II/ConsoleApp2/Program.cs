using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Lisans lisans = new Lisans();
            YuksekLisans yuksekLisans = new YuksekLisans();
            Console.Write("Lisans öğrencisinin adı soyadı: ");
            lisans.AdSoyad = Console.ReadLine();
            Console.Write("Yüksek lisans öğrencisinin adı soyadı: ");
            yuksekLisans.AdSoyad = Console.ReadLine();
            for (int i = 1; i < 10; i++)
            {
                int vize = new Random().Next(0, 101);
                int final = new Random().Next(0, 101);
                lisans.TumDersler.Add(new Ders(vize, final, "dersLisans" + i));
            }
            lisans.AldigiDersSayisi = lisans.TumDersler.Count;
            for (int i = 1; i < 10; i++)
            {
                int vize = new Random().Next(0, 101);
                int final = new Random().Next(0, 101);
                yuksekLisans.TumDersler.Add(new Ders(vize, final, "dersYuksekLisans" + i));
            }
            yuksekLisans.AldigiDersSayisi = yuksekLisans.TumDersler.Count;
            lisans.GecilenKalinanEkle();
            yuksekLisans.GecilenKalinanEkle();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lisans Öğrencisi : " + lisans.AdSoyad + ", Aldığı Ders Sayısı: "+ lisans.AldigiDersSayisi);
            Console.ForegroundColor = ConsoleColor.White;
            lisans.DersleriYazdir();
            lisans.GecilenDersleriYazdir();
            lisans.KaldigiDersleriYazdir();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yüksek Lisans Öğrencisi : " + yuksekLisans.AdSoyad + ", Aldığı Ders Sayısı: " + yuksekLisans.AldigiDersSayisi);
            Console.ForegroundColor = ConsoleColor.White;
            yuksekLisans.DersleriYazdir();
            yuksekLisans.GecilenDersleriYazdir();
            yuksekLisans.KaldigiDersleriYazdir();
            lisans.BitirmeProjesi();
            yuksekLisans.Tez();
            Console.ReadKey();
        }
    }
}
