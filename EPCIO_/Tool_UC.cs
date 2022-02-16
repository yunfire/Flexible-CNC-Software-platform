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
using System.Data.SqlClient;
using System.Resources;

namespace EPCIO
{
    public partial class Tool_UC : UserControl
    {
        public Tool_UC()
        {
            InitializeComponent();
        }

        void SaveToolData()
        {
            XmlDocument doc = new XmlDocument();
            //建立根節點
            XmlElement toolParam = doc.CreateElement("toolParam");
            doc.AppendChild(toolParam);
            XmlElement info = doc.CreateElement("ToolNumber");
            info = doc.CreateElement("ToolNumber");
            info.InnerText = tb_TlNum.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolSeriesInput");
            info.InnerText = cb_TlSeriesInput.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolOuterDiameter");
            info.InnerText = tb_TlOuterDiameter.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolBlendLength");
            info.InnerText = tb_TlBlendLen.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolBladeNumber");
            info.InnerText = tb_TlBladeNum.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolShankDiameter");
            info.InnerText = tb_TlShankDiameter.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolLength");
            info.InnerText = tb_TlLen.Text; 
            toolParam.AppendChild(info);
            /*info = doc.CreateElement("ToolBallRadius");
            info.InnerText = tb_TlBallRadius.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolEffectiveLen");  
            info.InnerText = tb_EffectiveLen.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolThreadSpecification");
            info.InnerText = tb_TlThreadSpec.Text;
            toolParam.AppendChild(info);
            info = doc.CreateElement("ToolPitch"); //
            info.InnerText = tb_TlPitch.Text;//脈衝模式=0*/
            toolParam.AppendChild(info);

            doc.Save(@"..\..\toolParam\" + cb_TlSeriesInput.Text + tb_TlNum.Text +".xml");
            MessageBox.Show("已成功修改並儲存刀具參數");
        }

        private void ParamLoad()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\toolParam\" + cb_TlSeriesShow.Text+tb_TlNumShow.Text + ".xml");
            XmlNode toolParamNode = doc.DocumentElement.SelectSingleNode("/toolParam");
            Lb_TlSeries.Text = toolParamNode["ToolSeriesInput"].InnerText;   //刀具編號
            Lb_TlOuterDiameter.Text = toolParamNode["ToolOuterDiameter"].InnerText;  //外徑
            Lb_TlBlendLen.Text = toolParamNode["ToolBlendLength"].InnerText;  //刃長
            LB_TlBladeNum.Text = toolParamNode["ToolBladeNumber"].InnerText; //刃數
            Lb_TlShankDiameter.Text = toolParamNode["ToolShankDiameter"].InnerText;  //柄徑
            Lb_TlLen.Text = toolParamNode["ToolLength"].InnerText;
            if (tb_TlNumShow.Text == "MES2A") ptb_Tool.Image = Properties.Resources.端銑刀_MES2A;
            if (tb_TlNumShow.Text == "MEHD4") ptb_Tool.Image = Properties.Resources.端銑刀_MEHD4;
            if (tb_TlNumShow.Text == "MSR4") ptb_Tool.Image = Properties.Resources.圓鼻刀_MSR4;
            if (tb_TlNumShow.Text == "4UDB") ptb_Tool.Image = Properties.Resources.圓鼻刀_4UDB;


            /* Lb_TlBallRadius.Text = toolParamNode["ToolBallRadius"].InnerText;
             Lb_EffectiveLen.Text = toolParamNode["ToolEffectiveLen"].InnerText;
             Lb_TlThreadSpec.Text = toolParamNode["ToolThreadSpecification"].InnerText;
             Lb_TlPitch.Text = toolParamNode["ToolPitch"].InnerText;*/
        }

        DataTable dataTable;
        string cn = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                    " AttachDbFilename = |DataDirectory|Database1.mdf;" +
                    "Integrated Security = True";
        void DealData()
        {
            using (SqlConnection DBcn = new SqlConnection(cn))
            {
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tool", DBcn);
                dataAdapter.Fill(dataSet, "Tool");
              //  dataGridView1.DataSource = dataSet.Tables["Tool"];
                dataTable = dataSet.Tables["Book"];
            }
        }


        private void btn_ToolSave_Click(object sender, EventArgs e)
        {
            SaveToolData();
        }

        private void Btn_ShowTool_Click(object sender, EventArgs e)
        {
            ParamLoad();
        }

        private void Btn_Show_Sql_Click(object sender, EventArgs e)
        {

        }
    }
}
