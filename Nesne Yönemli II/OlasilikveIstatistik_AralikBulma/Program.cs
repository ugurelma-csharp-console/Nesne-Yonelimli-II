
using System;

namespace OlasilikveIstatistik_AralikBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IstatistikVeriler istatistikVeriler = new IstatistikVeriler();
            istatistikVeriler.AralikHesapla();
            Console.ReadKey();
        }
    }
}
