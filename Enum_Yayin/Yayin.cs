using MyEnums; //kendi namespace'imi oluşturarak oradaki enumları bu sınıfta kullanmak istediğimi bildirdim.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Yayin
{
    internal abstract class Yayin
    {
        public int SayfaSayisi { get; set; }
        public string Adi { get; set; }
        public YayinTuru Turu { get; set; }

        public abstract string Baslik { get; }
    }
}
