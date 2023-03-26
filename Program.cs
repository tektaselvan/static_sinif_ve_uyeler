using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:  {0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Elvan", "Tektaş", "İK");
            Console.WriteLine("Çalışan Sayısı:  {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Ali", "Tektaş", "İK");
            Calisan calisan2 = new Calisan("Zeynep", "Tektaş", "İK");
            Console.WriteLine("Çalışan Sayısı:  {0}", Calisan.CalisanSayisi);
            Console.WriteLine("Toplama işlemi sonucu: {0}", islemler.Topla(250, 250));
            Console.WriteLine("Çıkarma işlemi sonucu:  {0}", islemler.Cikar(400, 50));

        }
    }
    class Calisan
    {
        private static int CalisanaSayisi;

        public static int CalisanSayisi { get => CalisanaSayisi; }
        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            CalisanaSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            CalisanaSayisi++;
        }
    }
    static class islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
