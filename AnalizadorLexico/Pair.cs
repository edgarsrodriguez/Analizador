using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class Pair
    {
        public int Token { get; set; }
        public string Lexem { get; set; }

        public Pair()
        {

        }

        public Pair(int token, string lexem)
        {
            this.Token = token;
            this.Lexem = lexem;
        }
    }
}
