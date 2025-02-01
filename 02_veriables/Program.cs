using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_veriables
{
    internal class Program
    {
        private static double potatoPrice;

        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice =9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("---- portokal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("---- çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("---- patates Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("---- domates Birim Fiyatı:" + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotolPrice = appleGram * applePrice;
            //double orangeTotolPrice = orangeGram * orangePrice;
            //double strawberryTotolPrice = strawberryGram * strawberryPrice;
            //double potatoTotolPrice = potatoGram * potatoPrice;
            //double tomatoTotolPrice = tomatoGram * tomatoPrice;



            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotolPrice);
            //Console.WriteLine("Alınan Ürün: portokal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotolPrice);
            //Console.WriteLine("Alınan Ürün: çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotolPrice);
            //Console.WriteLine("Alınan Ürün: patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotolPrice);
            //Console.WriteLine("Alınan Ürün: domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotolPrice);

            //double shoppingTotalPrice = appleTotolPrice + orangeTotolPrice + strawberryTotolPrice + tomatoTotolPrice + potatoTotolPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + "TL");



            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"  '


            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region  Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistric, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("ilçe bilgisi: ");
            //passengerDistric = Console.ReadLine();

            //Console.Write("şehir bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("yolcu yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("yolcu TC  kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("-------------------------");
            //Console.WriteLine("yolcu TC kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " +
            //    passengerDistric + " / " + passengerCity + " " + passengerAge + " ");






            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümleri

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız televizyon sayısını giriniz ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvPrice;


            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);





            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri


            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);








            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender); 




            #endregion

            #region 



            #endregion


            Console.Read();



        }
    }
}
