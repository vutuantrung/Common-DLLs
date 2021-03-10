using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.RandomGenerator.Number
{
    public static class RandomNumber
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Generate random integer number
        /// </summary>
        /// <param name="min">Min integer number</param>
        /// <param name="max">Max integer number</param>
        /// <returns>Random integer number</returns>
        public static int GenerateRandomInteger( int min, int max )
        {
            return _random.Next( min, max );
        }

        /// <summary>
        /// Generate random float number
        /// </summary>
        /// <param name="min">Min float number</param>
        /// <param name="max">Max float number</param>
        /// <returns>Random float number</returns>
        public static float GenerateRandomFloat( float min, float max )
        {
            return (float)( _random.NextDouble() * ( max - min ) + min );
        }

        /// <summary>
        /// Generate random double number
        /// </summary>
        /// <param name="min">Min double number</param>
        /// <param name="max">Max double number</param>
        /// <returns>Random double number</returns>
        public static double GenerateRandomDouble( float min, float max )
        {
            return _random.NextDouble() * ( max - min ) + min;
        }
    }
}
