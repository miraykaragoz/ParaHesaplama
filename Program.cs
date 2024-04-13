namespace ParaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para hesaplama programına hoşgeldiniz. Devam etmek için lütfen enter'a basınız.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Kaç adet ürün sipariş ettiniz?: ");
            int urun = int.Parse(Console.ReadLine());

            int siparisTutari = 0;
            Console.Clear();
            for (int i = 1; i <= urun; i++)
            {
                Console.Write(i + ". Ürünün fiyatını giriniz:");
                siparisTutari += int.Parse(Console.ReadLine());
                Console.Clear();

            }
            Console.WriteLine("Sonuç: " + siparisTutari + " tl");

            Console.WriteLine("Ödeme ne ile yapılacak? (nakit/kart)");           
            string odemeAraci = Console.ReadLine();

            if (odemeAraci == "nakit")
            {
                Console.WriteLine("Vereceğiniz tutarı giriniz: ");
                int bakiye = int.Parse(Console.ReadLine());
                if (bakiye >= siparisTutari)
                {
                    Console.WriteLine("Ödeme işlemi tamamlandı");
                }
                else
                {
                    Console.WriteLine("Verdiğiniz tutar sipariş tutarına yetmiyor.");
                }
            }
            else
            {
                Console.WriteLine("Kart bakiyenizi giriniz: ");
                int bakiye = int.Parse(Console.ReadLine());
                if (bakiye >= siparisTutari)
                {
                    Console.WriteLine("Ödeme işlemi tamamlandı");
                }
                else
                {
                    Console.WriteLine("Bakiyeniz sipariş tutarına yetmiyor.");
                }
            }
        }
    }
}
