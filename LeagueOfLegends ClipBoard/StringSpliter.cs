using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends_ClipBoard
{
    public static class StringSpliter
    {

        public static IEnumerable<String> SplitString(this String clipboard, Int32 partLength)
        {
            if (clipboard == null)
                throw new ArgumentNullException("s");
            if (partLength <= 0)
                throw new ArgumentException("La taille des parties dois être positive.", "partLength");

            for (var i = 0; i < clipboard.Length; i += partLength)
                yield return clipboard.Substring(i, Math.Min(partLength, clipboard.Length - i));
        }

    }
}
