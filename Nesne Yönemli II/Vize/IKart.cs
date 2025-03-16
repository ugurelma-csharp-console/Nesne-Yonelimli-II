using System;

namespace Vize
{
    interface IKart
    {
        string Adi { get; set; }
        DateTime Gecerlilik { get; set; }
        bool Onaylandi();
    }
}
