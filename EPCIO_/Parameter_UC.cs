using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Resources;

namespace EPCIO
{
    public partial class Parameter_UC : UserControl
    {
        public Parameter_UC(int group)
        {
            InitializeComponent();
        }
        public Parameter_UC()
        {  
            InitializeComponent();
        }

        private void loadPara_Btn_Click(object sender, EventArgs e)  //載入xml參數
        {
            if (cb_Machine_Choose.SelectedIndex == 0)
            {
                ParaLoad(true, false); //ParaLoad(MachineA,MachineB)
            }
            if (cb_Machine_Choose.SelectedIndex == 1)
            {
                ParaLoad(false, true);
            }
        }

        private void saveParaBtn_Click(object sender, EventArgs e) //儲存xml參數
        {
            if (cb_Machine_Choose.SelectedIndex == 0) ParaSave(true, false);
            if (cb_Machine_Choose.SelectedIndex == 1) ParaSave(false, true);
        }
        private void ParaSave(bool MachineA,bool MachineB) //儲存xml參數
        {
           # region  參數儲存
            if (MachineA == true)
            {
                XmlDocument doc = new XmlDocument();
                //建立根節點
                XmlElement param = doc.CreateElement("Param");
                doc.AppendChild(param);
                //建立MacParam節點
                XmlElement macParam = doc.CreateElement("MacParam");
                param.AppendChild(macParam);
                XmlElement info = doc.CreateElement("wPosToEncoderDir");
                info = doc.CreateElement("wPosToEncoderDir");
                info.InnerText = tb_EncoderDir.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dwPPR");
                info.InnerText = tb_PPR.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("wRPM");
                info.InnerText = tb_RPM.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dfPitch");
                info.InnerText = tb_Pitch.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dfGearRatio");
                info.InnerText = tb_GearRatio.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dfHighLimit");
                info.InnerText = tb_HighLimit.Text; ///50000
                macParam.AppendChild(info);
                info = doc.CreateElement("dfLowLimit");
                info.InnerText = tb_LowLimit.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("wPulseMode");  //Pulse模式
                info.InnerText = cb_PulseMode.SelectedItem.ToString();//0x1 CW模式
                macParam.AppendChild(info);
                info = doc.CreateElement("wPulseWidth");
                info.InnerText = tb_PulseWidth.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("wCommandMode"); //
                info.InnerText = tb_CommandMode.Text;//脈衝模式=0
                macParam.AppendChild(info);
                info = doc.CreateElement("FeedSpeed"); //
                info.InnerText = tb_FeedSpeed.Text;
                macParam.AppendChild(info);
                doc.Save(@"..\..\Param\" + paraName.Text + "_MachineA.xml");
                MessageBox.Show("已成功修改並儲存MachineA參數");
            }
            if (MachineB == true)
            {
                XmlDocument doc = new XmlDocument();
                //建立根節點
                XmlElement param = doc.CreateElement("Param");
                doc.AppendChild(param);
                //建立MacParam節點
                XmlElement macParam = doc.CreateElement("MacParam");
                param.AppendChild(macParam);
                XmlElement info = doc.CreateElement("wPosToEncoderDir");
                info = doc.CreateElement("wPosToEncoderDir");
                info.InnerText = tb_EncoderDir.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dwPPR");
                info.InnerText = tb_PPR.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("wRPM");
                info.InnerText = tb_RPM.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dfPitch");
                info.InnerText = tb_Pitch.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dfGearRatio");
                info.InnerText = tb_GearRatio.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("dfHighLimit");
                info.InnerText = tb_HighLimit.Text; ///50000
                macParam.AppendChild(info);
                info = doc.CreateElement("dfLowLimit");
                info.InnerText = tb_LowLimit.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("wPulseMode");  //Pulse模式
                info.InnerText = cb_PulseMode.SelectedItem.ToString();//0x1 CW模式
                macParam.AppendChild(info);
                info = doc.CreateElement("wPulseWidth");
                info.InnerText = tb_PulseWidth.Text;
                macParam.AppendChild(info);
                info = doc.CreateElement("wCommandMode"); //
                info.InnerText = tb_CommandMode.Text;//脈衝模式=0
                macParam.AppendChild(info);
                info = doc.CreateElement("FeedSpeed"); //
                info.InnerText = tb_FeedSpeed.Text;
                macParam.AppendChild(info);
                doc.Save(@"..\..\Param\" + paraName.Text + "_MachineB.xml");
                MessageBox.Show("已成功修改並儲存MachineB參數");
            }
            #endregion
        }

        private void ParaLoad(bool MachineA, bool MachineB)  //載入xml參數
        {
            #region 引用參數
            if (MachineA == true)//選擇機台A
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Param\" + paraName.Text + "_MachineA.xml");
                XmlNode macParamNode = doc.DocumentElement.SelectSingleNode("/Param/MacParam");
                tb_PPR.Text = macParamNode["dwPPR"].InnerText;
                tb_EncoderDir.Text = macParamNode["wPosToEncoderDir"].InnerText;
                tb_RPM.Text = macParamNode["wRPM"].InnerText;
                tb_Pitch.Text = macParamNode["dfPitch"].InnerText;
                tb_GearRatio.Text = macParamNode["dfGearRatio"].InnerText;
                tb_HighLimit.Text = macParamNode["dfHighLimit"].InnerText;
                tb_LowLimit.Text = macParamNode["dfLowLimit"].InnerText;
                if ("DDA_FMT_CW" == macParamNode["wPulseMode"].InnerText)
                    cb_PulseMode.SelectedIndex = 0;
                tb_PulseWidth.Text = macParamNode["wPulseWidth"].InnerText;
                tb_CommandMode.Text = macParamNode["wCommandMode"].InnerText;
                tb_FeedSpeed.Text = macParamNode["FeedSpeed"].InnerText;
            }
            if (MachineB == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Param\" + paraName.Text + "_MachineB.xml");
                XmlNode macParamNode = doc.DocumentElement.SelectSingleNode("/Param/MacParam");
                tb_PPR.Text = macParamNode["dwPPR"].InnerText;
                tb_EncoderDir.Text = macParamNode["wPosToEncoderDir"].InnerText;
                tb_RPM.Text = macParamNode["wRPM"].InnerText;
                tb_Pitch.Text = macParamNode["dfPitch"].InnerText;
                tb_GearRatio.Text = macParamNode["dfGearRatio"].InnerText;
                tb_HighLimit.Text = macParamNode["dfHighLimit"].InnerText;
                tb_LowLimit.Text = macParamNode["dfLowLimit"].InnerText;
                if ("DDA_FMT_CW" == macParamNode["wPulseMode"].InnerText)
                    cb_PulseMode.SelectedIndex = 0;
                tb_PulseWidth.Text = macParamNode["wPulseWidth"].InnerText;
                tb_CommandMode.Text = macParamNode["wCommandMode"].InnerText;
                tb_FeedSpeed.Text = macParamNode["FeedSpeed"].InnerText;
         }
            #endregion
        }

        private void cb_Machine_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Machine_Choose.SelectedIndex == 0)
            {
                ParaLoad(true, false); //ParaLoad(MachineA,MachineB) 載入機台參數
                Pic_Machine.Image = Properties.Resources.CNC1;
                Lb_MachineName.Text = "HC-30數控車床";
            }
            if (cb_Machine_Choose.SelectedIndex == 1)
            {
                ParaLoad(false, true);
                Pic_Machine.Image = Properties.Resources.CNC2;
                Lb_MachineName.Text = "EGM 450數控車床";
            }
        }
    }
}
