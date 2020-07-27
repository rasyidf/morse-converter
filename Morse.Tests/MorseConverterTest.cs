using System;
using Xunit;

namespace Morse.Tests
{
    public class MorseConverterTest
    {
        

        MorseConverter converter;

        public MorseConverterTest()
        {
            converter = new MorseConverter();
        }
 


        [Fact]
        public void ConvertTest()
        {
            Assert.Equal(converter.Convert("a"), Database.CharToMorse['a']);
        }

        [Fact]
        public void ConvertBackTest()
        {
            Assert.Equal(converter.ConvertBack(Database.CharToMorse['a']), "a");
        }
    }
}
