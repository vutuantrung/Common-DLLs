using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.RandomGenerator.String
{
    public interface IRandomStringGenerator
    {
        /// <summary>
        /// Generate random alphabetic string by number of character
        /// </summary>
        /// <param name="numberCharacters">Number of character required</param>
        /// <returns>Random alphabetic string</returns>
        public string GenerateRandomAlphabeticString( int numberCharacters );
    }
}
