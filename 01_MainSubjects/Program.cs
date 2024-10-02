using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Soğuk Yemekler");
            //Console.WriteLine("4 - Salatalar");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("6 - İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion


            #region String Değişkenler

            //string name;
            //name = "Recep";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, customerDistrict, customerCity;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //customerDistrict = "Kadıköy";
            //customerCity = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 20 50";
            //customerEmail = "test@gmail.com";
            //customerDistrict = "Sapanca";
            //customerCity = "Sakarya";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("-------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----- Kola: " + cokePrice + "TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("----- Kızartma: " + friesPrice + "TL");
            Console.WriteLine("----- Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalFriesPrice = friesPrice * friesCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine();

            int totalPrice = totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalCokePrice + totalHamburgerPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);

            #endregion

            Console.Read();
        }
    }
}



// Yazdırma Komutları 