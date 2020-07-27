using System; 
using System.Linq;
using System.Text;

namespace Morse
{
    class Program
    {
        private const string separator = " / ";

        static void Main(string[] args)
        { 
            Console.WriteLine("MORSE");

            string textToChange = "";
            StringBuilder sb = new StringBuilder();
            

            Console.Write("Masukkan Teks : ");
            textToChange = Console.ReadLine()
                                  .ToLower();

            foreach (var c in textToChange.Where(x => Database.CharToMorse.ContainsKey(x)))
            {
                sb.Append(Database.CharToMorse[c]);
                sb.Append(separator);
            }

            Console.WriteLine("Teks dalam Sandi Morse");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();

        }
    }
}