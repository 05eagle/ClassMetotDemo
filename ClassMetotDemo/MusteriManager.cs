using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Müşteri Eklendi. Müşterinin Adı: "+musteri.Ad);
        }

        public void Listele(Musteri[] musteriler)
        {
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşterinin Adı: "+musteri.Ad+"\n"+"Müşterinin Soyadı : "+musteri.Soyad);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" Müşterisi Silindi..");
        }
    }
}
