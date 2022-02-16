using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCIO.NC_HCI.Compiler
{
    class Header
    {
        public enum TokenType
        {
            PERtk,  //用來定義 %     的token
            Ntk,    //用來定義 N機能 的token
            Gtk,    //用來定義 G機能 的token
            GPtk,   //用來定義 GP機能 的token
            Mtk,    //用來定義 M機能 的token
            Ttk,    //用來定義 T機能 的token
            Ftk,    //用來定義 F機能 的token
            AXIStk, //用來定義 軸    的token
            Stk,    //用來定義 S機能 的token
            EOBtk,  //用來定義 換行  的token
            UNDEFtk //用來定義 無效  的token
        }

        public enum JudgeResult
        {
            Compare_True,    //語法結果相同
            Compare_False,   //語法結果不同   
            Compare_NO       //預留
        }
    }
}
