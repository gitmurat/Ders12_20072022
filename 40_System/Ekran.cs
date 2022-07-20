using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem
{
    public class Ekran //bu sınıf daha önce internal'dı ve bu sadece kendi programı içindeki programlar onu kullanabiliyordu. Sınıfı public yapıp farklı bir programa bu sınıfı referans olarak verdiğimizde artık diğer programlardan da bu class kullanılabilir.
    {
        public static void CizgiCiz() //static memberlar herhangi bir instance'a gerek kalmadan çağrılabilen method ve özellikleri içerir.
        {
            Console.WriteLine("------------------------------");
        }

        public static void BaslikYaz(string baslik)
        {
            CizgiCiz();
            Console.WriteLine(baslik);
            CizgiCiz();
        }
    }
}
