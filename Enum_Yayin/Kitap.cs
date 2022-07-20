using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Yayin
{
    internal class Kitap : Yayin, IUrun, IHediye //c# içinde iki base class olamaz çoklu interface olur
    {
        public string Yazar { get; set; }
        public int Yili { get; set; }

        public override string Baslik
        {
            get { return Adi; }
        }

        public decimal Fiyat { get; set; }
        public bool HediyeMi { get; set;. }
    }
}
