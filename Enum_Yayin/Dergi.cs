using MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Yayin
{
    internal class Dergi : Yayin
    {
        public int Sayi { get; set; }
        public DergiPeriyodu Periyodu { get; set; }

        public override string Baslik
        {
            get { return Adi + " " + Sayi + ". sayisi"; }
        }
    }
}
