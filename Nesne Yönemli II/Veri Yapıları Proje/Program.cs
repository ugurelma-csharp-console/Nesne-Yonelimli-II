using System;
internal class Program
{
    static void Main(string[] args)
    {
        int secim = 0;
        while (true)
        {
            Console.WriteLine("Çıkış için -> 0\nBFS için -> 1\nInsertion Sort için -> 2");
            Console.Write("Seçiminiz: ");
            try
            {
                secim = int.Parse(Console.ReadLine());
                if (secim == 0)
                    break;
                else if (secim == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Verilen dizi: A, B, C, D, E, F, G, H, I, J\n");
                    Console.WriteLine("Beklenen sıra: A, B, D, C, I, F, G, E, H, J\n");
                    BFS bfs = new BFS();
                    Console.Write("Ana sayfaya dönmek için klavyeden herhangi bir tuşa basınız!");
                }
                else if (secim == 2)
                {
                    Console.Clear();
                    InsertionSort insertionSort = new InsertionSort();
                    Console.WriteLine("Verilen dizi: 3, 8, 15, 4, 23, 2, 39, 5, 12, 10\n");
                    Console.WriteLine("Beklenen cevap: 2, 3, 4, 5, 8, 10, 12, 15, 23, 39\n");
                    insertionSort.CevabiDonder();
                    Console.Write("Ana sayfaya dönmek için klavyeden herhangi bir tuşa basınız!");
                }
                else
                    Console.WriteLine("Lütfen 1 ya da 2 giriniz!");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Lütfen sayı giriniz!");
            }
            Console.Clear();
        }
    }
}
