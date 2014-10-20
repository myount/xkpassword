using System.Collections.Generic;
using System.Linq;

namespace XkPassword.PublicExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="HashSet{T}"/> of <see cref="char"/>s that may be useful to consumers of <see cref="XkPasswd"/>.
    /// </summary>
    public static class HashSetExtensions
    {
        /// <summary>
        /// Adds the unique items from an <see cref="IEnumerable{T}"/> of <see cref="char"/> to the hash set.
        /// </summary>
        /// <param name="hashSet">The hash set.</param>
        /// <param name="charEnumerable">The characters to add to the hash set.</param>
        public static void AddCharArray(this HashSet<char> hashSet, IEnumerable<char> charEnumerable)
        {
            if (hashSet == null)
            {
                return;
            }

            if (charEnumerable == null)
            {
                return;
            }

            foreach (char c in charEnumerable.Distinct())
            {
                hashSet.Add(c);
            }
        }

        /// <summary>
        /// Clears the hash set and sets its contents to the unique characters from the <see cref="IEnumerable{T}"/> of <see cref="char"/>.
        /// </summary>
        /// <param name="hashSet">The hash set.</param>
        /// <param name="charEnumerable">The characters to add to the hash set.</param>
        public static void FromCharArray(this HashSet<char> hashSet, IEnumerable<char> charEnumerable)
        {
            if (hashSet == null)
            {
                return;
            }

            if (charEnumerable == null)
            {
                return;
            }

            hashSet.Clear();
            hashSet.AddCharArray(charEnumerable);
        }
    }
}