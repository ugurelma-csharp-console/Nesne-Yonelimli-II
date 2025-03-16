using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
    }
    static void Metot1(int a, string b)
    {
        Console.WriteLine("Metot 1");
    }
    static void Metot2(int a)
    {
        Console.WriteLine("Metot 2");
    }
    static void Metot3(string b)
    {
        Console.WriteLine("Metot 3");
    }
    static void Metot4()
    {
        Console.WriteLine("Metot 4");
    }
    static string Metot5(int a, string b)
    {
        Console.WriteLine("Metot 5");
        return "";
    }
    static int Metot6()
    {
        Console.WriteLine("Metot 6");
        return 0;
    }
    static void Metot7(int c, string d)
    {
        Console.WriteLine("Metot 7");
    }
}