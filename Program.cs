using System;

namespace konsol_uyg._bilgi_yarismasi_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("bilgi yarışması");
            Console.WriteLine("yarışmamıza hoşgeldiniz!");
            Console.WriteLine("her soruyu cevapladıktan sonra enter'a basınız.");
            Console.WriteLine("csvaplarınızı büyük harfle yazınız  örnek:'A'. ");
            Console.ReadLine();

            int True = 0;
            int False = 0;
            int Money = 0;

            string q1;
            Console.WriteLine("soru-1 Türkiye'nin başkenti neresidir?");
            q1 = Console.ReadLine();
            string a1;
            Console.WriteLine("A-Denizli B-Ceyhan C-Bursa D-Ankara");
            a1 = Console.ReadLine();
            if (a1=="D")
            {
                True += 1;
                Money += 100;
                Console.WriteLine("tebrikler doğru cevap:)");
            }
            else
            {
                False += 1;
                Console.WriteLine("Malesef yanlış cevap:(");

            }
            Console.WriteLine("durum");
            Console.WriteLine("dogru cevaplar:" + True + " yanlış cevap:" + False + " kasa:" + Money);
            Console.ReadLine();

            string q2;
            Console.WriteLine("soru-2 Türkiye'nin nüfusu en çok olan ili hangisidair");
            q2 = Console.ReadLine();
            string a2;
            Console.WriteLine("A-Sivas B-İzmir C-İstanbul D-Antalya");
            a2 = Console.ReadLine();
            if (a2 == "C")
            {
                True += 1;
                Money += 100;
                Console.WriteLine("tebrikler doğru cevap");
            }
            else
            {
                False += 1;
                Console.WriteLine("Malesef yanlış cevap");
            }
            Console.WriteLine("durum");
            Console.WriteLine(" dogru cevaplar:" + True + " yanlış cevap:" + False + " kasa:" + Money);
            Console.ReadLine();

            string q3;
            Console.WriteLine("soru-3 Türkiye'nin en büyük yüz ölçümüne sahip ili hangisidir?");
            q3 = Console.ReadLine();
            string a3;
            Console.WriteLine("A-Isparta B-Konya C-Tekirdağ D-Gaziantep");
            a3 = Console.ReadLine();
            if (a3 == "B")
            {
                True += 1;
                Money += 100;
                Console.WriteLine("tebrikler doğru cevap");
            }
            else
            {
                False += 1;
                Console.WriteLine("Malesef yanlış cevap");
            }
            Console.WriteLine("durum");
            Console.WriteLine(" dogru cevaplar:" + True + " yanlış cevap:" + False + " kasa:" + Money);
            Console.WriteLine();

            Console.WriteLine("yarışmamıza katıldığınız için teşekkürler");
            Console.WriteLine(" dogru cevaplar:" + True);
            Console.WriteLine(" yanlış cevap:" + False);
            Console.WriteLine(" kasa:" + Money);

        }
    }
}
