using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico.Helpers
{
    public class SemanticToken
    {
        public int Rule { get; set; }
        public List<int> TokenList { get; set; }
        public List<string> LexemList { get; set; }
        public List<Pair> PairList { get; set; }
        public SemanticToken()
        {
            this.TokenList = new List<int>();
            this.LexemList = new List<string>();
            this.PairList = new List<Pair>();
        }
        public SemanticToken(int rule, List<int> tokenList, List<string> lexemList, List<Pair> pairList)
        {
            this.Rule = rule;
            this.TokenList = tokenList;
            this.LexemList = lexemList;
            this.PairList = pairList;
        }
    }
}
