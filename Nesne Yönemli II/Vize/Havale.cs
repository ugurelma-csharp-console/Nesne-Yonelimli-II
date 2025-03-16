using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize
{
    internal class Havale: Odeme
    {
        public string Adi {  get; set; }
        public string Aciklama { get; set; }
        public bool Onaylandi()
        {
            return true;
        }
    }
}
