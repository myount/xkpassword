using System;

namespace XkPassword
{
    internal static class RandomExtensions
    {
        /// <summary>
        ///     Randomly returns true or false.
        /// </summary>
        /// <returns>A randomly selected true or false value.</returns>
        public static bool CoinFlip(this Random random)
        {
            return Convert.ToBoolean(random.Next(0, 2));
        }
    }
}