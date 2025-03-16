using System;
using System.Collections.Generic;

internal class PropertyveKalitim { }

abstract class Insan
{
    private string TCKimlikNo;

    protected string tcKimlikNo
    {
        get
        {
            return TCKimlikNo;
        }
        set
        {
            if (value.Length == 11)
                TCKimlikNo = value;
        }
    }

    protected string adiSoyadi;
    protected string cinsiyeti;
    protected int yas;
    private float Maas;
    protected float maas
    {
        get => Maas;
        set => Maas = value;
    }

    protected Insan(string adiSoyadi, string cinsiyeti, int yas)
    {
        this.adiSoyadi = adiSoyadi;
        this.cinsiyeti = cinsiyeti;
        this.yas = yas;
        maas = 0;
    }
    protected virtual string MaasiGuncelle(float maas)
    {
        this.maas = maas;
        return "Maas başarıyla güncellendi.";
    }
}

class Temizlikci: Insan
{
    internal Temizlikci(string tcKimlikNo, string adiSoyadi, string cinsiyeti, int yas) : base(adiSoyadi, cinsiyeti, yas)
    {
        base.tcKimlikNo = tcKimlikNo;
    }
}

internal class Memur: Insan
{
    internal Memur(string tcKimlikNo, string adiSoyadi, string cinsiyeti, int yas) : base(adiSoyadi, cinsiyeti, yas)
    {
        base.tcKimlikNo = tcKimlikNo;
    }
}

internal class Yonetici: Insan
{
    internal Yonetici(string tcKimlikNo, string adiSoyadi, string cinsiyeti, int yas) : base(adiSoyadi, cinsiyeti, yas)
    {
        base.tcKimlikNo = tcKimlikNo;
    }
}