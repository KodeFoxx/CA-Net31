using System.Collections.Generic;

namespace Kf.CANetCore31
{
    public static class Null
    {
        public static string NullString
            => $"(*null)";

        public static KeyValuePair<string, string> NullKeyValuePair
            => KeyValuePair.Create(NullString, NullString);
    }
}
