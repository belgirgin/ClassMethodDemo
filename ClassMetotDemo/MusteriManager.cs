using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri: " + musteri.Adi +" "+ musteri.Soyadi);

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen müşteri: " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşterilerin listesi: " + musteri.Adi + " " + musteri.Soyadi);
        }

    }
}
