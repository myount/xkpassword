using System.Collections.Generic;
using System.IO;

namespace XkPassword
{
    internal static class StreamReaderExtensions
    {
        /// <summary>
        ///     Reads all lines from a <see cref="StreamReader" /> and returns them in an <see cref="IEnumerable{T}" /> of <see cref="string"/>.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="string"/> of lines available from the StreamReader.</returns>
        public static IEnumerable<string> ReadAllLines(this StreamReader reader)
        {
            while (!reader.EndOfStream)
            {
                yield return reader.ReadLine();
            }
        }
    }
}