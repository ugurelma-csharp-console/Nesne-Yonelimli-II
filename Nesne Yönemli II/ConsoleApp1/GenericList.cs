using System;

internal class GenericList<T> where T : class, new()
{
    public T deneme;
    public void OgrenciEkle(T ogrenci)
    {
        deneme = new T();
    }
    public void OgrenciSil(T ogrenci)
    {

    }
    public void OgrenciBul(T ogrenci)
    {

    }
    public void OgrenciNotuGuncelle(T ogrenci)
    {

    }
}

class Deneme
{
    internal int x {  get; set; }
    public Deneme() { }
}

class Ogrenci
{
    internal string name { get; set; }
    internal string surname { get; set; }
    internal int mark {  get; set; }

    internal Ogrenci(string name, string surname, int mark)
    {
        this.name = name;
        this.surname = surname;
        this.mark = mark;
    }
}