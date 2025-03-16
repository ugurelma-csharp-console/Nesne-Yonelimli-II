using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize
{
    internal class Siparis
    {
        public SiparişDetay siparişDetay { get; set; }
        public Musteri musteri {  get; set; }
        public List<Odeme> odemeList { get; set; }
        public DateTime Tarih {  get; set; }
        public string Durum { get; set; }

        internal Siparis(Musteri musteri)
        {
            this.musteri = musteri;
        }
        public int ToplamFiyat()
        {
            return 0;
        }
        public int Vergi()
        {
            return 0;
        }
    }
}
