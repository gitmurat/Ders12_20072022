using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Yayin
{
    internal class Bilgisayar : IUrun
    {
        public decimal Fiyat { get; set; }
        public string Baslik { get { return "Laptop"; } }
    }
}
