using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EpcioSeries;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
namespace EPCIO
{
    
    public partial class MotionControl_UC : UserControl
    {
        int Group;  //for迴圈用的group
        static Machine machineA = new Machine(0);
        static Machine machineB = new Machine(1);
        static Machine machineC = new Machine(2);
        static Machine machineD = new Machine(3);
        Machine[] allMachine = new Machine[4] { machineA, machineB, machineC, machineD };
        Card motionCard;
        public int xAxis = 0, yAxis = 1, zAxis = 2; //軸編號
        public const int pictureWidth = 350;
        public const int pictureHeight = 350;
        bool SystemStatus = false;
        private ushort Channel;
        private ushort cardNumber;
        Thread r,t;
        public MotionControl_UC()
        {
            InitializeComponent();
        }

        private void MotionControl_UC_Load(object sender, EventArgs e)
        {

        }

        double dfXPos = 0;
        double dfYPos = 0;
        double dfZPos = 0;
        double dfUPos = 0;
        double dfVPos = 0;
        double dfWPos = 0;

        Pen pen = new Pen(Color.Red, 1);
        /// 繪圖速度調整用的比例

        int groupNumber;
        private void SystemButton_Click(object sender, EventArgs e)
        {
            if (SystemStatus == true) ///System Off
            {

                SystemStatus = false;
                MCCL.MCC_CloseSystem();
                TurnAllMachineOff();   //機台顯示關閉賺太
                SystemStatusButton.Visible = false; ///////綠燈關閉
            }

            else if ((SystemStatus == false))            // System On
            {
                motionCard = new Card();
                SystemStatus = true;
                SystemStatusButton.Visible = true; ////////綠燈開燈
                motionCard.ParameterSet(cb_MA.Checked, cb_MB.Checked, cb_MC.Checked, cb_MD.Checked);   //檢查哪個機台需要開機
                CheckeMachineStatus(cb_MA.Checked, cb_MB.Checked, cb_MC.Checked, cb_MD.Checked);    //運轉狀態更新
            }
        }
        bool MA_Used = false, MB_Used = false, MC_Used = false, MD_Used = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int motionType = MCCL.MCC_GetCoordType(0);
            if (motionType == 0)
                MotionType.Text = "增量座標模式";  ////增量座標
            else if (motionType == 1)
                MotionType.Text = "絕對座標模式"; /////絕對座標模式
            int status = MCCL.MCC_GetMotionStatus(0);
            if (status == MCCL.GMS_RUNNING) MA_Used = false;
            else MA_Used = true;
            int statusC = MCCL.MCC_GetMotionStatus(2);
            if (statusC == MCCL.GMS_RUNNING) MC_Used = false;
            else MC_Used = true;

            //group選擇
            if (groupComboBox.Text == "nGroup")
                groupNumber = 0;
            if (groupComboBox.Text == "nGroup1")
                groupNumber = 1;
            if (groupComboBox.Text == "nGroup2")
                groupNumber = 2;
            if (groupComboBox.Text == "nGroup3")
                groupNumber = 3;
            for (int i = 0; i < 4; i++)
            {
                allMachine[i].getCurPos(dfXPos, dfYPos, dfZPos, dfUPos, dfVPos, dfWPos);   //更新機台CurPos數值
            }
            //curPos更新
            xCurPosTextBox.Text = allMachine[groupNumber].xPos.ToString();
            yCurPosTextBox.Text = allMachine[groupNumber].yPos.ToString();
            zCurPosTextBox.Text = allMachine[groupNumber].zPos.ToString();


            MCCL.MCC_GetENCValue(ref machineA.xEncoder, 0, 0);
            MCCL.MCC_GetENCValue(ref machineA.yEncoder, 1, 0);
            MCCL.MCC_GetENCValue(ref machineA.zEncoder, 2, 0);
            MCCL.MCC_GetENCValue(ref machineB.xEncoder, 3, 0);
            MCCL.MCC_GetENCValue(ref machineB.yEncoder, 4, 0);
            MCCL.MCC_GetENCValue(ref machineB.zEncoder, 5, 0);
            MCCL.MCC_GetENCValue(ref machineC.xEncoder, 0, 1);
            MCCL.MCC_GetENCValue(ref machineC.yEncoder, 1, 1);
            MCCL.MCC_GetENCValue(ref machineC.zEncoder, 2, 1);
            MCCL.MCC_GetENCValue(ref machineD.xEncoder, 3, 1);
            MCCL.MCC_GetENCValue(ref machineD.yEncoder, 4, 1);
            MCCL.MCC_GetENCValue(ref machineD.zEncoder, 5, 1);

