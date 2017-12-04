using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AnalizadorLexico.Helpers;

namespace AnalizadorLexico
{
    public partial class LexicalAnalyzer : Form
    {
        string[] Words;
        TokenDefinition[] Rules = new TokenDefinition[0];
        List<int> Rule1 = new List<int>();
        List<Pair> Pairs = new List<Pair>();
        List<int> TableTokens = new List<int>();
        List<string> TableLexems = new List<string>();
        List<SemanticToken> SemanticTokens = new List<SemanticToken>();
        private static readonly string[] Keywords = {"class", "new" , "public", "private", "int", "string", };
        public LexicalAnalyzer()
        {
            InitializeComponent();
            DefineTokens();
            DefineRules();
        }

        private void btnInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.Title = "Browse for txt file";

            OpenFileDialog.CheckFileExists = true;
            OpenFileDialog.CheckPathExists = true;

            OpenFileDialog.DefaultExt = "txt";
            OpenFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = null;
                textInputFile.Text = OpenFileDialog.FileName;
                try
                {
                    using (stream = new StreamReader(OpenFileDialog.OpenFile()))
                    {
                        string[] Words = stream.ReadToEnd().Split(' ');
                        textInputText.Clear();
                        for (int i = 0; i < Words.Length; i++)
                        {
                            textInputText.Text += Words[i];
                            textInputText.Text += " ";
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void btnLex_Click(object sender, EventArgs e)
        {
            string input = System.IO.File.ReadAllText(textInputFile.Text);
            textOutputText.Clear();
            CopyInput(textInputText.Text);
        }

        private void ReadWords(string input)
        {
            Words = input.Split(' ');
        }

        private void CopyInput(string input)
        {
            //textOutputText.Text = input;
            Pairs.Clear();
            TableTokens.Clear();
            TableLexems.Clear();

            TextReader r = new StringReader(input);
            Lexer l = new Lexer(r, Rules);
            while (l.Next())
            {
                if ((int)l.Token != 0)
                {
                    Pairs.Add(new Pair((int)l.Token, l.TokenContents));
                    TableTokens.Add((int)l.Token);
                    TableLexems.Add(l.TokenContents);
                }
            }

            for (int i = 0; i < Pairs.Count; i++)
            {
                if (i > 0)
                {
                    textOutputText.Text += ", ";
                }
                textOutputText.Text += (Pairs[i].Token);
                //textOutputText.Text += (TableTokens[i] + "   " + TableLexems[i]+ "\r\n");
            }
        }

        private void DefineTokens()
        {
            Rules = new TokenDefinition[]
            {
                new TokenDefinition(@"\s", "Espacio", 0),
                new TokenDefinition(@"int", "int", 10),
                new TokenDefinition(@"string", "string", 10),
                new TokenDefinition(@"bool", "bool", 10),
                new TokenDefinition(@"char", "char", 10),
                new TokenDefinition(@"double", "double", 10),
                new TokenDefinition(@"long", "long", 10),
                new TokenDefinition(@"array", "array", 10),
                new TokenDefinition(@"list", "list", 10),
                new TokenDefinition(@"void", "void", 10),
                new TokenDefinition(@"public", "public", 20),
                new TokenDefinition(@"private", "private", 20),
                new TokenDefinition(@"protected", "protected", 20),
                new TokenDefinition(@"class", "class", 21),
                new TokenDefinition(@"static", "static", 22),
                new TokenDefinition(@"main", "main", 1),
                new TokenDefinition(@"return", "return", 21),
                new TokenDefinition(@"if", "if", 23),
                new TokenDefinition(@"else", "else", 24),
                new TokenDefinition(@"for", "for", 25),
                new TokenDefinition(@"foreach", "foreach", 26),
                new TokenDefinition(@"while", "while", 27),
                new TokenDefinition(@"switch", "switch", 28),
                new TokenDefinition(@"case", "case", 29),
                new TokenDefinition(@"true", "true", 61),
                new TokenDefinition(@"false", "false", 62),
                new TokenDefinition(@"null", "null", 99),
                new TokenDefinition(@"\(", "Parentesis Izq", 41),
                new TokenDefinition(@"\)", "Parentesis der", 42),
                new TokenDefinition(@"\[", "Corchete Izq", 43),
                new TokenDefinition(@"\]", "Corchete der", 44),
                new TokenDefinition(@"\{", "Llave Izq", 45),
                new TokenDefinition(@"\}", "Llave der", 46),
                new TokenDefinition(@"\;", "Cierre", 101),
                new TokenDefinition(@"\:=", "Igual", 100),
                new TokenDefinition(@"\==", "==", 50),
                new TokenDefinition(@"\!=", "!=", 50),
                new TokenDefinition(@"\<", "<", 50),
                new TokenDefinition(@"\<=", "<=", 50),
                new TokenDefinition(@"\>", ">", 50),
                new TokenDefinition(@"\>=", ">=", 50),
                new TokenDefinition(@"\&&", "&&", 51),
                new TokenDefinition(@"\||", "||", 52),
                new TokenDefinition(@"\+=", "+=", 54),
                new TokenDefinition(@"\-=", "-=", 54),
                new TokenDefinition(@"\++", "++", 55),
                new TokenDefinition(@"\--", "--", 55),
                new TokenDefinition(@"\+", "+", 53),
                new TokenDefinition(@"\-", "-", 53),
                new TokenDefinition(@"\*", "*", 53),
                new TokenDefinition(@"\/", "/", 53),
                //new TokenDefinition(@"\%", "%", 53),
                //new TokenDefinition(@"\^", "^", 53),
                new TokenDefinition(@"[a-zA-Z_$][a-zA-Z_$0-9]*\s?", "Id", 31),
                new TokenDefinition(@"([""'])(?:\\\1|.)*?\1", "String", 32),
                new TokenDefinition(@"[-+]?[0-9]*\.[0-9]*", "Flotante", 33),
                new TokenDefinition(@"[-+]?\d+", "Entero", 34),
            };
        }

        private void DefineRules()
        {
            Rule1.Add(20);
            Rule1.Add(22);
            Rule1.Add(10);
            Rule1.Add(1);
            Rule1.Add(41);
            Rule1.Add(42);
            Rule1.Add(45);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            CheckRule1();
        }
        private void CheckRule1()
        {
            var check = true;
            for (int i = 0; i < 7; i++)
            {
                if (Rule1[i] != Pairs[i].Token)
                {
                    check = false;
                }
            }
            if (check && Pairs[Pairs.Count - 1].Token == 46)
            {
                textTree.Text = "Regla 1";
                RemoveTokens(7, true);
                while (Pairs.Count > 0)
                {
                    CheckRules();
                }
            }
        }
        
        private void CheckRules()
        {
            while (Pairs.Count > 0)
            {
                CheckSent(Pairs, 0);
            }
        }

        // Sentencia
        private int CheckSent(List<Pair> Pairs, int StartToken)
        {
            textTree.Text += ", Regla 2";
            // Declaracion
            if (Pairs[StartToken].Token == 10 && Pairs[StartToken + 1].Token == 31 && Pairs[StartToken + 2].Token == 100 && (Pairs[StartToken + 3].Token == 31 || Pairs[StartToken + 3].Token == 32 || Pairs[StartToken + 3].Token == 33 || Pairs[StartToken + 3].Token == 34) && Pairs[StartToken + 4].Token == 101)
            {
                textTree.Text += ", Regla 9";
                SemanticToken token = new SemanticToken();
                token.Rule = 9;
                for (int i = 0; i < 5; i++)
                {
                    token.PairList.Add(Pairs[i]);
                    token.TokenList.Add(Pairs[i].Token);
                    token.LexemList.Add(TableLexems[i]);
                }
                SemanticTokens.Add(token);
                return RemoveTokens(5, false);
            }
            // If
            else if ((Pairs[0].Token == 23 || Pairs[0].Token == 27) && Pairs[1].Token == 41)
            {
                int inputInt = CheckIf(Pairs, 2) + 1;
                int outputInt = 0;

                if (inputInt != 1)
                {
                    if (Pairs[0].Token == 23)
                    {
                        textTree.Text += ", Regla 3";
                    }
                    else if (Pairs[0].Token == 27)
                    {
                        textTree.Text += ", Regla 8";
                    }
                    textTree.Text += ", Regla 4";
                }

                List<Pair> temp_Sent = ReloadSent(Pairs, inputInt + 1);
                outputInt = inputInt + 1 + temp_Sent.Count;
                inputInt = CheckSent(temp_Sent, 0);
                int removedTokens = RemoveTokens(outputInt - inputInt + 1, false);

                if (Pairs.Count > 0 && (Pairs[0].Token == 24 && Pairs[1].Token == 45))
                {
                    temp_Sent = ReloadSent(Pairs, 2);
                    CheckSent(temp_Sent, 0);
                    return RemoveTokens(3, false);
                }
                else
                {
                    return removedTokens;
                }
            }
            else if (Pairs[0].Token == 25 && Pairs[1].Token == 41)
            {
                //For
                int inputInt = CheckFor(Pairs) + 2;
                if (inputInt != 1 && Pairs[inputInt - 2].Token == 42 && Pairs[inputInt - 1].Token == 45)
                {
                    List<Pair> temp_Sent = ReloadSent(Pairs, inputInt);
                    int outputInt = 0;
                    outputInt = inputInt + 1 + temp_Sent.Count;
                    inputInt = CheckSent(temp_Sent, 0);
                    int removedTokens = RemoveTokens(outputInt - inputInt, false);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        private int CheckDecl(List<Pair> Pairs)
        {
            if (Pairs[0].Token == 10 && Pairs[1].Token == 31 && Pairs[2].Token == 100 && (Pairs[3].Token == 31 || Pairs[3].Token == 32 || Pairs[3].Token == 33 || Pairs[3].Token == 34) && Pairs[4].Token == 101)
            {
                SemanticToken token = new SemanticToken();
                token.Rule = 9;
                //token.TokenList = new List<int>();
                //token.LexemList = new List<LexemList>();
                for (int i = 0; i < 5; i++)
                {
                    token.PairList.Add(Pairs[i]);
                    token.TokenList.Add(Pairs[i].Token);
                    token.LexemList.Add(TableLexems[i]);
                }
                SemanticTokens.Add(token);

                textTree.Text += ", Regla 9";
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int CheckIf(List<Pair> Pairs, int StartToken)
        {
            int tempInt = 0;
            // OpLog
            List<Pair> temp_OpLog = new List<Pair>();
            for (int i = StartToken; i < Pairs.Count; i++)
            {
                if (Pairs[i].Token != 42)
                {
                    temp_OpLog.Add(Pairs[i]);
                }
                else
                {
                    tempInt = i;
                    break;
                }
            }
            if (CheckOpLog(temp_OpLog) && Pairs[tempInt + 1].Token == 45)
            {
                RemoveTokens(tempInt - StartToken, false);
                return tempInt;
            }
            else
            {
                return 0;
            }
        }

        private bool CheckOpLog(List<Pair> Pairs)
        {
            if ((Pairs[0].Token == 31 || Pairs[0].Token == 32 || Pairs[0].Token == 33 || Pairs[0].Token == 34) && Pairs[1].Token == 50 && (Pairs[2].Token == 31 || Pairs[2].Token == 32 || Pairs[2].Token == 33 || Pairs[2].Token == 34))
            {
                SemanticToken token = new SemanticToken();
                token.Rule = 4;
                //token.TokenList = new List<int>();
                //token.LexemList = new List<LexemList>();
                for (int i = 0; i < 3; i++)
                {
                    token.PairList.Add(Pairs[i]);
                    token.TokenList.Add(Pairs[i].Token);
                    token.LexemList.Add(TableLexems[i]);
                }
                SemanticTokens.Add(token);
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CheckAsig(List<Pair> Pairs)
        {
            if (Pairs[0].Token == 31)
            {
                if (Pairs[1].Token == 55 && Pairs.Count == 2)
                {
                    textTree.Text += ", Regla 10";
                    return 1;
                }
                else if (Pairs[1].Token == 54 && (Pairs[2].Token == 31 || Pairs[2].Token == 32 || Pairs[2].Token == 33 || Pairs[2].Token == 34) && Pairs.Count == 3)
                {
                    textTree.Text += ", Regla 10";
                    return 1;
                }
                else if (Pairs[1].Token == 100 && (Pairs[2].Token == 31 || Pairs[2].Token == 32 || Pairs[2].Token == 33 || Pairs[2].Token == 34))
                {
                    if (Pairs.Count == 3)
                    {
                        textTree.Text += ", Regla 10";
                        return 1;
                    }
                    else if (Pairs.Count % 2 == 1)
                    {
                        for (int i = 3; i < Pairs.Count; i++)
                        {
                            if (i % 2 == 1)
                            {
                                if (Pairs[i].Token != 53)
                                {
                                    return 0;
                                }
                            }
                            else
                            {
                                if (!(Pairs[2].Token == 31 || Pairs[2].Token == 32 || Pairs[2].Token == 33 || Pairs[2].Token == 34))
                                {
                                    return 0;
                                }
                            }
                        }
                        textTree.Text += ", Regla 10";
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        private int CheckFor(List<Pair> Pairs)
        {
            textTree.Text += ", Regla 7";
            int tempInt = 0;
            List<Pair> temp_Decl = new List<Pair>();
            for (int i = 2; i < Pairs.Count; i++)
            {
                if (Pairs[i-1].Token != 101)
                {
                    temp_Decl.Add(Pairs[i]);
                }
                else
                {
                    tempInt = i;
                    break;
                }
            }

            if (CheckDecl(temp_Decl) == 1)
            {
                List<Pair> temp_OpLog = new List<Pair>();
                for (int i = tempInt; i < Pairs.Count; i++)
                {
                    if (Pairs[i].Token != 101)
                    {
                        temp_OpLog.Add(Pairs[i]);
                    }
                    else
                    {
                        tempInt = i + 1;
                        break;
                    }
                }
                if (CheckOpLog(temp_OpLog))
                {
                    List<Pair> temp_Asig = new List<Pair>();
                    for (int i = tempInt; i < Pairs.Count; i++)
                    {
                        if (Pairs[i].Token != 42)
                        {
                            temp_Asig.Add(Pairs[i]);
                        }
                        else
                        {
                            tempInt = i;
                            break;
                        }
                    }
                    if (CheckAsig(temp_Asig) == 1)
                    {
                        return tempInt;
                    }
                    else
                    {
                        return 0;
                    }
                }
                return 0;
            }
            else
            {
                //Error Declaracion
                return 0;
            }
        }

        private List<Pair> ReloadSent(List<Pair> Tokens, int inputInt)
        {
            List<Pair> temp_Sent = new List<Pair>();
            for (int i = inputInt; i < Tokens.Count; i++)
            {
                if (Tokens[i].Token != 46)
                {
                    temp_Sent.Add(Tokens[i]);
                }
                else
                {
                    break;
                }
            }
            return temp_Sent;
        }

        private int RemoveTokens(int a, bool b)
        {
            Pairs = Pairs.Skip(a).Take(Pairs.Count - a).ToList();
            if (b)
            {
                Pairs.RemoveAt(Pairs.Count - 1);
                return a + 1;
            }
            return a;
        }

        private void btnSem_Click(object sender, EventArgs e)
        {
            int cont = 1;
            foreach (var sToken in SemanticTokens)
            {
                //textTreeErrors.Text += "Rule " + sToken.Rule + ": ";
                switch (sToken.Rule)
                {
                    case 4:
                        for (int i = 0; i < sToken.LexemList.Count; i++)
                        {
                            if (i > 0)
                            {
                                textTreeErrors.Text += ", ";
                            }

                            textTreeErrors.Text += sToken.TokenList[i];
                            //textTreeErrors.Text += sToken.LexemList[i];
                        }
                        /*foreach (var token in sToken.LexemList)
                        {
                            textTreeErrors.Text += ", " + token;
                        }*/
                        textTreeErrors.Text += "\r\n";
                        break;
                    case 9:
                        textTreeErrors.Text += "Declaration: ";
                        switch (sToken.LexemList[0])
                        {
                            case "int":
                                if (sToken.TokenList[3] == 34)
                                {
                                    textTreeErrors.Text += "[" + sToken.LexemList[2] + "," + sToken.LexemList[1] + "," + sToken.LexemList[3] + ",L" + cont + "]";
                                    cont++;
                                }
                                break;
                            case "string":
                                if (sToken.TokenList[3] == 32)
                                {
                                    textTreeErrors.Text += "[" + sToken.LexemList[2] + "," + sToken.LexemList[1] + "," + sToken.LexemList[3] + ",L" + cont + "]";
                                    cont++;
                                }
                                break;
                            case "double":
                                if (sToken.TokenList[3] == 33)
                                {
                                    textTreeErrors.Text += "[" + sToken.LexemList[2] + "," + sToken.LexemList[1] + "," + sToken.LexemList[3] + ",L" + cont + "]";
                                    cont++;
                                }
                                break;
                            default:
                                break;
                        }
                        /*
                        for (int i = 0; i < sToken.LexemList.Count; i++)
                        {
                            if (i > 0)
                            {
                                textTreeErrors.Text += ", ";
                            }
                            textTreeErrors.Text += "[" + sToken.TokenList[i] + "," + sToken.LexemList[i] + "]";
                            //textTreeErrors.Text += sToken.LexemList[i];
                        }*/
                        /*foreach (var token in sToken.LexemList)
                        {
                            textTreeErrors.Text += ", " + token;
                        }*/
                        textTreeErrors.Text += "\r\n";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
