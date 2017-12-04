using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico.Helpers
{
    public sealed class TokenDefinition
    {
        public readonly IMatcher Matcher;
        public readonly int Token;
        public readonly object Lexeme;
        public readonly bool Ignore;

        public TokenDefinition(string regex, object lexem, int token)
        {
            this.Matcher = new RegexMatcher(regex);
            this.Lexeme = lexem;
            this.Token = token;
        }
    }
}
