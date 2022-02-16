using EpcioSeries;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EPCIO
{
    public partial class Form1 : Form
    {
        
        MotionControl_UC motion = new MotionControl_UC();
        Parameter_UC parameter = new Parameter_UC();
        Tool_UC tool = new Tool_UC();
        File_management file = new File_management();
        // public int nGroup3;
        public Form1()
        {
            InitializeComponent();
            pnlShow.Controls.Add(motion);
            pnlShow.Controls.Add(parameter);
            pnlShow.Controls.Add(tool);
            pnlShow.Controls.Add(file);
            motion.Show();
            parameter.Show();
            tool.Show();
            file.Show();
            motion.Visible = false;
            parameter.Visible = false;
            tool.Visible = false;
            file.Visible = true;
            file.Btn_Choose.Click += new System.EventHandler(Btn_Choose_Click);//按下button1觸發button1_Click
        }

        private void Btn_Choose_Click(object sender, EventArgs e)  //確認產線資訊
        {
            motion.Lb_machingA.Text = file.Lb_Roughing.Text; //粗加工
            motion.Lb_machingB.Text = file.Lb_Smoothing.Text; //精加工
            motion.Lb_product.Text = file.Lb_Product.Text;  //產品基底
            if (motion.Lb_product.Text == "筆記本")
                motion.Lb_grouping.Text = "1(A=>B=>C)"; //產線設定
            else motion.Lb_grouping.Text = "2(A=>B=>D)";
            MessageBox.Show("設定成功");
        }
        
        private void MotionBtn_Click(object sender, EventArgs e)
        {
            file.Visible = false;
            motion.Visible = true;
            parameter.Visible = false;
            tool.Visible = false;
        }

        private void ParaBtn_Click(object sender, EventArgs e)
        {
            parameter.Visible = true;
            motion.Visible = false;
            tool.Visible = false;
            file.Visible = false;
        }

        private void btn_Tool_Click(object sender, EventArgs e)
        {
            file.Visible = false;
            parameter.Visible = false;
            motion.Visible = false;
            tool.Visible = true;
        }

        private void Btn_FileManagement_Click(object sender, EventArgs e)
        {
            file.Visible = true;
            parameter.Visible = false;
            motion.Visible = false;
            tool.Visible = false;
        }
    }
}
