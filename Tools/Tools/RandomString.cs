using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.RandomGenerator.String
{
    public static class RandomString
    {
        internal static Random _random = new Random();

        /// <summary>
        /// Generate random alphabetic string by number of character
        /// </summary>
        /// <param name="numberCharacters">Number of character required</param>
        /// <returns>Random alphabetic string</returns>
        public static string GenerateRandomAlphabeticString( int numberCharacters )
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
