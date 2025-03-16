using System;
using System.Collections.Generic;

internal class BFS
{
    /// <summary>
    /// Başlangıçta verilen veri grubudur.
    /// </summary>
    private List<Veri> veriGrubu;
    /// <summary>
    /// Gezilen verilerin eklendiği listedir.
    /// </summary>
    private List<Veri> gezilenler;
    /// <summary>
    /// Çocukları gezilmeyen ebeveynin indisini tutuan değerdir.
    /// </summary>
    private int gezilenIndis;

    internal BFS()
    {
        veriGrubu = new List<Veri>();
        gezilenler = new List<Veri>();
        VeriGrubunaEkle();
        gezilenIndis = 0;
    }

    /// <summary>
    /// Burada verileri ilişkileri ile oluşturup veri grubuna sırasıyla ekliyoruz.
    /// </summary>
    private void VeriGrubunaEkle()
    {
        Veri I = new Veri("I", null);
        Veri J = new Veri("J", null);
        Veri H = new Veri("H", null);
        Veri G = new Veri("G", null);
        Veri F = new Veri("F", null);
        Veri E = new Veri("E", new Veri[2] { H, J });
        Veri D = new Veri("D", new Veri[2] { F, G });
        Veri C = new Veri("C", new Veri[2] { D, E });
        Veri B = new Veri("B", new Veri[1] { I });
        Veri A = new Veri("A", new Veri[3] { B, D, C });
        veriGrubu.Add(A);
        veriGrubu.Add(B);
        veriGrubu.Add(C);
        veriGrubu.Add(D);
        veriGrubu.Add(E);
        veriGrubu.Add(F);
        veriGrubu.Add(G);
        veriGrubu.Add(H);
        veriGrubu.Add(I);
        veriGrubu.Add(J);
        veriGrubu[0].gezildiMi = true;
        gezilenler.Add(veriGrubu[0]);
        Console.WriteLine(gezilenler[0].degeri + " verisi gezildi ve listeye eklendi.");
        CevabiDonder(gezilenler[0]);
    }
    /// <summary>
    /// Ebeveyn verisini alan ve sonra gezilmeyen bütün çocuklarının listeye ekleyen fonksiyondur.
    /// </summary>
    /// <param name="veri"></param>
    private void CevabiDonder(Veri veri)
    {
        if (veri.cocuklari != null)
        {
            for (int i = 0; i < veri.cocuklari.Length; i++)
            {
                if (!veri.cocuklari[i].gezildiMi)
                {
                    veri.cocuklari[i].gezildiMi = true;
                    gezilenler.Add(veri.cocuklari[i]);
                    Console.WriteLine(veri.cocuklari[i].degeri + " verisi gezildi ve listeye eklendi.");
                }
                else
                    Console.WriteLine(veri.cocuklari[i].degeri + " verisi daha önceden gezildiği için listeye eklenmedi.");
            }
        }
        if (gezilenIndis + 1 != veriGrubu.Count)
            CevabiDonder(gezilenler[++gezilenIndis]);
        else
            Console.WriteLine("\nBulunan sıra: " + CevabiVer());
    }
    /// <summary>
    /// Bütün veriler gezildiğinde gezilenler listesindeki verileri sırsıyla veren fonksiyondur.
    /// </summary>
    /// <returns></returns>
    private string CevabiVer()
    {
        string sira = "";
        for (int i = 0; gezilenler.Count > i; i++)
        {
            sira += (i != gezilenler.Count - 1) ? gezilenler[i].degeri + ", " : gezilenler[i].degeri;
        }
        return sira;
    }
}
/// <summary>
/// Her bir veri sınıfıdır.
/// </summary>
internal class Veri
{
    internal string degeri;
    internal bool gezildiMi;
    internal Veri[] cocuklari;

    internal Veri(string degeri, Veri[] cocuklari)
    {
        this.degeri = degeri;
        gezildiMi = false;
        this.cocuklari = cocuklari;
    }
}