using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_mainsubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdımaKomutları

            //Console.WriteLine("merhaba dünya");
            //Console.Write("selam");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü Değişken_adı;

            //string name;
            //name = "Aynur";
            //Console.Write(name);


            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;



            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+09 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");

            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerPhone = "09 600 500 40 30,";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 30;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı **** ");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("-----kola:" + cokePrice + "TL");
            Console.WriteLine("-----su:" + waterPrice + "TL");
            Console.WriteLine("-----kızartma:" + friesPrice + "TL");
            Console.WriteLine("-----pizza:" + pizzaPrice + "TL");
            Console.WriteLine("-----limonata:" + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;


            int totalHamburgerPrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesPrice;
            int totalpizzaPrice;
            int totallemonadePrice;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totallemonadePrice=lemonadeCount * lemonadePrice;
            totalfriesPrice = friesCount * friesPrice;
            totalpizzaPrice=pizzaCount * pizzaPrice;


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("pizza Tutarı:" + totalpizzaPrice + "TL");
            Console.WriteLine("kızartma Tutarı:" + totalfriesPrice + "TL");
            Console.WriteLine("kola Tutarı:" + totalcokePrice + "TL");
            Console.WriteLine("su Tutarı:" + totalwaterPrice + "TL");
            Console.WriteLine("limonata Tutarı:" + totallemonadePrice + "TL");

            Console.WriteLine();

            int totolPrice = totalcokePrice + totalwaterPrice + totallemonadePrice + totalHamburgerPrice + totalfriesPrice + totalpizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar:" + totolPrice + "TL");
            
            
            #endregion

            Console.Read();

        }
    }
}




//yazdırma komutları
