using System;
using System.Linq;
using System.Text;

namespace Morse
{
    class Program
    {
        private const string separator = " / ";
        private static MorseConverter _conv = new MorseConverter();

        static void Main(string[] args)
        {
            bool flags = false;
            do
            {
                Console.WriteLine("\nMORSE");

                Console.WriteLine("1. Teks -> Morse");
                Console.WriteLine("2. Morse -> Teks");
                Console.WriteLine(" ");
                Console.WriteLine("0. Keluar");


                Console.Write("Pilihan : ");
                if (!Int32.TryParse(Console.ReadLine(), out int pilihan))
                {
                    pilihan = -1;
                }

                switch (pilihan)
                {
                    case 1:
                        Text2Morse();
                        break;
                    case 2:
                        Morse2Text();
                        break;
                    case 0:
                        flags = true;
                        break;
                    default:
                        Console.WriteLine("Mohon masukkan angka 0 - 2");
                        Console.ReadKey(intercept: true);
                        break;
                }
            } while (!flags);
            Console.WriteLine("Program selesai");
        }

        private static void Morse2Text()
        {
            Console.Write("MORSE : ");
            var str = Console.ReadLine();
            var ret = _conv.ConvertBack(str);
            Console.WriteLine($"TEKS :\n{ret}");
            Console.ReadKey(intercept: true);
        }

        private static void Text2Morse()
        {
            Console.Write("TEKS : ");
            var str = Console.ReadLine();
            var ret = _conv.Convert(str);
            Console.WriteLine($"MORSE :\n{ret}");
            Console.ReadKey(intercept: true);
        }
    }
}