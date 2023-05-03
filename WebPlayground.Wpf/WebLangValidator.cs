using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebPlayground.Wpf
{
    public  class WebLangValidator
    {
        public static bool IsValidCss(string cssContent)
        {
            // CSS validation pattern
            string pattern = @"^(([^{}@]+\{[^{}]*\}\s*)+)$";

            // Check if the input matches the pattern
            return Regex.IsMatch(cssContent, pattern);
        }
        public static bool IsValidECMAScript(string scriptContent)
        {
            // Define a regex pattern to match valid ECMAScript content
            Regex regex = new Regex(@"^[^`]*(?:`[^`]*`[^`]*)*$");

            // Check if the input string matches the regex pattern
            return regex.IsMatch(scriptContent);
        }
        public static bool IsValidHtml(string content)
        {
            // Define the regular expression pattern to match against
            string pattern = @"^([\s\S]*?)$";

            // Create a regular expression object with the pattern
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            // Match the pattern against the content
            Match match = regex.Match(content);

            // Return whether the content matches the pattern
            return match.Success;
        }
    }
}
