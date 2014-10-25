namespace XkPassword
{
    /// <summary>
    /// An interface for classes which provide a source of random integers or booleans.
    /// </summary>
    public interface IRandomSource
    {
        /// <summary>
        /// Gets the next integer between minValue and maxValue from the random source.
        /// </summary>
        /// <param name="minValue">The lower bound of the range of possible integers to return.</param>
        /// <param name="maxValue">The upper bound, exclusive, of the range of possible integers to return.</param>
        /// <returns>An integer in the range [minValue..maxValue).</returns>
        int Next(int minValue, int maxValue);

        /// <summary>
        /// Returns a randomly chosen true or false value.
        /// </summary>
        /// <returns>A randomly chosen true or false value.</returns>
        bool CoinFlip();
    }
}