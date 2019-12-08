using System;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2;
            string islem, secim;
            bool devam = false, devam2 = false;
            Console.WriteLine("ödev hesap makinesi");
            do
            {
                Console.Write("1. sayıyı giriniz:");
                s1 = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.Write("işleminizi seçiniz:");
                    islem = (Console.ReadLine());
                    if (!(islem == "+" || islem == "-" || islem == "*" || islem == "/"))
                    {
                        Console.WriteLine("hatalı işlem seçtiniz tekrar giriniz");
                        devam2 = true;
                    }
                    else
                        devam2 = false;
                } while (devam2);
                Console.Write("2. sayıyı giriniz:");
                s2 = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {

                    case "+":
                        Console.WriteLine("toplam:" + (s1 + s2));
                        break;
                    case "-":
                        Console.WriteLine("fark:" + (s1 - s2));
                        break;
                    case "*":
                        Console.WriteLine("çarpım:" + (s1 * s2));
                        break;
                    case "/":
                        Console.WriteLine("bölüm:" + (s1 / s2));
                        break;
                    default:
                        break;
                }
                Console.Write("tekrar işlem yapmak ister misiniz?\nevet yada hayır\nseçiminiz:");
                do
                {
                    secim = Console.ReadLine();
                    if (secim == "evet" || secim == "Evet" || secim == "EVET")
                        devam = true;
                    else if (secim == "hayır" || secim == "Hayır" || secim == "HAYIR" || secim == "hayir" || secim == "Hayir" || secim == "HAYİR")
                        devam = false;
                    else
                        Console.WriteLine("hatalı giriş yaptınız!!tekrar girin\nseçiminiz:");
                } while (!(secim == "evet" || secim == "Evet" || secim == "EVET" || secim == "hayır" || secim == "Hayır" || secim == "HAYIR" || secim == "hayir" || secim == "Hayir" || secim == "HAYİR"));
            } while (devam);
        }
    }
}
