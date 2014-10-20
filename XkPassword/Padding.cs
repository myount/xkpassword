namespace XkPassword
{
    /// <summary>
    /// An enumeration of possible password padding types.
    /// </summary>
    public enum Padding
    {
        /// <summary>
        /// No padding.
        /// </summary>
        None = 0,

        /// <summary>
        /// Fixed padding: a fixed number of characters will be added to the beginning and/or end of the password according to the configuration.
        /// </summary>
        Fixed = 1,

        /// <summary>
        /// Adaptive padding: in addition to a fixed number of characters being added to the beginning and/or end of the password according to the
        /// configuration, characters will be added to the end of the password to pad it out to a specific length.
        /// <b>N.B.:</b> This setting will have no effect if PadToLength is less than or equal to 0.
        /// </summary>
        Adaptive = 2
    }
}