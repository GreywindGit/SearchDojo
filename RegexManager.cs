using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchDojo
{
    class RegexManager
    {
        public static List<string> SearchAndGetMatches(string input, string pattern)
        {
            List<string> foundMatches = new List<string>();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                foundMatches.Add(match.Value.ToString());
            }
            return foundMatches;
        }
    }
}
