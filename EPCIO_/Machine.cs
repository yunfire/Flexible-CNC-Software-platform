using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EpcioSeries;

namespace EPCIO
{

    public class Machine 
    {

        public int xAxis = 0, yAxis = 1, zAxis = 2; //軸編號
        public ushort groupNumber;  //Form1裡面也有一個groupNumber 要注意
        public double xPos, yPos, zPos;
        public int xEncoder, yEncoder, zEncoder;
        public Graph_Paint graph_Paint = new Graph_Paint();
        public Machine(ushort groupNumber)
        {
            this.groupNumber = groupNumber;
            graph_Paint. putGraphicsOnBitmap();
        }
        public bool MachineCanBeUsed()
        {
            if (MCCL.MCC_GetMotionStatus(groupNumber) == MCCL.GMS_STOP) return true;
            else return false;
        }
        public int getGroupNumber()
        {
            return groupNumber;
        }

        public void getCurPos(double dfXPos, double dfYPos, double dfZPos, double dfUPos, double dfVPos, double dfWPos)
        {
            MCCL.MCC_GetCurPos(ref dfXPos, ref dfYPos, ref dfZPos, ref dfUPos, ref dfVPos, ref dfWPos, groupNumber);
            xPos = dfXPos;
            yPos = dfYPos;
            zPos = dfZPos;
        }
        int Encoder ;
        public void getENCValue(ushort Channel, ushort cardNumber, int Axis)//x=0;y=1;z=2
        {
            MCCL.MCC_GetENCValue(ref Encoder, Channel, cardNumber);
            if (Axis == 0) xEncoder = Encoder;
            else if (Axis == 1) yEncoder = Encoder;
            else if (Axis == 2) zEncoder = Encoder;
        }
        public void pathUpdate(Pen pen) //路徑更新   graphics
        {
            graph_Paint.pathUpdate(pen, xEncoder, yEncoder, zEncoder);
        }

        public void graphicsClear() //清空畫布  graphics
        {
            xEncoder = 0;
            yEncoder = 0;
            zEncoder = 0;
            graph_Paint.graphicsClear();
        }

    }
}
