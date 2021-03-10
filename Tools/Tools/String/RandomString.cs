using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.RandomGenerator.String
{
    public class RandomString
    {
        internal static Random _random = new Random();

        public string GenerateRandomAlphabeticString( int numberCharacters )
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[ numberCharacters ];

            for( int i = 0; i < stringChars.Length; i++ )
            {
                stringChars[ i ] = chars[ _random.Next( chars.Length ) ];
            }

            var finalString = new string( stringChars );

            return finalString;
        }
    }
}
