using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.RandomGenerator.Number
{
    public class RandomNumber : IRandomNumberGenerator
    {
        private static readonly Random _random = new Random();

        public int GenerateRandomInteger( int min, int max )
        {
            return _random.Next( min, max );
        }

        public float GenerateRandomFloat( float min, float max )
        {
            return (float)( _random.NextDouble() * ( max - min ) + min );
        }

        public double GenerateRandomDouble( float min, float max )
        {
            return _random.NextDouble() * ( max - min ) + min;
        }
    }
}
