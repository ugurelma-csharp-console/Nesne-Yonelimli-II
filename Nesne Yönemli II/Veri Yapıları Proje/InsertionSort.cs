using System;
using System.Collections.Generic;

internal class InsertionSort
{
    /// <summary>
    /// Veri grubunu tutan bir tam sayı listesidir.
    /// </summary>
    private List<int> veriGrubu = new List<int>() { 3, 8, 15, 4, 23, 2, 39, 5, 12, 10 };
    /// <summary>
    /// Aktif gruplamadaki veri sayısıdır.
    /// </summary>
    private int grupElemanSayisi = 2;
    /// <summary>
    /// Yönetemin bulunduğu adım sayısıdır.
    /// </summary>
    private int adimSayisi = 0;
    /// <summary>
    /// Belirlenen grup içerisinde diğerleriyle karşılaştırılacak veridir.
    /// </summary>
    private int isaretliEleman;

    /// <summary>
    /// Recursive olarak dönen kontrol fonksiyonudur.
    /// </summary>
    public void CevabiDonder()
    {
        adimSayisi++;
        if (grupElemanSayisi == veriGrubu.Count + 1)
        {
            Console.Write("\nBulunan Cevap: ");
            ListeyiYaz();
        }
        else
        {
            isaretliEleman = veriGrubu[grupElemanSayisi - 1];
            for (int i = grupElemanSayisi - 2; i >= 0; i--)
            {
                if (veriGrubu[i] > isaretliEleman)
                {
                    if (i != 0)
                    {
                        ListeyiYaz();
                        Console.WriteLine("=> " + veriGrubu[i] + " > " + isaretliEleman + " olduğundan yer değiştiriler.");
                    }
                    if (i == 0 && grupElemanSayisi != veriGrubu.Count + 1)
                    {
                        ListeyiYaz();
                        veriGrubu[i + 1] = veriGrubu[i];
                        veriGrubu[i] = isaretliEleman;
                        Console.WriteLine("=> " + veriGrubu[i + 1] + " > " + isaretliEleman + " olduğundan yer değiştiriler ve " + adimSayisi + ". adım tamamlanır.");
                        grupElemanSayisi++;
                        CevabiDonder();
                    }
                    veriGrubu[i + 1] = veriGrubu[i];
                    veriGrubu[i] = isaretliEleman;
                }
                else if (grupElemanSayisi != veriGrubu.Count + 1)
                {
                    ListeyiYaz();
                    Console.WriteLine("=> " + veriGrubu[i] + " < " + isaretliEleman + " olduğundan aynen kalır ve " + adimSayisi + ". adım tamamlanır.");
                    grupElemanSayisi++;
                    CevabiDonder();
                }
            }
        }
    }
    /// <summary>
    /// Her seferinde listeyi işaretli olanı ayırt ederek yazan fonksiyondur eğer sonuç bulunmuşsa işaretli olanda aynı renkte yazılır.
    /// </summary>
    private void ListeyiYaz()
    {
        for (int i = 0; i < veriGrubu.Count; i++)
        {
            if (grupElemanSayisi != veriGrubu.Count + 1)
            {
                if (veriGrubu[i] == isaretliEleman)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (i < adimSayisi + 1)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;
            }
            else
                Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   " + veriGrubu[i]);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
}
