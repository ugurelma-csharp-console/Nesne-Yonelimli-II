using System;
using System.Collections.Generic;

namespace OlasilikveIstatistik_AralikBulma
{
    internal class IstatistikVeriler
    {
        /// <summary>
        /// Hangi tablonun kullanılacağı hakkında bilgi verir.
        /// </summary>
        private bool varyansVarMi;
        /// <summary>
        /// Eğer ortalama var ise verileri girmesine gerek yoktur.
        /// </summary>
        private bool ortVarMi;
        /// <summary>
        /// İşlenecek olan verilerdir.
        /// </summary>
        private List<int> veriler;
        /// <summary>
        /// Eğer ortalama verilmişse kullanıcıdan alınacak diğer durumda veriler listesinden count alınacaktır.
        /// </summary>
        private int veriSayisi;
        /// <summary>
        /// Ortalama verilmişse ona eşit verilmemişse verilerin toplamının toplam veri sayısına oranına eşittir. 
        /// </summary>
        private double ortalama;
        /// <summary>
        /// Varyans biliniyorsa onun kareköküdür bilinmiyorsa gerekli hesaplama ile bulunacaktır.
        /// </summary>
        private double sSapma;
        /// <summary>
        /// Varyans varsa ona eşittir yoksa boş kalacaktır.
        /// </summary>
        private double varyans;
        /// <summary>
        /// Hangi tablo kullanılacaksa o tablodaki değeridir.
        /// </summary>
        private double tabloDegeri;
        /// <summary>
        /// Hangi güven düzeyi ile bu aralık belirlenecektir? Buradan anlamlılık düzeyi bulunacaktır.
        /// </summary>
        private double guvenDuzeyi;

        public IstatistikVeriler()
        {
            varyansVarMi = VaryansVarMi();
            varyans = (varyansVarMi) ? VaryansHesapla() : 0;
            ortVarMi = OrtVarMi();
            veriler = (ortVarMi) ? null : VerileriAl();
            ortalama = OrtalamaHesapla();
            veriSayisi = (!ortVarMi) ? veriler.Count : VeriSayisiAl();
            sSapma = (varyansVarMi) ? Math.Sqrt(varyans) : StandartSapma();
            guvenDuzeyi = GuvenDuzeyi();
            tabloDegeri = TabloDegeri();
        }

        private double TabloDegeri()
        {
            double result = 0;
            while (true)
            {
                Console.Write("Lütfen " + HangiTablo(varyansVarMi, veriSayisi) + " tablosundaki " + (100 - guvenDuzeyi) / 100 + " güven düzeyinin değerini giriniz: ");
                try
                {
                    result = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
            return result;
        }
        private double GuvenDuzeyi()
        {
            double result = 0;
            while (true)
            {
                Console.Write("Lütfen güven düzeyini giriniz: ");
                try
                {
                    result = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
            return result;
        }

        private bool OrtVarMi()
        {
            while (true)
            {
                Console.Write("Eğer ortalama varsa 1 yoksa 0 giriniz: ");
                try
                {
                    int data = int.Parse(Console.ReadLine());
                    if (data == 0)
                        return false;
                    else if (data == 1)
                        return true;
                    else
                        return OrtVarMi();
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
        }

        private bool VaryansVarMi()
        {
            while (true)
            {
                Console.Write("Eğer varyans varsa 1 yoksa 0 giriniz: ");
                try
                {
                    int data = int.Parse(Console.ReadLine());
                    if (data == 0)
                        return false;
                    else if (data == 1)
                        return true;
                    else
                        return VaryansVarMi();
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
        }

        private List<int> VerileriAl()
        {
            List<int> result = new List<int>();
            while (true)
            {
                Console.Write("Eğer veri varsa veriyi yaz yoksa -1 giriniz: ");
                try
                {
                    int data = int.Parse(Console.ReadLine());
                    if (data == -1)
                        break;
                    else
                        result.Add(Math.Abs(data));
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
            return result;
        }

        private int VeriSayisiAl()
        {
            int result;
            while (true)
            {
                Console.Write("Lütfen veri sayısını giriniz: ");
                try
                {
                    result = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
            return result;
        }

        private double OrtalamaHesapla()
        {
            double result = 0;
            if (ortVarMi)
            {
                while (true)
                {
                    Console.Write("Lütfen ortalamayı giriniz: ");
                    try
                    {
                        result = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş yaptınız!");
                    }
                }
                return result;
            }
            else
            {
                for (int i = 0; i < veriSayisi; i++)
                    result += veriler[i];
                return result / veriSayisi;
            }
        }

        private double VaryansHesapla()
        {
            double result = 0;
            while (true)
            {
                Console.Write("Lütfen varyansı giriniz: ");
                try
                {
                    result = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
            return result;
        }

        private double StandartSapma()
        {
            double result = 0;
            if (ortVarMi)
            {
                while (true)
                {
                    Console.Write("Lütfen standart sapma değerini giriniz: ");
                    try
                    {
                        result = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş yaptınız!");
                    }
                }
            }
            else if (veriler.Count > 0)
            {
                for (int i = 0; i < veriSayisi; i++)
                    result += Math.Pow(veriler[i] - ortalama, 2);
                result /= veriSayisi - 1;
                result = Math.Sqrt(result);
            }

            return result;
        }

        /// <summary>
        /// Bu metot ile hangi tablonun kullanılacağı belirlenecektir.
        /// </summary>
        /// <param name="varyansVarMi"></param>
        /// <param name="veriSayisi"></param>
        /// <returns></returns>
        private string HangiTablo(bool varyansVarMi, int veriSayisi) => (!varyansVarMi && veriSayisi < 30) ? "T" : "Z";

        /// <summary>
        /// Cevap için bu metotun çağrılması gerekiyor.
        /// </summary>
        public void AralikHesapla()
        {
            double min = ortalama - (tabloDegeri * sSapma / Math.Sqrt(veriSayisi));
            double max = ortalama + (tabloDegeri * sSapma / Math.Sqrt(veriSayisi));
            Console.WriteLine("% " + guvenDuzeyi + " güven düzeyi ile aralık: " + min + " < x < " + max);
        }
    }
}
