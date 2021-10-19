using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
     class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine( "Müsteri başarıyla eklenmiştir"+ "--" + musteri.Ad + " " +musteri.Soyad  );
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi"+ "--" + musteri.Ad + " " + musteri.Soyad);
        }
        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Güncellendi" + "--" + musteri.Ad + " " + musteri.Soyad );
        }

    }
}
