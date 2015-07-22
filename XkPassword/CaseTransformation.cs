namespace XkPassword
{
    /// <summary>
    ///     An enumeration representing possible word case transformations.
    /// </summary>
    /// <remarks><b>N.B.:</b> All transformations are performed using the invariant culture.</remarks>
    public enum CaseTransformation
    {
        /// <summary>
        ///     Perform no case transformation.
        /// </summary>
        None = 0,
        /// <summary>
        ///     Transform word to ALL UPPERCASE.
        /// </summary>
        UpperCase = 1,
        /// <summary>
        ///     Transform word to all lowercase.
        /// </summary>
        LowerCase = 2,
        /// <summary>
        ///     Capitalize the first letter of the word.
        /// </summary>
        Capitalize = 3,
        /// <summary>
        ///     Capitalise the first letter of the word.
        /// </summary>
        /// <remarks>For British users.</remarks>
        Capitalise = Capitalize,
        /// <summary>
        ///     iNVERT THE CASE OF THE WORD.
        /// </summary>
        Invert = 4,
        /// <summary>
        ///     AlTeRnAtE tHe CaSe Of ThE wOrD.
        /// </summary>
        Alternate = 5,
        /// <summary>
        ///     RAndOmLY capITAliZe thE WorD.
        /// </summary>
        Random = 6,

        /// <summary>
        ///     RANDOMLY capitalize entire WORD
        /// </summary>
        RandomWord = 7
    }
}