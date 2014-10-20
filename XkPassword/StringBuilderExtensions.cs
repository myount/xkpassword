using System.Text;

namespace XkPassword
{
    internal static class StringBuilderExtensions
    {
        public static void Truncate(this StringBuilder builder, int desiredLength)
        {
            if (builder.Length < desiredLength)
            {
                return;
            }

            builder.Remove(desiredLength, builder.Length - desiredLength);
        }
    }
}