using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnalizadorLexico.Helpers
{
    sealed class RegexMatcher : IMatcher
    {
        private readonly Regex regex;
        public RegexMatcher(string regex)
        {
            this.regex = new Regex(string.Format("^{0}", regex));
        }

        public int Match(string text)
        {
            var m = regex.Match(text);
            return m.Success ? m.Length : 0;
        }

        public override string ToString()
        {
            return regex.ToString();
        }
    }
}
