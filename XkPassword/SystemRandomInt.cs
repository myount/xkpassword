using System;

namespace XkPassword
{
    /// <summary>
    /// The default source of random integers, which simply wraps System.Random.
    /// </summary>
    internal class DefaultRandomSource : IRandomSource
    {
        private static readonly Random RandomSource = new Random();

        /// <summary>
        /// Get the next integer between minValue and maxValue from the random source.
        /// </summary>
        /// <param name="minValue">The lower bound of the range of possible integers to return.</param>
        /// <param name="maxValue">The upper bound, exclusive, of the range of possible integers to return.</param>
        /// <returns>An integer in the range [minValue..maxValue).</returns>
        public int Next(int minValue, int maxValue)
        {
            return RandomSource.Next(minValue, maxValue);
        }

        /// <summary>
        /// Returns a randomly chosen true or false value.
        /// </summary>
        /// <returns>A randomly chosen true or false value.</returns>
        public bool CoinFlip()
        {
            return Convert.ToBoolean(Next(0, 2));
        }
    }
}
