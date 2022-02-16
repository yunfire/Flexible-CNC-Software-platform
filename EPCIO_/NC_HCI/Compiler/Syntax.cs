using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCIO.NC_HCI.Compiler
{
    class Syntax
    {
        public bool parser(List<string> tks)
        {
            List<string> checkedtks = new List<string>();

            bool result = false;

            //將Token Stream去除Ttk,並儲存於checkedtks
            for(int tks_index = 0; tks_index < tks.Count; tks_index++)
            {
                if (tks[tks_index] != "Ttk")//Ttk=T機能,去除T機能
                {
                    checkedtks.Add(tks[tks_index]);
                }
            }
            //呼叫CheckBlock進行語法分析
            if (CheckBlock(checkedtks))
            {
                return true;
            }
            return result;
        }

        int tokenindex = 0;
        //r5規則:Gtk接續AXISTK
        public static bool useR5 = false;

        private bool CheckBlock(List<string> list)
        {
            tokenindex = 0;
            
            if (list[tokenindex].Equals(Header.TokenType.Ntk.ToString()))
            {
                tokenindex++;
                Header.JudgeResult judgeResult_Gp = Gp(list);

                if (judgeResult_Gp.Equals(Header.JudgeResult.Compare_True))
                {
                    tokenindex++;
                }
                else if (judgeResult_Gp.Equals(Header.JudgeResult.Compare_False))
                {
                    ;
                }
                else
                {
                    return false;
                }

                Header.JudgeResult judgeResult_G = G(list);
                if (judgeResult_G.Equals(Header.JudgeResult.Compare_True))
                {
                    tokenindex++;
                }
                else if (judgeResult_G.Equals(Header.JudgeResult.Compare_False))
                {
                    ;
                }
                else
                {
                    return false;
                }

                Header.JudgeResult is_feed = feed(list);
                if (is_feed.Equals(Header.JudgeResult.Compare_True))
                {
                    tokenindex++;
                }
                else if (is_feed.Equals(Header.JudgeResult.Compare_False))
                {
                    ;
                }
                else
                {
                    return false;
                }
                Header.JudgeResult is_speed = speed(list);
                if (is_speed.Equals(Header.JudgeResult.Compare_True))
                {
                    tokenindex++;
                }
                else if (is_speed.Equals(Header.JudgeResult.Compare_False))
                {
                    ;
                }
                else
                {
                    return false;
                }

                Header.JudgeResult is_m = m(list);
                if (is_m.Equals(Header.JudgeResult.Compare_True))
                {
                    tokenindex++;
                }
                else if (is_m.Equals(Header.JudgeResult.Compare_False))
                {
                    ;
                }
                else
                    return false;

                if (list[tokenindex].Equals(Header.TokenType.EOBtk.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private Header.JudgeResult Gp(List<string> tks)
        {
            if (tks[tokenindex].Equals(Header.TokenType.GPtk.ToString()))
            {
                tokenindex++;
                Header.JudgeResult is_gp = Gp(tks);
                if (is_gp.Equals(Header.JudgeResult.Compare_True))
                {
                    return Header.JudgeResult.Compare_True;
                }
                else if (is_gp.Equals(Header.JudgeResult.Compare_False))
                {
                    tokenindex--;
                    return Header.JudgeResult.Compare_True;
                }
                else
                {
                    return Header.JudgeResult.Compare_NO;
                }
            }
            else
            {
                return Header.JudgeResult.Compare_False;
            }
        }

        private Header.JudgeResult G(List<string> tks)
        {
            if (tks[tokenindex].Equals(Header.TokenType.Gtk.ToString()))
            {
                tokenindex++;
                Header.JudgeResult is_gp = Gp(tks);

                if (is_gp.Equals(Header.JudgeResult.Compare_True))
                {
                    tokenindex++;
                }
                else if (is_gp.Equals(Header.JudgeResult.Compare_NO))
                {
                    ;//略過
                }
                else
                {
                    return Header.JudgeResult.Compare_NO;
                }

                if (coords(tks).Equals(Header.JudgeResult.Compare_True))
                {
                    return Header.JudgeResult.Compare_True;
                }
                else
                {
                    return Header.JudgeResult.Compare_NO;
                }
            }
            else if (coords(tks).Equals(Header.JudgeResult.Compare_True))//純規則5
            {
                useR5 = true;
                return Header.JudgeResult.Compare_True;
            }
            else
            {
                return Header.JudgeResult.Compare_False;
            }

        }

        private Header.JudgeResult coords(List<string> tks)
        {
            if (tks[tokenindex] == Header.TokenType.AXIStk.ToString())
            {
                tokenindex++;

                Header.JudgeResult is_coords = coords(tks);
                if (is_coords.Equals(Header.JudgeResult.Compare_True))
                {
                    return Header.JudgeResult.Compare_True;
                }
                else if (is_coords.Equals(Header.JudgeResult.Compare_False))
                {
                    tokenindex--;
                    return Header.JudgeResult.Compare_True;//代表前一個index是AXIS true 而現在這個不是
                }
                else
                    return Header.JudgeResult.Compare_NO;
            }
            else
            {
                return Header.JudgeResult.Compare_False;
            }
        }

        private Header.JudgeResult feed(List<string> tks)
        {
            if (tks[tokenindex].Equals(Header.TokenType.Ftk.ToString()))
            {
                return Header.JudgeResult.Compare_True;
            }
            else
            {
                return Header.JudgeResult.Compare_False;
            }
        }

        private Header.JudgeResult speed(List<string> tks)
        {
            if (tks[tokenindex].Equals(Header.TokenType.Stk.ToString()))
            {
                return Header.JudgeResult.Compare_True;
            }
            else
            {
                return Header.JudgeResult.Compare_False;
            }
        }

        private Header.JudgeResult m(List<string> tks)
        {
            if (tks[tokenindex].Equals(Header.TokenType.Mtk.ToString()))
            {
                return Header.JudgeResult.Compare_True;
            }
            else
            {
                return Header.JudgeResult.Compare_False;
            }
        }
    }
    

}
