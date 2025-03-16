using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize
{
    internal class Urun
    {
        public string Adi {  get; set; }
        public string Aciklama { get; set; }
        public int StokAdet { get; set; }
        public double FiyatiHesapla(int Adet)
        {
            return 0f;
        }
        public bool StokDurumu()
        {
            return true;
        }
    }
}