            xEncoderTextBox.Text = allMachine[groupNumber].xEncoder.ToString(); //編碼器數值顯示
            yEncoderTextBox.Text = allMachine[groupNumber].yEncoder.ToString();
            zEncoderTextBox.Text = allMachine[groupNumber].zEncoder.ToString();


            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;  //指定畫線模式

            for (Group = 0; Group < 4; Group++)///更新路徑
            {
                allMachine[Group].pathUpdate(pen); //可以再優化 BY偉忠
            }
            Ptb_M1.Image = allMachine[0].graph_Paint.xyBitmap;  //圖畫設定
            Ptb_M2.Image = allMachine[1].graph_Paint.xyBitmap;
            Ptb_M3.Image = allMachine[2].graph_Paint.xyBitmap;
            Ptb_M4.Image = allMachine[3].graph_Paint.xyBitmap;
            //////設定顯示軸//// 待優化 BY偉忠
            /* if (horizontalAxisComboBox.Text == "x" && VerticalAxisComboBox.Text == "y")//////設定XY顯示軸////
             {
                 Ptb_M1.Image = allMachine[0].graph_Paint.xyBitmap;

             }//X&Y軸

             if (horizontalAxisComboBox.Text == "x" && VerticalAxisComboBox.Text == "z")//////設定XZ顯示軸////
             {
                 Ptb_M1.Image = allMachine[groupNumber].graph_Paint.xzBitmap;   //groupNumber用來選擇顯示哪個group
             }//X&Z軸

             if (horizontalAxisComboBox.Text == "y" && VerticalAxisComboBox.Text == "z")//////設定YZ顯示軸////
             {
                 Ptb_M1.Image = allMachine[groupNumber].graph_Paint.yzBitmap;   //groupNumber用來選擇顯示哪個group
             }

             if (horizontalAxisComboBox.Text == "y" && VerticalAxisComboBox.Text == "x")//////設定YX顯示軸////
             {
                 Ptb_M1.Image = allMachine[groupNumber].graph_Paint.yxBitmap;   //groupNumber用來選擇顯示哪個group
             }

             if (horizontalAxisComboBox.Text == "z" && VerticalAxisComboBox.Text == "x")//////設定ZX顯示軸////
             {
                 Ptb_M1.Image = allMachine[groupNumber].graph_Paint.zxBitmap;   //groupNumber用來選擇顯示哪個group
             }

             if (horizontalAxisComboBox.Text == "z" && VerticalAxisComboBox.Text == "y")//////設定ZY顯示軸////
             {
                 Ptb_M1.Image = allMachine[groupNumber].graph_Paint.zyBitmap;   //groupNumber用來選擇顯示哪個group
             }*/
            if (SystemStatus == false)
            {
                for (Group = 0; Group < 4; Group++)
                {
                    allMachine[Group].graphicsClear();
                }
            }
        }



        SaveFileDialog dialog = new SaveFileDialog(); //儲存檔案用類別




        double referenceX;  // Gcode I
        double referenceY;  // Gcode J
        double circleX;
        double circleY;
        double angle;

        //計算角度用於MCCL曲線函數
        private double convertTo_Gcode(double startX, double startY,
                                       double referenceX, double referenceY,
                                       double targetX, double targetY)
        {
            circleX = startX + referenceX;
            circleY = startY + referenceY;

            angle = Math.Asin((Math.Sqrt(((Math.Pow((startX - targetX), 2) + Math.Pow((startY - targetY), 2)))) / 2) /
               Math.Sqrt(Math.Pow((targetX - circleX), 2) + Math.Pow((targetY - circleY), 2))) * 180 / Math.PI * 2;
            return -angle;
        }//G02 G03轉換為MCCL型式
        double Xvalue;  ////MCCL用運動值
        double Yvalue;
        double Zvalue;
        double pre_xValue;
        double pre_yValue;


        string[,] commandList = new string[100000, 5];   //儲存運動佇列內容
        int gMode = 4;
        int order = 0;

