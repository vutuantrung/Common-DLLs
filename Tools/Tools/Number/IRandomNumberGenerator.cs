using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.RandomGenerator.Number
{
    public interface IRandomNumberGenerator
    {
        /// <summary>
        /// Generate random integer number
        /// </summary>
        /// <param name="min">Min integer number</param>
        /// <param name="max">Max integer number</param>
        /// <returns>Random integer number</returns>
        int GenerateRandomInteger( int min, int max );

        /// <summary>
        /// Generate random float number
        /// </summary>
        /// <param name="min">Min float number</param>
        /// <param name="max">Max float number</param>
        /// <returns>Random float number</returns>
        float GenerateRandomFloat( float min, float max );

        /// <summary>
        /// Generate random double number
        /// </summary>
        /// <param name="min">Min double number</param>
        /// <param name="max">Max double number</param>
        /// <returns>Random double number</returns>
        double GenerateRandomDouble( float min, float max );
    }
}
