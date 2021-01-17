using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Ad = "Kemal";
            musteri1.Soyad = "Kartal";
            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Taşkın";

            Musteri musteri3 = new Musteri();

            musteri3.Id = 3;
            musteri3.Ad = "Kerim";
            musteri3.Soyad = "Dev";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);

            musteriManager.Ekle(musteri2);

            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri2);







        }
    }
}
