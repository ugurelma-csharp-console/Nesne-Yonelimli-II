using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize
{
    internal class KrediKarti: Odeme, IKart
    {
        public string Adi {  get; set; }
        public DateTime Gecerlilik { get; set; }
        public bool Onaylandi()
        {
            return true;
        }
        public bool Taksitlendir(int TakSay)
        {
            return true;
        }
    }
}
