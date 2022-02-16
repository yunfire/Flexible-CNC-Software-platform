using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EpcioSeries;

namespace EPCIO
{
    public class Graph_Paint
    {

        private int paintDivisionRatio = 8000;
        private Point newPointXY, newPointXZ, newPointYZ, newPointYX, newPointZX, newPointZY;
        private Point curPointXY, curPointXZ, curPointYZ, curPointYX, curPointZX, curPointZY;
        public Bitmap xyBitmap = new Bitmap(350, 350);
        public Bitmap xzBitmap = new Bitmap(350, 350);
        public Bitmap yzBitmap = new Bitmap(350, 350);
        public Bitmap yxBitmap = new Bitmap(350, 350);
        public Bitmap zxBitmap = new Bitmap(350, 350);
        public Bitmap zyBitmap = new Bitmap(350, 350);
        public Graphics graphicsXY, graphicsXZ, graphicsYZ, graphicsYX, graphicsZX, graphicsZY;
   

        public void putGraphicsOnBitmap()
        {
            Bitmap[] all_Bitmap = new Bitmap[] { xyBitmap, xzBitmap, yzBitmap, yxBitmap, zxBitmap, zyBitmap };
            Graphics[] all_Graphics = new Graphics[] { graphicsXY, graphicsXZ, graphicsYZ, graphicsYX, graphicsZX, graphicsZY };

            graphicsXY = Graphics.FromImage(xyBitmap);///將xyGraphics掛在xzBitmap上面
            graphicsYX = Graphics.FromImage(yxBitmap);///將yxGraphics掛在xzBitmap上面
            graphicsXZ = Graphics.FromImage(xzBitmap);///將xzGraphics掛在xzBitmap上面
            graphicsZX = Graphics.FromImage(zxBitmap);///將zxGraphics掛在xzBitmap上面
            graphicsYZ = Graphics.FromImage(yzBitmap);///將yzGraphics掛在xzBitmap上面
            graphicsZY = Graphics.FromImage(zyBitmap);///將zyGraphics掛在xzBitmap上面
        }
        public void pathUpdate(Pen pen,int xEncoder,int yEncoder,int zEncoder) //路徑更新   graphics
        {

            newPointXY.X = xEncoder / paintDivisionRatio;  //轉換編碼器數值 to 路徑點座標
            newPointXY.Y = yEncoder / paintDivisionRatio;
            newPointYX.X = yEncoder / paintDivisionRatio;
            newPointYX.Y = xEncoder / paintDivisionRatio;

            newPointXZ.X = xEncoder / paintDivisionRatio;
            newPointXZ.Y = zEncoder / paintDivisionRatio;
            newPointZX.X = zEncoder / paintDivisionRatio;
            newPointZX.Y = xEncoder / paintDivisionRatio;

            newPointYZ.X = yEncoder / paintDivisionRatio;
            newPointYZ.Y = zEncoder / paintDivisionRatio;
            newPointZY.X = zEncoder / paintDivisionRatio;
            newPointZY.Y = yEncoder / paintDivisionRatio;


            if(zEncoder>=0) graphicsXY.DrawLine(pen, curPointXY, newPointXY);  //兩點一線更新路徑
            curPointXY = newPointXY;        //////////運動完畢時更新現在位置
            graphicsYX.DrawLine(pen, curPointYX, newPointYX);
            curPointYX = newPointYX;
            graphicsXZ.DrawLine(pen, curPointXZ, newPointXZ);
            curPointXZ = newPointXZ;
            graphicsZX.DrawLine(pen, curPointZX, newPointZX);
            curPointZX = newPointZX;
            graphicsYZ.DrawLine(pen, curPointYZ, newPointYZ);
            curPointYZ = newPointYZ;
            graphicsZY.DrawLine(pen, curPointZY, newPointZY);
            curPointZY = newPointZY;
        }

        public void graphicsClear()
        {
            graphicsXY.Clear(Color.White);
            newPointXY.X = 0;
            newPointXY.Y = 0;
            curPointXY.X = 0;
            curPointXY.Y = 0;
        }
     /*   public void graphicsClear() //清空畫布  graphics
        {
            int graphicsNumber = 6;
            
            Point[] all_NewPoint = new Point[6] { newPointXY, newPointXZ, newPointYZ, newPointYX, newPointZX, newPointZY };
            Point[] all_CurPoint = new Point[6] { curPointXY, curPointXZ, curPointYZ, curPointYX, curPointZX, curPointZY };
            Graphics[] all_Graphics = new Graphics[] { graphicsXY, graphicsXZ, graphicsYZ, graphicsYX, graphicsZX, graphicsZY };
            Bitmap[] all_Bitmap = new Bitmap[] { xyBitmap, xzBitmap, yzBitmap, yxBitmap, zxBitmap, zyBitmap };

           // for (int i = 0; i < graphicsNumber; i++) all_Graphics[i] = Graphics.FromImage(all_Bitmap[i]);//清空畫布
            for (int i = 0; i < graphicsNumber; i++) all_Graphics[i].Clear(Color.White);//填滿白色
            for (int i = 0; i < all_NewPoint.Length; i++)//初始化坐標點
            {
                all_NewPoint[i].X = 0;
                all_NewPoint[i].Y = 0;
                all_CurPoint[i].X = 0;
                all_CurPoint[i].Y = 0;
            }
        }*/


    }
}
