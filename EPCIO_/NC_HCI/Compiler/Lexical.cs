using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCIO.NC_HCI.Compiler
{
    class Lexical
    {
        readonly static string[] Gkw = new string[] { "00", "01", "02", "03", "04", "27", "28", "29", "34", "43" };
        readonly static string[] GPkw = new string[] { "17","18", "19", "20", "21", "40", "61", "63", "64", "71", "90", "91" };
        readonly static string[] Mkw = new string[] { "00", "01", "02", "03", "05", "06", "08", "25", "26", "30" };
        readonly static string[] AXISkw = new string[] { "X", "Y", "Z", "I", "J", "K", "R", "H", "P", "L" };

        public List<string> getTokenType(string block)
        {
            //將Block依據' ' 切割,存入資料型態為string[]中,並做型態轉換
            List<string> TKblock = new List<string> ( block.Split(' ') );
            //宣告回傳
            List<string> TokenStream = new List<string>();

            for (int TKblockNum = 0; TKblockNum < TKblock.Count; TKblockNum++)
            {
                string word = TKblock[TKblockNum];

                if (isNtk(word))
                {
                    TokenStream.Add(Header.TokenType.Ntk.ToString());
                }
                else if (isGCode(word))
                {
                    TokenStream.Add(Header.TokenType.Gtk.ToString());
                }
                else if (isGPCode(word))
                {
                    TokenStream.Add(Header.TokenType.GPtk.ToString());
                }
                else if (isMCode(word))
                {
                    TokenStream.Add(Header.TokenType.Mtk.ToString());
                }
                else if (isTCode(word))
                {
                    TokenStream.Add(Header.TokenType.Ttk.ToString());
                }
                else if (isFCode(word))
                {
                    TokenStream.Add(Header.TokenType.Ftk.ToString());
                }
                else if (isAXIS(word))
                {
                    TokenStream.Add(Header.TokenType.AXIStk.ToString());
                }
                else if (isSCode(word))
                {
                    TokenStream.Add(Header.TokenType.Stk.ToString());
                }
                else
                {
                    TokenStream.Add(Header.TokenType.UNDEFtk.ToString());
                }
            }
            TokenStream.Add(Header.TokenType.EOBtk.ToString());
            return TokenStream;
        }
        private static bool isNtk(string word)
        {
            bool result = false;
            //如果第一個字節是N
            if(word.Substring(0,1)=="N")
            {
                result = true;
            }
            return result;
        }

        private static bool isGCode(string word)
        {
            bool result = false;
            //如果字節第一個字是G且後面數字有符合
            for(int i = 0; i < Gkw.Length; i++)
            {
                if (word.Substring(0, 1) == "G" && word.Substring(1, 2).ToString() == Gkw[i]) ; //若開頭為G,一一對照後面是否有Gtoken之編號
                {
                    result = false;
                }
            }
            return result;
        }

        private static bool isGPCode(string word)
        {
            bool result = false;
            //如果字節第一個字G且後面數字有符合
            for(int i = 0; i < GPkw.Length; i++)
            {
                if(word.Substring(0,1)=="G" && word.Substring(1, 2).ToString() == GPkw[i])
                {
                    result = true;
                }
            }
            return result;
        }
        private static bool isMCode(string word)
        {
            bool result = false;
            //若第一個字是M且後面數字有符合
            for (int i = 0; i < Mkw.Length; i++)
            {
                if (word.Substring(0, 1) == "M" && word.Substring(1, 2) == Mkw[i])
                {
                    result = true;
                }
            }
            return result;
            
        }

        private static bool isTCode(string word)
        {
            bool result = false;
            //如果字節第一個字是T且後面數字有符合

            //未處理kw
            if (word.Substring(0, 1) == "T")
            {
                result = true;
            }
            return result;
        }
        private static bool isFCode(string word)
        {
            bool result = false;
            //如果字節第一個字是F且後面數字有符合
            if (word.Substring(0, 1) == "F")
            {
                result = true;
            }
            return result;
        }

        private static bool isAXIS(string word)
        {
            bool result = false;
            //如果字節第一個字是G且後面數字有符合
            for(int i = 0; i < AXISkw.Length; i++)
            {
                result = true;
            }
            return false;
        }

        private static bool  isSCode(string word)
        {
            bool result = false;
            if (word.Substring(0, 1) == "S")
            {
                result = true;
            }
            return result;
        }
    }
}
