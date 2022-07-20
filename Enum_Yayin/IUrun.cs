using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Yayin
{
    internal interface IUrun
        //interface içinde hiçbir kod olmaz sadece public property'ler olur. Bu property'ler abstract'mış gibi hareket eder ve türeyen tüm sınıflarda uyarlanması gerekir.
        //Interface in C# is a blueprint of a class. It is like abstract class because all the methods which are declared inside the interface are abstract methods. It cannot have method body and cannot be instantiated. It is used to achieve multiple inheritance which can't be achieved by class
    {
        decimal Fiyat { get; set; }
        string Baslik { get; } //yayında zaten baslik var fakat baslik'ı olmayan ürünlerde de baslik kullanabilmek için interface'de bunu tanımladık
    }
}
