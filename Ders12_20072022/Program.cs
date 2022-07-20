namespace Ders12_20072022
{
    enum YayinTuru //an enum type is a special data type that enables for a variable to be set of predefined constants. The variable must be equal to one of the values that have been predefined for it.
    {
        Tarih = 10, Edebiyat = 20, Teknik = 30
    }

    class Yayin
    {
        public int SayfaSayisi { get; set; }
        public string Adi { get; set; }
        public YayinTuru Tur { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            YayinTuru Tur1;
            Tur1 = YayinTuru.Edebiyat;

            switch (Tur1)
            {
                case YayinTuru.Tarih:
                case YayinTuru.Edebiyat:
                    Console.WriteLine("Sosyal");
                    break;
                case YayinTuru.Teknik:
                    Console.WriteLine("Sayısal");
                    break ;
                default:
                    break;
            }
        }
    }
}