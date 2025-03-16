
namespace ConsoleApp2
{
    class Ders
    {
        public Ogrenci ogrenci {  get; set; }
        public double vize {  get; set; }
        public double final {  get; set; }
        public double ortalama { get; set; }
        public string dersAdi { get; set; }

        public Ders(double v, double f, string dersAdi)
        {
            vize = v;
            final = f;
            this.dersAdi = dersAdi;
            ortalama = vize * 0.4f + final * 0.6f;
        }
    }
}
