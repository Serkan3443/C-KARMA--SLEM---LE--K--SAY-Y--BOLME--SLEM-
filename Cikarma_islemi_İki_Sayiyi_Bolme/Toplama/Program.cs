using System.Threading.Channels;

namespace Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bölünecek sayıyı giriniz:");
            double sayi1=double.Parse(Console.ReadLine());

            Console.WriteLine("Bölen sayıyı giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double bolum = 0;
            do
            {
                sayi1 -= sayi2;
                bolum++;
                if (sayi1 < sayi2)
                    break;

            } while (sayi1>0);
            Console.WriteLine(" Do ile sonuç: " + bolum);
            
            while (sayi1>0)
            {
                sayi1 -= sayi2;
                bolum++;
                if (sayi1 < sayi2)
                    break;

            }
            Console.WriteLine("While ile sonuç: " + bolum);

            for (int i = 0; i < sayi1; i++)
            {
                sayi1 -= sayi2;
                bolum--;
                if (sayi1 < sayi2)
                    break;
            }
            Console.WriteLine("For ile sonuç: " + bolum);
            Console.Read();

            Console.Read();

        }
    }
}