
using System.Linq;
using System.Text;

namespace Morse
{    
    public interface IValueConverter<T>
    {
         T Convert(T value);
 
         T ConvertBack(T value);

    }
    public class MorseConverter : IValueConverter<string>
    {
        private const string separator = " / ";
        private static StringBuilder sb;
        public string Convert(string value)
        {
            var count = 0;
            sb = new StringBuilder();
            foreach (var c in value.ToLower().Where(x => Database.CharToMorse.ContainsKey(x)))
            {
                if (count > 1) sb.Append(separator);
                sb.Append(Database.CharToMorse[c]);
                count++;
            }

            return sb.ToString();
        }

        public string ConvertBack(string value)
        {  
            sb = new StringBuilder();
            var values = value.Split(separator);
            foreach (var c in values.Where(x => Database.Morse2Char.ContainsKey(x)))
            {
                sb.Append(Database.Morse2Char[c]); 
            }
            
            return sb.ToString();
        }
 
    }
}