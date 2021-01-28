using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical operators                            : && (and), || (or) , ! (not)
            //realtionel operators (ilişkisel operatörler) : ==, !=, >= , <=, >, <
            //aritmetic operators (aritmetik opertöleri)   : +, - , * , / , %
            //assignament operator (atama operatörü)       : =



            #region if else
            var number = 11;
            if (number == 10) //true,false
            {
                Console.WriteLine("Number is 10");
            }
            else //number !=10
            {
                Console.WriteLine("Number is not 10");
            }

            number = 20;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }

            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            #endregion

            #region switch

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;


            }
            #endregion

            // ternary operation
            #region result 
            number = 11;
            string result = number == 10 ? "Number is 10 " : "Number is not 10";
            Console.WriteLine(result);
            #endregion

            #region if else karmaşık yolu
            int sayi = 102;
            if (sayi >= 0)
            {
                if (sayi <= 100)
                {
                    Console.WriteLine("0 - 100");
                }
                else //if (sayi > 100)
                {
                    if (sayi <= 200)
                    {
                        Console.WriteLine("100 - 200");
                    }
                    else
                    {
                        Console.WriteLine("SınırDışı");
                    }

                }

            }
            else
            {
                Console.WriteLine("Sınır dışı");
            }
            #endregion

            #region if else kolay yolu
            if (sayi >= 0 && sayi <= 100)
            {
                Console.WriteLine("0 - 100");
            }
            else if (sayi > 100 && sayi < 200)
            {
                Console.WriteLine("100 -200");
            }
            else
            {
                Console.WriteLine("Sınır Dışı");
            }
            #endregion

            #region algoritma örnegi 1

            Console.WriteLine("Bir tam sayı giriniz");
            string giris = Console.ReadLine();
            string cikis;
            int girissayisi = Convert.ToInt32(giris);
            if (girissayisi > 0)
                cikis = "Pozitif";
            else if (girissayisi < 0)
                cikis = "Negatif";
            else // if (girissayisi == 0)
                cikis = "Sıfır'a Eşit";
            Console.WriteLine(cikis);
            #endregion

            #region yazı tura ornegi

            Console.WriteLine("Yazı mı (y), Tura mı (t)? ");
            string inputtext = Console.ReadLine();
            int inputnumber;
            //int moneyValue = 1; //yazı , 0 : tura
            Random rastgele = new Random();
            int moneyValue = rastgele.Next(0, 2);
            if (inputtext == "y" || inputtext == "t")
            {
                if (inputtext == "y")
                    inputnumber = 1; //yazı
                else
                    inputnumber = 0; // tura"

                if (inputnumber == moneyValue)
                {
                    Console.WriteLine("Tebrikler Bildiniz");
                }
                else
                {
                    Console.WriteLine("Bilemediniz");
                }
            }
            else
            {
                Console.WriteLine("Lütfen yazı için \"y\" tura için \"t\" girin ");
            }
            Console.ReadLine();

            #endregion

            #region koraonavirustespiti

            Console.WriteLine("Coronvirüs Belirti Tespiti");
            string soruEk = "Evet için (e) , Hayır için (h)";
            string uyari = "Lütfen evet için \"e\" , hayır için \"h\" girin !! ";
            string oksurukcevap;
            string bogazagrısıcevap;
            Console.Write("Ateş var mı ? " + soruEk);
            string ateşCevap = Console.ReadLine();
            if (!(ateşCevap == "e" || ateşCevap == "h"))
            {
                Console.WriteLine(uyari);
            }
            else
            {
                Console.Write("Öksürük var mı ? " + soruEk);
                oksurukcevap = Console.ReadLine();
                if (!(oksurukcevap == "e" || oksurukcevap == "h"))
                {
                    Console.WriteLine(uyari);
                }
                else
                {
                    Console.WriteLine("Boğaz agrısı var mı ?" + soruEk);
                    bogazagrısıcevap = Console.ReadLine();
                    if (bogazagrısıcevap != "e" && bogazagrısıcevap != "h")
                    {
                        Console.WriteLine(uyari);
                    }
                    else
                    {
                        //if (ateşCevap == "e" || oksurukcevap == "e" || bogazagrısıcevap == "e")
                        if(ateşCevap == "e" || (oksurukcevap == "e" && bogazagrısıcevap == "e"))
                        {
                            Console.WriteLine("Koronavirüs olma ihtimaliniz vardır ");
                        }
                        else
                        {
                            Console.WriteLine("Coronavirüs ihtimaliniz bulunmamaktadır");
                        }
                    }
                }
            }

            Console.ReadLine();
            #endregion

            #region Kullanıcı Girişi

            Console.WriteLine("*****Kullanıcı Girişi*****");
            Console.WriteLine("Kullanıcı Adi");
            string kullanıcıAdi = Console.ReadLine();
            Console.Write("Sifre : ");
            string sifre = Console.ReadLine();
            string kayitliKullanıcıAdi = "cagil";
            string kayitliSifre = "123";
            if (kullanıcıAdi == kayitliKullanıcıAdi && sifre == kayitliSifre)
                Console.WriteLine("Hosgeldiniz " + kullanıcıAdi);
            else
                Console.WriteLine("Geçerisiz Kullanıcı");

            #endregion

            #region ödev
            Console.Write("1.sayi giriniz : ");
            string sayi12 = Console.ReadLine();
            Console.Write("2.sayi giriniz : ");
            string sayi22 = Console.ReadLine();
            int sayi1deger = Convert.ToInt32(sayi12);
            // int sayi2deger = int.parse(sayi2); dönüştürmenin 2. yolu...
            int sayi2deger = Convert.ToInt32(sayi22);
            if (sayi1deger > sayi2deger)
            {
                Console.WriteLine("Büyüktür");

            }

            else if (sayi1deger < sayi2deger)
            {
                Console.WriteLine("küçüktür");
            }

            else
            {
                Console.WriteLine("eşittir");
            }

            Console.ReadLine();

            #endregion

            #region 3 sayi karşılaştırma zor olan

            //Console.Write("1.sayi giriniz");
            //string sayi1 = Console.ReadLine();
            //Console.Write("2.sayi giriniz");
            //string sayi2 = Console.ReadLine();
            //Console.Write("3.sayi giriniz");
            //string sayi3 = Console.ReadLine();
            //if(Convert.ToInt32(sayi1) > Convert.ToInt32(sayi2))
            //{
            //    if (Convert.ToInt32(sayi1) > Convert.ToInt32(sayi3))
            //        // sayi 1 en büyü
            //    else
            //        //sayi 3 en büyük

            //}
            //else if (Convert.ToInt32(sayi2) > Convert.ToInt32(sayi3))
            //{
            //    if (Convert.ToInt32(sayi2) > Convert.ToInt32(sayi3))

            //        //sayi 2 en büyük
            //    else  
            //        //sayi 1 en büyük
            //}
            //else
            //{
            //    if(Convert.ToInt32(sayi3)> Convert.ToInt32(sayi2))
            //        // sayi 3 en büyük
            //        else   
            //        //sayi 2 en büyük
            //}


            #endregion

            #region 3 sayi kolay olan
            Console.Write("1.sayi giriniz : ");
            string sayi1 = Console.ReadLine();
            Console.Write("2.sayi giriniz : ");
            string sayi2 = Console.ReadLine();
            Console.Write("3.sayi giriniz : ");
            string sayi3 = Console.ReadLine();
            int enBuyuk;
            enBuyuk = Convert.ToInt32(sayi1);
            if(Convert.ToInt32(sayi1) == Convert.ToInt32(sayi2) && Convert.ToInt32(sayi2) == Convert.ToInt32(sayi3))
            {
                Console.WriteLine("Tüm girilen sayılar birbirine eşittir");
            }
            else
            {
                if (Convert.ToInt32(sayi2) >= Convert.ToInt32(sayi1) && Convert.ToInt32(sayi2) >= Convert.ToInt32(sayi3))
                {
                    enBuyuk = Convert.ToInt32(sayi2);
                }
                if (Convert.ToInt32(sayi3) >= Convert.ToInt32(sayi1) && Convert.ToInt32(sayi3) >= Convert.ToInt32(sayi2))
                {
                    enBuyuk = Convert.ToInt32(sayi3);
                }
                Console.WriteLine("En büyük sayi : " + enBuyuk);
            }
            
            Console.ReadLine();
            #endregion
            //hackerrank algoritma çözümleri

        }
    }
}
