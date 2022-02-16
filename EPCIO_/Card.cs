using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpcioSeries;
using System.Xml;

namespace EPCIO
{
    //運動控制卡相關設定
    class Card : EpcioSeries.MCCL
    {
        Parameter_UC parameter = new Parameter_UC();
        //MotionControl_UC motion = new MotionControl_UC();

        public void ParameterSet(bool MachineA,bool MachineB,bool MachineC,bool MachineD)  //設定系統參數--雙卡
        {
            int nGroup;
            int nGroup1;
            int nGroup2;
            int nGroup3;
            ushort nChannel = 0;
                //讀取Xml參數
                // set mechanism parameters
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Param\" + parameter.paraName.Text + "_MachineA.xml");  //載入機台A參數
                //選取節點
                XmlNode macParamNode = doc.DocumentElement.SelectSingleNode("/Param/MacParam");
                doc.Load(@"..\..\Param\" + parameter.paraName.Text + "_MachineB.xml");  //載入機台B參數
                XmlNode macParamNode1 = doc.DocumentElement.SelectSingleNode("/Param/MacParam");

                MCCL.MCC_SetSysMaxSpeed(10000); // set max. feed rate

                SYS_CARD_CONFIG stCardConfig = new SYS_CARD_CONFIG();
                SYS_CARD_CONFIG stCardConfig1 = new SYS_CARD_CONFIG();
                SYS_MAC_PARAM stAxisParam = new SYS_MAC_PARAM();   //MachineA
                SYS_MAC_PARAM stAxisParam1 = new SYS_MAC_PARAM();  //MachineB
                SYS_ENCODER_CONFIG stENCConfig = new SYS_ENCODER_CONFIG();
            for (nChannel = 0; nChannel < 6; nChannel++)
                {
                stAxisParam.wPosToEncoderDir = 0;
                stAxisParam.dwPPR = Convert.ToUInt32(macParamNode["dwPPR"].InnerText);//5000
                stAxisParam.wRPM = Convert.ToUInt16(macParamNode["wRPM"].InnerText);//3000
                stAxisParam.dfPitch = Convert.ToDouble(macParamNode["dfPitch"].InnerText);//1
                stAxisParam.dfGearRatio = Convert.ToDouble(macParamNode["dfGearRatio"].InnerText);//1
                stAxisParam.dfHighLimit = Convert.ToDouble(macParamNode["dfHighLimit"].InnerText);//50000
                stAxisParam.dfLowLimit = Convert.ToDouble(macParamNode["dfLowLimit"].InnerText);//-50000
                stAxisParam.wPulseMode = MCCL.DDA_FMT_CW; //0X1
                stAxisParam.wPulseWidth = Convert.ToUInt16(macParamNode["wPulseWidth"].InnerText);//100
                stAxisParam.wCommandMode = Convert.ToUInt16(macParamNode["wCommandMode"].InnerText);   //0(寫起來有點奇怪)
                stAxisParam.wOverTravelUpSensorMode = MCCL.SL_UNUSED; // not checking  //2
                stAxisParam.wOverTravelDownSensorMode = MCCL.SL_UNUSED;  //2
                //選取節點
                stAxisParam1.wPosToEncoderDir = 0;
                stAxisParam1.dwPPR = Convert.ToUInt32(macParamNode1["dwPPR"].InnerText);
                stAxisParam1.wRPM = Convert.ToUInt16(macParamNode1["wRPM"].InnerText);
                stAxisParam1.dfPitch = Convert.ToDouble(macParamNode1["dfPitch"].InnerText);
                stAxisParam1.dfGearRatio = Convert.ToDouble(macParamNode1["dfGearRatio"].InnerText);
                stAxisParam1.dfHighLimit = Convert.ToDouble(macParamNode1["dfHighLimit"].InnerText);
                stAxisParam1.dfLowLimit = Convert.ToDouble(macParamNode1["dfLowLimit"].InnerText);
                stAxisParam1.wPulseMode = MCCL.DDA_FMT_CW; //0X1
                stAxisParam1.wPulseWidth = Convert.ToUInt16(macParamNode1["wPulseWidth"].InnerText);
                stAxisParam1.wCommandMode = Convert.ToUInt16(macParamNode1["wCommandMode"].InnerText);   //0(寫起來有點奇怪)
                stAxisParam1.wOverTravelUpSensorMode = MCCL.SL_UNUSED; // not checking  //2
                stAxisParam1.wOverTravelDownSensorMode = MCCL.SL_UNUSED;  //2
                                                                          // set encoder configures
                    stENCConfig.wType = MCCL.ENC_TYPE_AB;
                    stENCConfig.wAInverse = MCCL.INVERSE_NO;
                    stENCConfig.wBInverse = MCCL.INVERSE_NO;
                    stENCConfig.wCInverse = MCCL.INVERSE_NO;
                    stENCConfig.wABSwap = MCCL.INVERSE_NO;
                    stENCConfig.wInputRate = 4; // set encoder input rate : x4

                    stCardConfig.wCardAddress = 0x240; // base address, PCI card ignores this setting
                    stCardConfig.wIRQ_No = 5; // IRQ No., PCI card ignores this setting
                    stCardConfig.wCardType = 3; // 0 : 4-axis ISA card
                    stCardConfig1.wCardAddress = 0x240; // base address, PCI card ignores this setting
                    stCardConfig1.wIRQ_No = 5; // IRQ No., PCI card ignores this setting
                    stCardConfig1.wCardType = 3; // 0 : 4-axis ISA card
                //重要!! nGroup , nGroup1不能刪 不然無法模擬
                nGroup= MCCL.MCC_SetMacParam(ref stAxisParam, nChannel, MCCL.CARDINDEX0); // mechanism parameters are the same for all axes  
                nGroup1 = MCCL.MCC_SetMacParam(ref stAxisParam1, nChannel, MCCL.CARDINDEX1); 

                nGroup = MCCL.MCC_SetEncoderConfig(ref stENCConfig, nChannel, MCCL.CARDINDEX0); // encoder configures are the same for all axes
                nGroup1 = MCCL.MCC_SetEncoderConfig(ref stENCConfig, nChannel, MCCL.CARDINDEX1); // encoder configures are the same for all axes

                    // you can use MCC_CreateGroup() to define group contents or use default contents
                    MCCL.MCC_CloseAllGroups();
                // nGroup = MCCL.MCC_CreateGroup(0, 1, 2, 3, 4, 5, MCCL.CARDINDEX0, MCCL.COMMAND_QUEUE_SIZE);
                //nGroup1 = MCCL.MCC_CreateGroup(0, 1, 2, 3, 4, 5, MCCL.CARDINDEX1, MCCL.COMMAND_QUEUE_SIZE);
                nGroup = MCCL.MCC_CreateGroup(0, 1, 2, -1, -1, -1, MCCL.CARDINDEX0, MCCL.COMMAND_QUEUE_SIZE);
                nGroup1 = MCCL.MCC_CreateGroup(3, 4, 5, -1, -1, -1, MCCL.CARDINDEX0, MCCL.COMMAND_QUEUE_SIZE);
                nGroup2 = MCCL.MCC_CreateGroup(0, 1, 2, -1, -1, -1, MCCL.CARDINDEX1, MCCL.COMMAND_QUEUE_SIZE);
                nGroup3 = MCCL.MCC_CreateGroup(3, 4, 5, -1, -1, -1, MCCL.CARDINDEX1, MCCL.COMMAND_QUEUE_SIZE);
            }

            // stCardConfig is used to set card's base address and card style, and set one card's attributes now

            // 1 : 6-axis ISA card
            // 2 : 4-axis PCI card
            // 3 : 6-axis PCI card
                double speed_A = Convert.ToDouble( macParamNode["FeedSpeed"].InnerText);   //設定速度
                double speed_B = Convert.ToDouble(macParamNode1["FeedSpeed"].InnerText);

                int net = MCCL.MCC_InitSimulation(5, ref stCardConfig1, 2);
                Console.WriteLine(net);  //啟動結果
                MCCL.MCC_SetFeedSpeed(speed_A, 0); ///////////進給速度
                MCCL.MCC_SetFeedSpeed(speed_B, 1);
                MCCL.MCC_SetFeedSpeed(speed_B, 2);
                MCCL.MCC_SetFeedSpeed(speed_B, 3);

            if (MachineA == true)
            {
                    for (ushort Channel = 0; Channel < 3; Channel++)
                    {
                        MCCL.MCC_SetServoOn(Channel, 0);
                    }
            }
            if (MachineB == true)
            {
                    for (ushort Channel = 3; Channel < 6; Channel++)
                    {
                        MCCL.MCC_SetServoOn(Channel, 0);
                    }
            }
            if (MachineC == true)
            {
                for (ushort Channel = 0; Channel < 3; Channel++)
                {
                    MCCL.MCC_SetServoOn(Channel, 1);
                }
            }
            if (MachineD == true)
            {
                for (ushort Channel = 3; Channel < 6; Channel++)
                {
                    MCCL.MCC_SetServoOn(Channel, 1);
                }
            }
        }
    }
}