        private void GcodeMoveBtn_Click(object sender, EventArgs e)
        {
            GcodeMove(richTextBox1.Text);
        } //當下機台Gcode直譯
        private void GcodeMove(string Gcode)  //2020/1/11
        {
            order = 0;

            string Commands = Gcode.Replace("\n", " ");
            string[] orders = Gcode.Split('\n');  //另外切割一個GcodeList 用來存取Orders
            while (true)
            {
                string[] commands = orders[order + 1].Split(' ');///用空格分割字串並存到陣列
                foreach (var command in commands)
                {
                    string substring = command.Substring(1);///擷取子字串。 子字串起始於指定的字元位置(2)，並延續到字串結尾。

                    if (command == "G00") ///判斷運動模式
                    {
                        gMode = 0;
                    }
                    if (command == "G01") ///判斷運動模式
                    {
                        gMode = 1;
                    }
                    if (command == "G02") ///判斷運動模式
                    {
                        gMode = 2;
                    }
                    if (command == "G03") ///判斷運動模式
                    {
                        gMode = 3;
                    }
                    if (command.StartsWith("X"))
                    {
                        pre_xValue = Xvalue;
                        Xvalue = Convert.ToDouble(substring);///X軸移動數值
                    }
                    if (command.StartsWith("Y"))
                    {
                        pre_yValue = Yvalue;
                        Yvalue = Convert.ToDouble(substring);///Y軸移動數值
                    }
                    if (command.StartsWith("Z"))
                    {
                        Zvalue = Convert.ToDouble(substring);///Z軸移動數值
                    }
                    if (command.StartsWith("I"))
                    {
                        referenceX = Convert.ToDouble(substring);
                    }
                    if (command.StartsWith("J"))
                    {
                        referenceY = Convert.ToDouble(substring);
                    }

                    if (command.StartsWith("N"))///讀取的是上一列的值
                    {
                        int preOrder = 0;

                        if (order > 1) preOrder = order - 1;
                        circleX = pre_xValue + referenceX;
                        circleY = pre_yValue + referenceY;
                        angle = convertTo_Gcode(pre_xValue, pre_yValue, referenceX, referenceY, Xvalue, Yvalue);  //因應GcodeG2 G3 計算角度轉換

                        if (gMode == 0)
                        {
                            if (cb_MoveMA.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[0].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            if (cb_MoveMB.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[1].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            if (cb_MoveMC.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[2].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            if (cb_MoveMD.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[3].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            order++;
                        }
                        if (gMode == 1)///受控運動
                        {
                            if (cb_MoveMA.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[0].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            if (cb_MoveMB.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[1].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            if (cb_MoveMC.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[2].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            if (cb_MoveMD.Checked) MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, allMachine[3].groupNumber, MCCL.EPCIO_AXIS_ALL);
                            order++;
                        }
                        if (gMode == 2)///CW
                        {
                            if (cb_MoveMA.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, angle, allMachine[0].groupNumber);
                            if (cb_MoveMB.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, angle, allMachine[1].groupNumber);
                            if (cb_MoveMC.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, angle, allMachine[2].groupNumber);
                            if (cb_MoveMD.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, angle, allMachine[3].groupNumber);
                            order++;
                        }
                        if (gMode == 3)///CCW
                        {
                            if (cb_MoveMA.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, -angle, allMachine[0].groupNumber);
                            if (cb_MoveMB.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, -angle, allMachine[1].groupNumber);
                            if (cb_MoveMC.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, -angle, allMachine[2].groupNumber);
                            if (cb_MoveMD.Checked) MCCL.MCC_ArcThetaXY(circleX, circleY, -angle, allMachine[3].groupNumber);
                            order++;
                        }
                    }
                }
                if (commands[0] == "%") break;
            }
        }

        private void GcodeMove(string Gcode,ushort group)  
        {
            order = 0;

            string Commands = Gcode.Replace("\n", " ");
            string[] orders = Gcode.Split('\n');  //另外切割一個GcodeList 紀錄加工檔案內容 
            while (true)
            {
                string[] commands = orders[order + 1].Split(' ');///用空格分割字串並存到陣列
                foreach (var command in commands)
                {
                    string substring = command.Substring(1);///擷取子字串。 子字串起始於指定的字元位置(2)，並延續到字串結尾。

                    if (command == "G00") ///判斷運動模式
                    {
                        gMode = 0;
                    }
                    if (command == "G01") ///判斷運動模式
                    {
                        gMode = 1;
                    }
                    if (command == "G02") ///判斷運動模式
                    {
                        gMode = 2;
                    }
                    if (command == "G03") ///判斷運動模式
                    {
                        gMode = 3;
                    }
                    if (command.StartsWith("X"))
                    {
                        pre_xValue = Xvalue;
                        Xvalue = Convert.ToDouble(substring);///X軸移動數值
                    }
                    if (command.StartsWith("Y"))
                    {
                        pre_yValue = Yvalue;
                        Yvalue = Convert.ToDouble(substring);///Y軸移動數值
                    }
                    if (command.StartsWith("Z"))
                    {
                        Zvalue = Convert.ToDouble(substring);///Z軸移動數值
                    }
                    if (command.StartsWith("I"))
                    {
                        referenceX = Convert.ToDouble(substring);
                    }
                    if (command.StartsWith("J"))
                    {
                        referenceY = Convert.ToDouble(substring);
                    }

                    if (command.StartsWith("N"))///讀取的是上一列的值
                    {
                        int preOrder = 0;

                        if (order > 1) preOrder = order - 1;
                        circleX = pre_xValue + referenceX;
                        circleY = pre_yValue + referenceY;
                        angle = convertTo_Gcode(pre_xValue, pre_yValue, referenceX, referenceY, Xvalue, Yvalue);  //因應GcodeG2 G3 計算角度轉換

                        if (gMode == 0)
                        {
                             MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, group, MCCL.EPCIO_AXIS_ALL);
                            order++;
                        }
                        if (gMode == 1)///受控運動
                        {
                             MCCL.MCC_Line(Xvalue, Yvalue, Zvalue, 0, 0, 0, group, MCCL.EPCIO_AXIS_ALL);
                            order++;
                        }
                        if (gMode == 2)///CW
                        {
                             MCCL.MCC_ArcThetaXY(circleX, circleY, angle, group);
                            order++;
                        }
                        if (gMode == 3)///CCW
                        {
                            MCCL.MCC_ArcThetaXY(circleX, circleY, -angle,group);
                            order++;
                        }
                    }
                }
                if (commands[0] == "%") break;
            }
        }
        private void Btn_Move_Click(object sender, EventArgs e)
        {
            double xMoveVal = 0;
            double yMoveVal = 0;
            double zMoveVal = 0;

            if (String.IsNullOrEmpty(xMoveValTextBox.Text) || String.IsNullOrEmpty(yMoveValTextBox.Text) || String.IsNullOrEmpty(zMoveValTextBox.Text))
            {
                MessageBox.Show("不能輸入空白值");
            }
            else
            {
                xMoveVal = Convert.ToDouble(xMoveValTextBox.Text);
                yMoveVal = Convert.ToDouble(yMoveValTextBox.Text);
                zMoveVal = Convert.ToDouble(zMoveValTextBox.Text);
                MCCL.MCC_Line(xMoveVal, yMoveVal, zMoveVal, 0, 0, 0, allMachine[groupNumber].groupNumber, MCCL.EPCIO_AXIS_ALL);
            }
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            dialog.CreatePrompt = false;
            dialog.OverwritePrompt = true;
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.Title = "Save File";

            string[] commandList = new string[10000];   //儲存richBox內容用
            foreach (char Content in richTextBox1.Text)
            {
                if (Content != '\n')  //一般文字
                {
                    commandList[order] += Content;
                    order++;
                }
                else  //遇到換行
                {
                    commandList[order] += "\r\n";  ///換行
                    order++;
                }
            }

            if (dialog.ShowDialog() == DialogResult.OK)    //成功儲存
            {
                string savepos = dialog.FileName;  ////FileName=儲存路徑
                FileStream myStream = new FileStream(savepos, FileMode.Create, FileAccess.Write);  //設定儲存模式&寫入
                StreamWriter SW = new StreamWriter(myStream);  //資料書寫用

                for (order = 0; order < 10000; order++)
                    SW.Write(commandList[order]); //畫出richBox的內容

                order = 0;///指令數歸0
                SW.Flush();
                SW.Close();
                myStream.Close();  //關閉資料流
            }
        }//匯出txt

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            //讀取TXT
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
                richTextBox1.Text += fileContent;
                string[] orders = richTextBox1.Text.Split('\n');
            }
        }//匯入txt

        private void Btn_Produce_Click(object sender, EventArgs e)
        {
            string ProductLine= Lb_grouping.Text.Substring(0, 1);
            //CustomizedProduce(Convert.ToInt32(Lb_grouping.Text));
            CustomizedProduce(Lb_grouping.Text);
            CustomizedProduce(Convert.ToInt32(ProductLine));

        }
      
        private void CustomizedProduce(string producceOrder)   //測試客製化 1/31
        {
            string b = producceOrder.Replace("=>", " ");
            string[] order = b.Split(' ');
            MessageBox.Show(order[0] + order[1]+order[2]); 
        }
        private void CustomizedProduce ( int productLine)  //客製化製造
        {
                GcodeMove(GetContent(Lb_machingA.Text), 0); //Gcode檔案解讀
                r = new Thread(() => ProductMove(machineA,machineB, productLine)); //物料轉移
                r.Start();
        }

     
        
        void ProductMove(Machine startMachine,Machine targetMachine,int productLine)  //物料轉機
        {
            while (true)
            {
                if (startMachine.MachineCanBeUsed())  //加工完成
                {
                    if (targetMachine.MachineCanBeUsed()) //目標機台空閒
                    {
                        
                        Point point = new Point(0, 0);
                        targetMachine.graph_Paint.graphicsXY.DrawImage(startMachine.graph_Paint.xyBitmap, point); //轉移物料
                        startMachine.graphicsClear();
                        if (targetMachine == machineB) //機台A=>機台B轉移
                        {
                            try
                            {
                                GcodeMove(GetContent(Lb_machingB.Text), 1); //精加工
                            }
                            catch
                            {
                            }
                            if (productLine == 1) ProductMove(machineB, machineC, productLine);//分辨目的地機台
                            if (productLine==2) ProductMove(machineB, machineD, productLine);
                        }
                        if (targetMachine == machineC) Rectangle(2); //製作筆記本基底
                        if (targetMachine == machineD) Circle(3);   //製作杯墊基底
                        break;
                    }
                }
            }
        }

     

        void Rectangle(ushort groupNumber)
        {
            MCCL.MCC_Line(Ptb_M1.Width, 0, 0, 0, 0, 0, groupNumber, MCCL.EPCIO_AXIS_ALL);
            MCCL.MCC_Line(Ptb_M1.Width, Ptb_M1.Height, 0, 0, 0, 0, groupNumber, MCCL.EPCIO_AXIS_ALL);
            MCCL.MCC_Line(0, Ptb_M1.Height, 0, 0, 0, 0, groupNumber, MCCL.EPCIO_AXIS_ALL);
            MCCL.MCC_Line(0, 0, 0, 0, 0, 0, groupNumber, MCCL.EPCIO_AXIS_ALL);
        }
        void Circle(ushort group)
        {
            Point point = new Point(Ptb_M4.Width / 2, 0);
            Point point2 = new Point(Ptb_M4.Width / 2, Ptb_M4.Height / 2);
            MCCL.MCC_Line(point.X, point.Y, 0, 0, 0, 0, group, MCCL.EPCIO_AXIS_ALL);
            MCCL.MCC_CircleXY(point2.X, point2.Y + 15, 1, group);
        }
        private void BaseProduce(ushort productLine)
        {
            productLine = Convert.ToUInt16(Lb_grouping.Text);
            if(productLine==1) Rectangle(2);


        }
        private string GetContent(string productName)
        {
            string folderName = System.Windows.Forms.Application.StartupPath + @"\ProductGcode\";
            string fileName = productName+".txt";
            string file = folderName + fileName;
            string fileContent;
            StreamReader reader = new StreamReader(file);
            fileContent = reader.ReadToEnd();
            
            return fileContent;
        }
        private void CheckeMachineStatus(bool MA_Checked, bool MB_Checked ,bool MC_Checked,bool MD_Checked)
        {
            if (cb_MA.Checked) Lb_statusA.Text = "運轉中";
            if (cb_MB.Checked) Lb_statusB.Text = "運轉中";
            if (cb_MC.Checked) Lb_statusC.Text = "運轉中";
            if (cb_MD.Checked) Lb_statusD.Text = "運轉中";
        }  //更新機台開機狀況
        private void TurnAllMachineOff()
        {
            Lb_statusA.Text = "關機";
            Lb_statusB.Text = "關機";
            Lb_statusC.Text = "關機";
            Lb_statusD.Text = "關機";
        }  //更新機台關機狀況

    }
    public class Product
    {
        static public Machine startMachine;
        static public Machine targetMachine;
        static public void ProductMove()
        {
            while (true)
            {
                if (startMachine.MachineCanBeUsed())  //加工完成
                {
                    if (targetMachine.MachineCanBeUsed())
                    {
                        Point point = new Point(0, 0);
                        targetMachine.graph_Paint.graphicsXY.DrawImage(startMachine.graph_Paint.xyBitmap, point); //轉移物料

                        break;
                    }
                }
            }
        }
        
    }
}
