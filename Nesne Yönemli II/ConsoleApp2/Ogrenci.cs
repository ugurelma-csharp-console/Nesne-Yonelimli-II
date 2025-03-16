using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Ogrenci: IKisi
    {
        public List<Ders> TumDersler {  get; set; }
        public List<Ders> GecilenDersler {  get; set; }
        public List<Ders> KaldigiDersler { get; set; }
        public int AldigiDersSayisi { get; set; }
        public string AdSoyad { get; set; }

        public Ogrenci()
        {
            TumDersler = new List<Ders>();
            GecilenDersler = new List<Ders>();
            KaldigiDersler = new List<Ders>();
            AldigiDersSayisi = 0;
        }

        /// <summary>
        /// Bütün dersleri girdikten sonra çalıştırılması gerek fonksiyondur!
        /// </summary>
        public void GecilenKalinanEkle()
        {
            foreach (var alinanDers in TumDersler)
            {
                if (alinanDers.ortalama >= 50)
                    GecilenDersler.Add(alinanDers);
                else if (alinanDers.ortalama >= 0)
                    KaldigiDersler.Add(alinanDers);
                else
                    Console.WriteLine("Bir ders ortalaması 0 dan küçük olamaz! Ders: " + alinanDers.dersAdi + " Ogrenci: " + alinanDers.ogrenci.AdSoyad);
            }
        }

        public void DersleriYazdir()
        {
            Console.WriteLine("--> Tüm Dersleri <--");
            foreach (var alinanDers in TumDersler)
            {
                Console.WriteLine("Ders Adı: " + alinanDers.dersAdi + " Vize: " + alinanDers.vize + " Final: " + alinanDers.final + " Ortalama: " + alinanDers.ortalama);
            }
        }
        public void GecilenDersleriYazdir()
        {
            Console.WriteLine("--> Geçtiği Dersler <--");
            foreach (var gecilenDers in GecilenDersler)
            {
                Console.WriteLine("Ders Adı: " + gecilenDers.dersAdi + " Vize: " + gecilenDers.vize + " Final: " + gecilenDers.final + " Ortalama: " + gecilenDers.ortalama);
            }
        }
        public void KaldigiDersleriYazdir()
        {
            Console.WriteLine("--> Kaldığı Dersler <--");
            foreach (var kalinanDers in KaldigiDersler)
            {
                Console.WriteLine("Ders Adı: " + kalinanDers.dersAdi + " Vize: " + kalinanDers.vize + " Final: " + kalinanDers.final + " Ortalama: " + kalinanDers.ortalama);
            }
        }
        public void DersAra(string dersAdi)
        {
            foreach (var alinanDers in TumDersler)
            {
                if (dersAdi == alinanDers.dersAdi)
                    Console.WriteLine("Ders Adı: " + alinanDers.dersAdi + " Vize: " + alinanDers.vize + " Final: " + alinanDers.final + " Ortalama: " + alinanDers.ortalama);
            }
        }
    }
}
