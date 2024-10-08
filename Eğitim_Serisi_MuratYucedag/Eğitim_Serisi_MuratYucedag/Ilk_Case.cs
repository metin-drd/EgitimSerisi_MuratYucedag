using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eğitim_Serisi_MuratYucedag
{
    internal static class Ilk_Case
    {
        public static void FirstCase()
        {
            #region Manav Satış

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 12.96;
            orangePrice = 20.65;
            strawberryPrice = 36.85;
            potatoPrice = 21.84;
            tomatoPrice = 8.74;

            Console.WriteLine("---------------------------------------------");
            Console.OutputEncoding = Encoding.UTF8; // ₺ işareti kullanabilmemiz için utf8 ekliyoruz
            Console.WriteLine("Elma Fiyatı: " + applePrice + " ₺");
            Console.WriteLine("Portakal Fiyatı: " + orangePrice + " ₺");
            Console.WriteLine("Çilek Fiyatı: " + strawberryPrice + " ₺");
            Console.WriteLine("Patates Fiyatı: " + potatoPrice + " ₺");
            Console.WriteLine("Domates Fiyatı: " + tomatoPrice + " ₺");
            Console.WriteLine("---------------------------------------------");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 2.350;
            orangeGram = 3.250;
            strawberryGram = 0.659;
            potatoGram = 5.875;
            tomatoGram = 3.256;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine("*********************  Satış Bilgisi  *************************");
            Console.WriteLine("");
            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
            Console.WriteLine("");
            Console.WriteLine("");
            double totalShoppingPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine("Toplam Alışveriş Tutarı: " + totalShoppingPrice + " ₺");


            #endregion

            #region CSharp Hava Yolları

            Console.WriteLine("****  CSharp Hava Yolları Yolcu Bilgileri *******");
            Console.WriteLine("");

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIndentityNumber;

            Console.WriteLine("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.WriteLine("Yolcu soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.WriteLine("Yolcu İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.WriteLine("Yolcu Şehir: ");
            passengerCity = Console.ReadLine();

            Console.WriteLine("Yolcu Yaşı: ");
            passengerAge = Console.ReadLine();

            Console.WriteLine("Yolcu TC Kimlik No: ");
            passengerIndentityNumber = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Yolcu Kimlik No: " + passengerIndentityNumber + " -- Yolcu Adı ve Soyadı: " + passengerName + " " + passengerSurname);
            #endregion

        }
    }
}
