using System;
using OOP.Task.Models;
namespace OOP.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Anbardar anbardar = new Anbardar(1,"Huseyn","Eliyev","huseyinekh@gmail.com");
            Ischi ischi = new Ischi(1, "Huseyn", "Eliyev", "huseyinekh@gmail.com");


            Musteri musteri = new Musteri(1,"Hesen","Rustemov","hesen@gmail.com");

            Sifaris sifaris = new Sifaris(1, 5, 50, 1, 1);
            SifarisDetal sifarisDetal = new SifarisDetal(0, 1, 1,false);
            Kargo kargo = new Kargo(1, 1, 1);
            MusteriSifaris musteriSifaris = new MusteriSifaris(1, 1, 1);

            OdemeMetod odemeMetod1 = new OdemeMetod(1, "Pay-pal");
            OdemeMetod odemeMetod2 = new OdemeMetod(2, "Master Card");

            ShippingMethod shippingMethod1 = new ShippingMethod(1,"method1");
            ShippingMethod shippingMethod2 = new ShippingMethod(2, "method2");


            Kategory kategory1 = new Kategory(1, "ayaqqabi");
            Kategory kategory2 = new Kategory(2, "koynek");


            Mehsul mehsul = new Mehsul(1, "t-shirt", 50 , 5, "XL", 1, 1);

        }
    }
}
