using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();            
            musteri1.Adi = "Ela";
            musteri1.Soyadi = "Saydam";
            musteri1.FavoriCicegi = "Ortanca";
            musteri1.Ikameti = "Edirne";

            Musteri musteri2 = new Musteri();            
            musteri2.Adi = "Çetin";
            musteri2.Soyadi = "Baş";
            musteri2.FavoriCicegi = "Orkide";
            musteri2.Ikameti = "Kırklareli";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Selin";
            musteri3.Soyadi = "Yıldırım";
            musteri3.FavoriCicegi = "Kaktüs";
            musteri3.Ikameti = "İstanbul";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.FavoriCicegi);
                Console.WriteLine("--------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri3);
        }
    }
}
