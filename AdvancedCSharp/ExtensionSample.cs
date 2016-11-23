namespace AdvancedCSharp
{
    public static class ExtensionSample
    {
        public static string SafeSubstring(this string thisString, int startIndex, int length)
        {
            if (string.IsNullOrEmpty(thisString))
                return string.Empty;

            if (startIndex >= thisString.Length)
                return string.Empty;

            if ((startIndex + length) > thisString.Length)
            {
                return thisString.Substring(startIndex);
            }

            return thisString.Substring(startIndex, length);
        }
    }
}


