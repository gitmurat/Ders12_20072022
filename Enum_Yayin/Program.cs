using MyEnums;

namespace Enum_Yayin
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*Kitap kitap = new Kitap();
            kitap.Adi = "Nutuk";
            kitap.Yazar = "M.K. Atatürk";
            kitap.SayfaSayisi = 300;
            kitap.Turu = YayinTuru.Tarih;


            Dergi dergi = new Dergi() { Adi = "Chip", Sayi = 123, Periyodu = DergiPeriyodu.Aylik, Turu = YayinTuru.Bilgisayar };

            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Fiyat = 1000.50m;

            Console.WriteLine(kitap.Baslik);
            Console.WriteLine(dergi.Baslik);
            Console.WriteLine(bilgisayar.Baslik);*/

            Yayin y1 = new Kitap() { Adi = "Yaban" }; //bu şekilde tanımlanan özellikler (yayın'ın interfaceinde bulunan özelliklerde yazar ve sayfa sayisi                                         yok o yüzden bu kitapta yazar ve sayfa sayisi özellikleri olmayacak
            Yayin y2 = new Dergi();

            IUrun u1 = new Kitap() { Adi = "Sinekli Bakkal"}; //bu kitapta sadece ürün interface'inin property'leri var
            IUrun u2 = new Bilgisayar();
        }
    }
}